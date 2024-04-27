using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace libMBIN.UnitTests {

    [TestClass]
    public class MBINHeaderTestsV1 {

        private const string NULL_VERSION_STRING = "0.0.0.0";

        private static readonly string VERSION_STRING = Version.AssemblyVersion.ToString( 3 );
        private static readonly string VERSION_STRING_PADDED = VERSION_STRING.PadRight( 8, '\0' );

        private static readonly ulong  VERSION_ID = MBINHeader.StringToUlong( VERSION_STRING_PADDED );

        private const string TEMPLATE_NAME = "templateName";
        private const ulong  END_PADDING   = 0ul;


        private const ulong  TIMESTAMP     = 201809071631;
        private const ulong  TEMPLATE_GUID = 0xF1E2D3C4B5A6978;

        private static readonly NMSAttribute[] attrTkAnimMetadata = (NMSAttribute[]) typeof( NMS.Toolkit.TkAnimMetadata ).GetCustomAttributes( typeof( NMSAttribute ), false );
        private static readonly ulong TKANIMMETADATA_GUID = ((attrTkAnimMetadata?.Length ?? 0) != 0) ? attrTkAnimMetadata[0].GUID : 0;

        private static readonly NMSAttribute[] attrTkGeometryData = (NMSAttribute[]) typeof( NMS.Toolkit.TkGeometryData ).GetCustomAttributes( typeof( NMSAttribute ), false );
        private static readonly ulong TKGEOMETRYDATA_GUID = ((attrTkGeometryData?.Length ?? 0) != 0) ? attrTkGeometryData[0].GUID : 0;

        private MBINHeader CreateMockHeader(
                    uint magic    = MBINHeader.MBIN_MAGIC,
                    uint formatID = MBINHeader.MBIN_VERSION_OLD,
                    ulong tag     = MBINHeader.MBINCVER_TAG,
                    ulong version = ~0ul,
                    string name   = TEMPLATE_NAME,
                    ulong padding = END_PADDING
        ) {
            return new MBINHeader() {
                MagicID       = magic,
                FormatID      = formatID,
                Tag           = tag,
                MbinVersion   = (version == ~0ul) ? VERSION_ID : version,
                TemplateName  = name,
                EndPadding    = padding
            };
        }

        private MBINHeader HeaderCommon => CreateMockHeader();
        private MBINHeader HeaderTkGeometryData => CreateMockHeader(
                    magic:   MBINHeader.MBIN_MAGIC_PC,
                    tag:     MBINHeader.TKGEOMETRYDATA_TAG,
                    version: TKGEOMETRYDATA_GUID,
                    padding: MBINHeader.TKGEOMETRYDATA_PADDING
        );
        private MBINHeader HeaderTkAnimMetadata => CreateMockHeader(
                    tag:     MBINHeader.TKANIMMETADATA_TAG,
                    version: TKANIMMETADATA_GUID,
                    padding: MBINHeader.TKANIMMETADATA_PADDING
        );

        [TestMethod]
        public void TestIsValid() {
            Assert.IsTrue( HeaderCommon.IsValid );
            Assert.IsTrue( HeaderTkGeometryData.IsValid );
            Assert.IsTrue( HeaderTkAnimMetadata.IsValid );
        }

        [TestMethod]
        public void TestGetFormat() {
            Assert.AreEqual( 1, HeaderCommon.GetFormat() );
            Assert.AreEqual( 0, HeaderTkGeometryData.GetFormat() );
            Assert.AreEqual( 0, HeaderTkAnimMetadata.GetFormat() );
        }

        [TestMethod]
        public void TestIsFormatV0() {
            Assert.IsFalse( HeaderCommon.IsFormatV0 );
            Assert.IsTrue(  HeaderTkGeometryData.IsFormatV0 );
            Assert.IsTrue(  HeaderTkAnimMetadata.IsFormatV0 );
        }

        [TestMethod]
        public void TestIsFormatV1() {
            Assert.IsTrue(  HeaderCommon.IsFormatV1 );
            Assert.IsFalse( HeaderTkGeometryData.IsFormatV1 );
            Assert.IsFalse( HeaderTkAnimMetadata.IsFormatV1 );
        }

        [TestMethod]
        public void TestIsFormatV2() {
            Assert.IsFalse( HeaderCommon.IsFormatV2 );
            Assert.IsFalse( HeaderTkGeometryData.IsFormatV2 );
            Assert.IsFalse( HeaderTkAnimMetadata.IsFormatV2 );
        }

        [TestMethod]
        public void TestStringToUlong() {
            Assert.AreEqual( VERSION_ID, MBINHeader.StringToUlong( VERSION_STRING_PADDED ) );
        }

        [TestMethod]
        public void TestUlongToString() {
            Assert.AreEqual( VERSION_STRING_PADDED, MBINHeader.UlongToString( VERSION_ID ) );
        }

        [TestMethod]
        public void TestCreateHeaderCommon() {
            Assert.AreEqual( MBINHeader.MBIN_MAGIC,   HeaderCommon.MagicID );
            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD, HeaderCommon.FormatID );
            Assert.AreEqual( MBINHeader.MBINCVER_TAG, HeaderCommon.Timestamp );
            Assert.AreEqual( VERSION_ID,              HeaderCommon.TemplateGUID );
            Assert.AreEqual( TEMPLATE_NAME,           HeaderCommon.TemplateName );
            Assert.AreEqual( END_PADDING,             HeaderCommon.EndPadding );

            Assert.AreEqual( VERSION_STRING,          HeaderCommon.GetMBINVersion().ToString() );
        }

        [TestMethod]
        public void TestCreateHeaderTkGeometryData() {
            Assert.AreEqual( MBINHeader.MBIN_MAGIC_PC,          HeaderTkGeometryData.MagicID );
            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD,           HeaderTkGeometryData.FormatID );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_TAG,     HeaderTkGeometryData.Timestamp );
            Assert.AreEqual( TKGEOMETRYDATA_GUID,               HeaderTkGeometryData.TemplateGUID );
            Assert.AreEqual( TEMPLATE_NAME,                     HeaderTkGeometryData.TemplateName );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_PADDING, HeaderTkGeometryData.EndPadding );

            //Assert.AreEqual( VERSION_STRING,                    HeaderTkGeometryData.GetMBINVersion().ToString() );
        }

        [TestMethod]
        public void TestCreateHeaderTkAnimMetadata() {
            Assert.AreEqual( MBINHeader.MBIN_MAGIC,             HeaderTkAnimMetadata.MagicID );
            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD,           HeaderTkAnimMetadata.FormatID );
            Assert.AreEqual( MBINHeader.TKANIMMETADATA_TAG,     HeaderTkAnimMetadata.Timestamp );
            Assert.AreEqual( TKANIMMETADATA_GUID,               HeaderTkAnimMetadata.TemplateGUID );
            Assert.AreEqual( TEMPLATE_NAME,                     HeaderTkAnimMetadata.TemplateName );
            Assert.AreEqual( MBINHeader.TKANIMMETADATA_PADDING, HeaderTkAnimMetadata.EndPadding );
        }

        [TestMethod]
        public void TestSetDefaultsV1Common() {
            var header = new MBINHeader();
            header.SetDefaultsV1();

            Assert.AreEqual( MBINHeader.MBIN_MAGIC,   header.MagicID );
            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD, header.FormatID );
            Assert.AreEqual( MBINHeader.MBINCVER_TAG, header.Tag );
            Assert.AreEqual( VERSION_ID,              header.MbinVersion );
            Assert.AreEqual( "",                      header.TemplateName );
            Assert.AreEqual( END_PADDING,             header.EndPadding );

            Assert.AreEqual( VERSION_STRING,          header.GetMBINVersion().ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsV1TkGeometry() {
            var header = new MBINHeader();
            header.SetDefaultsV1( typeof( NMS.Toolkit.TkGeometryData ) );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC_PC,          header.MagicID );
            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD,           header.FormatID );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_TAG,     header.Tag );
            Assert.AreEqual( TKGEOMETRYDATA_GUID,               header.MbinVersion );
            Assert.AreEqual( "",                                header.TemplateName );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_PADDING, header.EndPadding );

            //Assert.AreEqual( VERSION_STRING,           header.GetMBINVersion().ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsV1TkAnimMetadata() {
            var header = new MBINHeader();
            header.SetDefaultsV1( typeof( NMS.Toolkit.TkAnimMetadata ) );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC,             header.MagicID );
            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD,           header.FormatID );
            Assert.AreEqual( MBINHeader.TKANIMMETADATA_TAG,     header.Tag );
            Assert.AreEqual( TKANIMMETADATA_GUID,               header.MbinVersion );
            Assert.AreEqual( "",                                header.TemplateName );
            Assert.AreEqual( MBINHeader.TKANIMMETADATA_PADDING, header.EndPadding );

            Assert.AreEqual( NULL_VERSION_STRING,               header.GetMBINVersion().ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsCommon() {
            var header = new MBINHeader();
            header.SetDefaults( format: MBINHeader.Format.V1 );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC,   header.MagicID      );
            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD, header.FormatID     );
            Assert.AreEqual( MBINHeader.MBINCVER_TAG, header.Tag          );
            Assert.AreEqual( VERSION_ID,              header.MbinVersion  );
            Assert.AreEqual( "",                      header.TemplateName );
            Assert.AreEqual( END_PADDING,             header.EndPadding   );

            Assert.AreEqual( VERSION_STRING,          header.GetMBINVersion().ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsTkGeometry() {
            var header = new MBINHeader();
            header.SetDefaults( typeof( NMS.Toolkit.TkGeometryData ), MBINHeader.Format.V1 );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC_PC,          header.MagicID );
            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD,           header.FormatID );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_TAG,     header.Tag );
            Assert.AreEqual( TKGEOMETRYDATA_GUID,               header.MbinVersion );
            Assert.AreEqual( "",                                header.TemplateName );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_PADDING, header.EndPadding );

            //Assert.AreEqual( VERSION_STRING,      header.GetMBINVersion().ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsTkAnimMetadata() {
            var header = new MBINHeader();
            header.SetDefaults( typeof( NMS.Toolkit.TkAnimMetadata ), MBINHeader.Format.V1 );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC,             header.MagicID );
            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD,           header.FormatID );
            Assert.AreEqual( MBINHeader.TKANIMMETADATA_TAG,     header.Tag );
            Assert.AreEqual( TKANIMMETADATA_GUID,               header.MbinVersion );
            Assert.AreEqual( "",                                header.TemplateName );
            Assert.AreEqual( MBINHeader.TKANIMMETADATA_PADDING, header.EndPadding );

            Assert.AreEqual( NULL_VERSION_STRING,               header.GetMBINVersion().ToString() );
        }

    }

}
