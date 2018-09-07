using System;
using System.IO;
using System.Threading;

using MBINCompilerTests;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Database = MBINCompilerTests.Database;

namespace libMBIN.UnitTests.Analysis
{

    using GameDataFile = Database.Tables.GameDataFile;
    using Logger = MBINCompilerTests.Logger;

    [TestClass]
    public class GameDataFileAnalysis {

        private struct GeneratorState {
            public GameDataFile.Table Table { get; set; }

            private string[] files;
            private int next;

            public int FileCount => files?.Length ?? 0;

            public int Finished { get; set; }
            public bool IsFinished => (Finished == FileCount);

            public StreamWriter LogStream { get; set; }

            public GeneratorState( GameDataFile.Table table, string[] files, StreamWriter logStream = null ) {
                this.Table = table;
                this.files = files;
                this.next = 0;
                this.Finished = 0;
                this.LogStream = logStream;
            }

            public string NextFile() {
                string file = (next < FileCount) ? files[next++] : null;
                if ( file != null ) Logger.LogMessage( LogStream, file );
                return file;
            }
        }

        private GeneratorState CurrentState;
        private ThreadRunner[] runners;

        [ClassInitialize]
        public static void ClassInitialize( TestContext context ) {
            RunSettings.Initialize( context );
            RunSettings.ValidateGameDataDir();
        }

        public class ThreadRunner {
            private string file;

            public delegate string OnFinishedCallback( GameDataFile.Record record );
            private OnFinishedCallback onFinished;

            public ThreadRunner( string file, OnFinishedCallback onFinished ) {
                this.file = file;
                this.onFinished = onFinished;
            }

            public void Execute() {
                while (file != null) {
                    GameDataFile.Record record = null;

                    var path = Utils.AbsoluteToRelativePath( RunSettings.GameDataDir, file );
                    bool skip = path.StartsWith( "PCBANKS\\" );
                    skip |= path.StartsWith( "SHADERCACHE\\" );

                    if ( !skip ) {
                        long size = new FileInfo( file ).Length;
                        string hash = Utils.SHA1.GetHexString( file );
                        record = new GameDataFile.Record( path, size, hash );
                    }

                    file = onFinished( record );
                    Thread.Yield();
                }
            }

        }

        private string OnThreadFinished( GameDataFile.Record record ) {
            lock ( this ) {
                CurrentState.Finished++;
                if ( record != null ) CurrentState.Table.Add( record );
                return CurrentState.NextFile();
            }
        }

        [TestMethod, TestCategory( "Analysis" ), TestProperty( "Time", "Slow" )]
        public void GenerateGameDataFileTable() {

            // TODO: HACK, for debugging the test
            // Change MAX to restrict how many files will be processed.
            // For unrestricted, set to int.MaxValue
            const int MAX = int.MaxValue;// 10000; // TODO FIXME! should be int.MaxValue;

            var table = new GameDataFile.Table();
            if ( File.Exists( table.FilePath ) ) throw new APIException( $"A {table.Name} table already exists!\n{table.FilePath}" );

            string[] files = Directory.GetFiles( RunSettings.GameDataDir, "*", SearchOption.AllDirectories );
            Array.Resize( ref files, Math.Min( MAX, files.Length ) );

            CurrentState = new GeneratorState( table, files );

            string logPath = Logger.GetLogPath( "GameDataFiles.log" );
            using ( CurrentState.LogStream = new StreamWriter( logPath ) { AutoFlush = true } ) {

                int maxThreads = RunSettings.MaxConcurrentThreads;
                this.runners = new ThreadRunner[maxThreads];
                for ( int i = 0; i < maxThreads; i++ ) {
                    string file = CurrentState.NextFile();
                    if ( file == null ) break;
                    runners[i] = new ThreadRunner( file, OnThreadFinished );
                    new Thread( new ThreadStart( runners[i].Execute ) ).Start();
                }

                while ( !CurrentState.IsFinished ) Thread.Sleep( 10 ); // ms

                table.Save();

            }

        }

    }
}
