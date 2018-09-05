using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompilerTests.Database {

    public static class Utils {

        private static string _rootDirectory = "Database";
        public static string RootDirectory {
            get { return _rootDirectory; }
            set {
                _rootDirectory = value;
                if ( Path.IsPathRooted( _rootDirectory ) ) return;
                _rootDirectory = Path.Combine( RunSettings.ProjectDir, _rootDirectory );
            }
        }

        private static string _currentDatabase = "";
        public static string CurrentDatabase {
            get {
                if ( _currentDatabase == "" ) _currentDatabase = RunSettings.GameDataVersion.ToString();
                return _currentDatabase;
            }
            set { _currentDatabase = value; }
        }

        public static string CurrentDirectory => GetDirectory( CurrentDatabase );

        public static string GetDirectory( string dbName, bool create = true ) {
            string path = Path.Combine( RootDirectory, dbName );
            if (create) Directory.CreateDirectory( path ); // create the directory path if it doesn't exist
            return path;
        }

        public static string GetDirectory( System.Version version ) => GetDirectory( version.ToString() );

        public static string GetTablePath( string dbName, string tableName ) {
            return Path.Combine( GetDirectory( dbName ), $"{tableName}.tsv" );
        }

        public static string GetTablePath( string tableName ) {
            return GetTablePath( CurrentDatabase, tableName );
        }

    }

}
