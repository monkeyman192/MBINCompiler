using System.Globalization;

namespace MBINCompilerTests.Database.Tables.GameDataFile {

    public class Table : AbstractTable<Record> {

        private static string NAME = "GameDataFile";
        private static string[] COLUMN_HEADINGS = new string[] { "File Type", "Path", "File Size (bytes)", "SHA1" };

        public override string Name => NAME;
        public override string[] ColumnHeadings => COLUMN_HEADINGS;
        public override int KeyColumn => 2;

    }

    public class Record : AbstractRecord {

        private string _type;
        public string Type {
            get => _type;
            set =>_type = (value == "PC") ? "MBIN" : value; // MBIN is assumed if *.PC!
        }

        private string _path;
        public string Path {
            get => _path;
            set {
                _path = value;
                Type = System.IO.Path.GetExtension( _path ).TrimStart( '.' );
            }
        }

        public long Size { get; set; }
        public string SHA1 { get; set; }

        public Record() { }

        public Record( string type, string path, long size, string sha1 ) : this() {
            this.Type = type;
            this.Path = path;
            this.Size = size;
            this.SHA1 = sha1;
        }

        public Record( string path, long size, string sha1 ) : this( "", path, size, sha1 ) { }

        //public GameDataFileRecord( string[] fields ) : this() { SetFields( fields ); }

        internal override void SetFields( string[] fields ) {
            int i = 0;
            this.Type = fields[i++];
            this.Path = fields[i++];
            this.Size = ParseLong( fields[i++] );
            this.SHA1 = ParseHex(  fields[i++] );
        }

        internal override string[] GetFields() {
            return new string[] {
                Type,
                Path,
                ToHexString( Size ),
                ToHexString( SHA1 )
            };
        }

        //public static explicit operator GameDataFileRecord( string[] fields ) => new GameDataFileRecord( fields );

    }

}
