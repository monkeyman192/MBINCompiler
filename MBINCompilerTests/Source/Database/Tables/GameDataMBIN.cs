using System.Globalization;

namespace MBINCompilerTests.Database.Tables.GameDataMBIN {
    public class Table : AbstractTable<Record> {

        private static string NAME = "GameDataMBIN";
        private static string[] COLUMN_HEADINGS = new string[] {
            "Path", "Template Name", "File Size (bytes)", "Header Magic ID", "Header Version", "Build DateTime", "Template GUID", "SHA1"
        };

        public override string Name => NAME;
        public override string[] ColumnHeadings => COLUMN_HEADINGS;

    }

    public class Record : AbstractRecord {

        public string Path { get; set; }
        public long   FileSize { get; set; }
        public string SHA1 { get; set; }
        public uint   HeaderMagicID { get; set; }
        public int    HeaderVersion { get; set; }
        public ulong  BuildDateTime { get; set; }
        public ulong  TemplateGUID { get; set; }
        public string TemplateName { get; set; }

        public Record() { }

        public Record(  string path, long fileSize, string sha1,
                        uint headerMagicID, int headerVersion, ulong buildDateTime, ulong templateGUID, string templateName
        ) : this() {
            this.Path          = path;
            this.TemplateName  = templateName;
            this.FileSize      = fileSize;
            this.HeaderMagicID = headerMagicID;
            this.HeaderVersion = headerVersion;
            this.BuildDateTime = buildDateTime;
            this.TemplateGUID  = templateGUID;
            this.SHA1          = sha1;
        }

        public Record( string path, long fileSize, string sha1, libMBIN.Models.MBINHeader header )
            : this( path, fileSize, sha1, header.Magic, header.Version, header.Tag, header.MbinVersion, header.GetXMLTemplateName() ) { }

        //public GameDataFileRecord( string[] fields ) : this() { SetFields( fields ); }

        internal override void SetFields( string[] fields ) {
            int i = 0;
            this.Path          = fields[i++];
            this.TemplateName  = fields[i++];
            this.FileSize      = ParseLong(  fields[i++] );
            this.HeaderMagicID = ParseUint(  fields[i++] );
            this.HeaderVersion = ParseInt(   fields[i++] );
            this.BuildDateTime = ParseUlong( fields[i++] );
            this.TemplateGUID  = ParseUlong( fields[i++] );
            this.SHA1          = ParseHex(   fields[i++] );
        }

        internal override string[] GetFields() {
            return new string[] {
                Path,
                TemplateName,
                ToHexString( FileSize ),
                ToHexString( HeaderMagicID ),
                ToHexString( HeaderVersion ),
                ToHexString( BuildDateTime ),
                ToHexString( TemplateGUID ),
                ToHexString( SHA1 )
            };
        }

        //public static explicit operator GameDataFileRecord( string[] fields ) => new GameDataFileRecord( fields );

    }

}
