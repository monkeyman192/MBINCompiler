// uncomment/comment this to enable/disable logging of test progress and time profiling
#define LOG_VERBOSE

using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using libMBIN.Models;

using MBINCompilerTests;

namespace libMBIN.UnitTests {

    [TestClass]
    public class SerializationTests {

        private RecompileThreadRunner[] runners;

        private FileState[] files;
        private int nextFileIndex = 0;

        private int finished = 0;
        private long maxTime   = 0;
        private long summedTime = 0;

        private TimeSpan totalTimespan;

        private int[] statusCounters = new int[] { 0, 0, 0, 0 }; // PASSED, MISSING, MISMATCH, FAILED

        private StreamWriter streamOut;

        [ClassInitialize]
        public static void Initialize( TestContext context ) {
            RunSettings.Initialize( context );
            RunSettings.ValidateGameDataDir();
        }

        #region Logging
        private class LogFileStream : StreamWriter {
            string path;

            public LogFileStream( string path ) : base( SetReadOnly( Logger.GetLogPath( path ), false ) ) {
                this.path = path;
            }

            public override void Close() {
                base.Close();
                SetReadOnly( path, true );
            }

            private static string SetReadOnly( string path, bool isReadOnly ) {
                Utils.SetFileReadOnly( path, isReadOnly );
                return path;
            }
        }

        private void LogHeader( StreamWriter streamOut ) {
            Logger.LogMessage( streamOut
                , "# DO NOT MODIFY.\n"
                + "# This file is cached data, read and updated by the Unit Tests.\n"
                + "# Manual changes may break the cached state.\n"
                + "\n"
                + "# This file is formatted as tab-separated values. It can be opened in a program that\n"
                + "# handles TSV format such as Excel, which will properly parse the data into a spreadsheet\n"
                + "# where it can be easily viewed, sorted, searched, etc.\n"
                + "\n"
                + "#STATUS\t#TIME (ms)\t#PATH\t#SIZE (bytes)\t#HASH (SHA1)\t#ERROR MESSAGE" );
        }

        private void LogFileState( StreamWriter logWriter, FileState file ) {
            statusCounters[(int) file.status]++;
            Logger.LogMessage( logWriter, String.Format( "{0,-8}\t{1,8}\t{2}\t{3,8}\t{4}\t{5}",
                        file.status, file.profileTime, file.Path, file.mbinSize, file.hash, file.errorMessage ) );
        }

        private void LogSummary( StreamWriter logWriter, int fileCount ) {
            // don't include missing files or failed tests in avg because they were incomplete and will skew the time
            int numPassed = statusCounters[(int) FileStatus.Passed];
            int numMismatch = statusCounters[(int) FileStatus.Mismatch];
            float avgTime = summedTime / (float) ( numPassed + numMismatch );

            Logger.DebugLogInfo( $"\n"
                        + $"{ fileCount } files processed.\n"
                        + $"PASSED:   { statusCounters[(int) FileStatus.Passed  ] }\n"
                        + $"MISSING:  { statusCounters[(int) FileStatus.Missing ] }\n"
                        + $"MISMATCH: { statusCounters[(int) FileStatus.Mismatch] }\n"
                        + $"FAILED:   { statusCounters[(int) FileStatus.Failed  ] }\n"
                        + $"\n"
                        + $"Avg Recompile Time: { avgTime } ms\n"
                        + $"Max Recompile Time: { maxTime } ms\n"
                        + $"Total Time: { totalTimespan }\n"
                        + $"\n"
            );
        }
        #endregion

        #region FileState
        private enum FileStatus {
            Passed, Missing, Mismatch, Failed, // logged. used as array indices, so must start at 0
            Pending, InProgress // not logged. invalid array indices
        }

        private class FileState {
            // data members
            public string Path { get; private set; }
            public FileStatus status;
            public long profileTime; // total profile time in ms to process this file
            public long mbinSize;
            public string hash;
            public string errorMessage; // if applicable

            // computed
            public string FullPath { get => System.IO.Path.Combine( RunSettings.GameDataDir, this.Path ); }

            // constructors
            public FileState( string path ) {
                this.Path = Utils.AbsoluteToRelativePath( RunSettings.GameDataDir, path );
                this.status = FileStatus.Failed;
            }

            //public override string ToString() => String.Format( "{0,-8}\t{1,8}\t{2}\t{3}\t{4}", status, profileTime, Path, dataSize, hash, errorMessage);

            //public static explicit operator string( FileState file ) => file.ToString();

            public static FileState[] CreateArray( string[] paths ) {
                FileState[] files = new FileState[paths.Length];
                for ( int i = 0; i < files.Length; i++ ) files[i] = new FileState( paths[i] );
                return files;
            }
        }
        #endregion

        #region Compile
        private static MemoryStream Decompile( Stream stream ) {
            using (var file = new MBINFile( stream )) {
                file.Load();
                var data = file.GetData();
                if (data == null) throw new Exception( "deserialized data was null" );

                if (data.SerializeEXml( false ) == null) throw new Exception( "xml serialization was null" );

                var xmlString = EXmlFile.WriteTemplate( data );
                if ( String.IsNullOrEmpty( xmlString ) ) throw new Exception( "xml data is null" );

                MemoryStream memory = new MemoryStream();
                using (TextWriter writer = new StreamWriter( memory, Encoding.Default, 4096, true )) {
                    writer.Write( xmlString );
                }
                memory.Position = 0;
                return memory;
            }
        }

        private static MemoryStream Compile( Stream stream ) {
            var data = EXmlFile.ReadTemplateFromStream( stream );
            if (data == null) throw new Exception( "exml failed to deserialize" );

            MemoryStream memory = new MemoryStream();
            using (var file = new MBINFile( memory, true )) {
                file.Header = new MBINHeader();
                file.Header.SetDefaults();

                // only used by TkGeometryData / .MBIN.PC files, maybe used to signal the file is PC only?
                if (data.GetType().Name == "TkGeometryData") file.Header.Magic = 0xDDDDDDDD;

                file.SetData( data );
                file.Save();
            }
            memory.Position = 0;
            return memory;
        }

        private class RecompileThreadRunner {
            private FileState file;

            public delegate FileState OnFinishedCallback( FileState file );
            private OnFinishedCallback onFinished;

            public RecompileThreadRunner( FileState file, OnFinishedCallback onFinished ) {
                this.file = file;
                this.onFinished = onFinished;
            }

            public void Execute() {
                while ( file != null ) {
                    Stopwatch timer = new Stopwatch();
                    timer.Start();

                    try {
                        var fileStream = File.Open( file.FullPath, FileMode.Open );
                        file.mbinSize = fileStream.Length;

                        var vanillaEXML = Decompile( fileStream );
                        var compiledMBIN = Compile( vanillaEXML );
                        var recompiledEXML = Decompile( compiledMBIN );

                        file.hash = Utils.SHA1.GetHexString( vanillaEXML );
                        string hash = Utils.SHA1.GetHexString( recompiledEXML );

                        vanillaEXML.Dispose();
                        compiledMBIN.Dispose();
                        recompiledEXML.Dispose();

                        // check exml files match
                        if ( hash == file.hash ) { // pass
                            file.status = FileStatus.Passed;
                        } else { // mismatch
                            file.status = FileStatus.Mismatch;
                        }

                    } catch ( FileNotFoundException ) { // missing
                        file.status = FileStatus.Missing;
                    } catch ( Exception e ) { // fail
                        file.status = FileStatus.Failed;
                        file.errorMessage = e.Message;
                    }

                    timer.Stop();
                    file.profileTime = timer.ElapsedMilliseconds;

                    file = onFinished( file );
                }
            }
        }

        private FileState OnThreadFinished( FileState file ) {
            lock ( this ) {
                finished++;
                maxTime = Math.Max( maxTime, file.profileTime );
                summedTime += file.profileTime;
                LogFileState( streamOut, file );

                if (nextFileIndex < files.Length) return files[nextFileIndex++];
            }

            return null;
        }

        private bool Recompile( FileState[] files, StreamWriter streamOut = null ) {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            this.files = files;

            this.statusCounters = new int[] { 0, 0, 0, 0 };
            this.streamOut = streamOut;

            // create the worker threads
            int maxThreads = RunSettings.MaxConcurrentThreads;
            this.runners = new RecompileThreadRunner[maxThreads];
            for (int i = 0; i < maxThreads; i++) {
                if ( nextFileIndex >= files.Length ) break;
                runners[i] = new RecompileThreadRunner( files[nextFileIndex++], OnThreadFinished );
                new Thread( new ThreadStart( runners[i].Execute ) ).Start();
            }

            const int waitInterval = 10; // ms
            while (finished != files.Length) Thread.Sleep( waitInterval );

            timer.Stop();

            totalTimespan = timer.Elapsed;

            return (statusCounters[(int) FileStatus.Passed] == files.Length);
        }
        #endregion

        #region Tests
        [TestMethod, TestProperty( "Time", "Slow" )]
        public void TestRecompileVanillaGameData() {
            // TODO: HACK, for debugging the test
            // Change MAX to restrict how many files will be processed.
            // For unrestricted, set to int.MaxValue
            const int MAX = 20; // TODO FIXME! should be int.MaxValue;

            // TODO: searchPattern should be handled better. *.MBIN and *.MBIN.PC but not *.MBIN.BAK, etc
            // TODO: make searchPattern customizable from .runsettings
            string[] paths = Directory.GetFiles( RunSettings.GameDataDir, "*.MBIN*", SearchOption.AllDirectories );
            Array.Resize( ref paths, Math.Min( MAX, paths.Length ) );

            FileState[] files = FileState.CreateArray( paths );
            using ( var streamOut = new LogFileStream( "GameData Report v1.38.tsv" ) ) { // TODO: hardcoded log file name!
                LogHeader( streamOut );
                bool passed = Recompile( files, streamOut );
                LogSummary( streamOut, files.Length );
                Assert.IsTrue( passed );
            }
        }
        #endregion
    }
}