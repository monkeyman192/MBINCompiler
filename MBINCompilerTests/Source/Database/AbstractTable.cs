using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompilerTests.Database {

    public abstract class AbstractTable<T> : IEnumerable<T> where T : AbstractRecord, new() {

        public abstract string Name { get; }
        public abstract string[] ColumnHeadings { get; }
        public abstract int KeyColumn { get; }

        private string _filePath = null;
        public string FilePath {
            get {
                if ( _filePath == null ) _filePath = Database.Utils.GetTablePath( Name );
                return _filePath;
            }
            protected set { _filePath = value; }
        }

        protected List<T> records;

        public int RecordCount => records.Count;

        public AbstractTable() {
            this.records = new List<T>();
        }

        public AbstractTable( StreamReader streamIn ) : this() { Load( streamIn ); }
        public AbstractTable( string path ) : this() { Load( path ); }

        public void Clear() { records.Clear(); }
        public void Add( T record ) { records.Add( record ); }
        public void Insert( int row, T record ) { records.Insert( row, record ); }
        public void Remove( int row ) { records.RemoveAt( row ); }

        public T GetRecord( int row ) { return records[row]; }
        public void SetRecord( int row, T record ) { records[row] = record; }

        private static string Serialize( string[] fields ) => String.Join( "\t", fields );
        private static string[] Deserialize( string tsv ) => tsv.Split( new char[] { '\t' } ).Select( x => x.Trim( ' ' ) ).ToArray();

        public void Save( string path = null ) {
            if ( path == null ) path = this.FilePath;
            using ( var streamOut = new StreamWriter( path ) ) Save( streamOut );
            this.FilePath = path;
        }

        public void Load( string path = null ) {
            if ( path == null ) path = this.FilePath;
            using ( var streamIn = new StreamReader( path ) ) Load( streamIn );
            this.FilePath = path;
        }

        public void Save( StreamWriter streamOut ) {
            // sort the records first
            records = records.OrderBy( record => record.GetFields()[KeyColumn] ).ToList();

            // output
            this.FilePath = null; // unknown
            if ( ColumnHeadings != null ) {
                // treat headings as comments
                string[] fields = ColumnHeadings.Select( x => "#" + x ).ToArray();
                streamOut.WriteLine( Serialize( fields ) );
            }
            foreach ( var record in records ) streamOut.WriteLine( Serialize( record.GetFields() ) );
        }

        public void Load( StreamReader streamIn ) {
            this.FilePath = null; // unknown
            records.Clear();
            while ( !streamIn.EndOfStream ) {
                string tsv = streamIn.ReadLine().Trim( ' ' );

                // ignore blank, comment and column heading lines
                if ( String.IsNullOrEmpty( tsv ) || tsv.StartsWith( "#" ) ) continue;

                // record
                T record = new T();
                record.SetFields( Deserialize( tsv ) );
                records.Add( record );
            }
        }

        public IEnumerator<T> GetEnumerator() => records.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => records.GetEnumerator();
    }

}
