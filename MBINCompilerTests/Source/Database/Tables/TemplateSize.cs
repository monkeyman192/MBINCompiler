using System.Globalization;

namespace MBINCompilerTests.Database.Tables.TemplateSize {

    public class Table : AbstractTable<Record> {

        private static string NAME = "TemplateSize";
        private static string[] COLUMN_HEADINGS = new string[] { "Template Name", "Size (bytes)" };

        public override string Name => NAME;
        public override string[] ColumnHeadings => COLUMN_HEADINGS;
        public override int KeyColumn => 1;

    }

    public class Record : AbstractRecord {

        public string TemplateName { get; set; }
        public   long TemplateSize { get; set; }

        public Record() { }

        public Record( string templateName, long templateSize ) : this() {
            this.TemplateName = templateName;
            this.TemplateSize = templateSize;
        }

        //public TemplateSizeRecord( string[] fields ) : this() { SetFields( fields ); }

        internal override void SetFields( string[] fields ) {
            int i = 0;
            TemplateName = fields[i++];
            TemplateSize = ParseLong( fields[i++] );
        }

        internal override string[] GetFields() {
            return new string[] {
                TemplateName,
                ToHexString( TemplateSize ),
            };
        }

        //public static explicit operator TemplateSizeRecord( string[] fields ) => new TemplateSizeRecord( fields );

    }

}
