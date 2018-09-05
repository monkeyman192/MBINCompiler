using System;
using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using libMBIN.Models;

using MBINCompilerTests;
using Database = MBINCompilerTests.Database;

namespace libMBIN.UnitTests.Analysis {

    using TemplateSizes = Database.Tables.TemplateSize;

    [TestClass]
    public class TemplateSizeAnalysis {

        [ClassInitialize]
        public static void ClassInitialize( TestContext context ) {
            RunSettings.Initialize( context );
        }

        [TestMethod, TestCategory( "Analysis" ), TestProperty( "Time", "Fast")]
        public void GenerateTemplateSizeTable() {
            string dataDir = Database.Utils.GetDirectory( libMBIN.Version.NMSVersion );

            var table = new TemplateSizes.Table();

            string logPath = Path.Combine( dataDir , "TemplateSizes.tsv" );

            foreach ( var type in NMSTemplate.NMSTemplateMap.Values ) {
                NMSTemplate template = Activator.CreateInstance( type ) as NMSTemplate;
                table.Add( new TemplateSizes.Record( type.Name, template.GetDataSize() ) );
            }

            Utils.SetFileReadOnly( logPath, false );
            using ( var streamOut = new StreamWriter( logPath ) ) {
                streamOut.WriteLine( "# Tab-separated values. Open with a spreadsheet app such as Excel.\n" );
                streamOut.WriteLine( "# READ-ONLY. DO NOT MODIFY OR DELETE.\n" );
                table.Save( streamOut );
            }
            Utils.SetFileReadOnly( logPath, true );
        }

    }
}
