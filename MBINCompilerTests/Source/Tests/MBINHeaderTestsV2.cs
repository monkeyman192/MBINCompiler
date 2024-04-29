using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace libMBIN.UnitTests {

    [TestClass]
    public class MBINHeaderTestsV2 {

        private const ushort FORMAT_V0 = 0;
        private const ushort FORMAT_V2 = 2;

        private const uint FORMAT_ID0 = (MBINHeader.MBIN_VERSION_OLD & 0xFFFF) | (FORMAT_V0 & 0xFFFF) << 16;
        private const uint FORMAT_ID2 = (MBINHeader.MBIN_VERSION_OLD & 0xFFFF) | (FORMAT_V2 & 0xFFFF) << 16;

        private static readonly System.Version NMS_VERSION = Version.NMSVersion;
        private static readonly System.Version API_VERSION = Version.AssemblyVersion;

        private static readonly string NMS_VERSION_STRING = NMS_VERSION.ToString();
        private static readonly string API_VERSION_STRING = API_VERSION.ToString();

        private static readonly byte[] NMS_VERSION_BYTES = new byte[] {
            (byte) NMS_VERSION.Major, (byte) NMS_VERSION.Minor, (byte) NMS_VERSION.Build, (byte) NMS_VERSION.Revision
        };

        private static readonly byte[] API_VERSION_BYTES = new byte[] {
            (byte) API_VERSION.Major, (byte) API_VERSION.Minor, (byte) API_VERSION.Build, (byte) API_VERSION.Revision
        };

        private static readonly uint NMS_VERSION_ID = BitConverter.ToUInt32( NMS_VERSION_BYTES, 0 ); // 0x00003B01;
        private static readonly uint API_VERSION_ID = BitConverter.ToUInt32( API_VERSION_BYTES, 0 ); // 0x02003B01;

        private static readonly ulong VERSION_ID = (NMS_VERSION_ID & 0xFFFFFFFF) | (((ulong) API_VERSION_ID & 0xFFFFFFFF) << 32);

        private const ulong  TEMPLATE_GUID = 0xF1E2D3C4B5A6978;

        private const string TEMPLATE_NAME = "templateName";
        private const ulong  METAOFFSET    = 0ul;

        private static readonly NMSAttribute[] attrTkGeometryData = (NMSAttribute[]) typeof( NMS.Toolkit.TkGeometryData ).GetCustomAttributes( typeof( NMSAttribute ), false );
        private static readonly ulong TKGEOMETRYDATA_GUID = ((attrTkGeometryData?.Length ?? 0) != 0) ? attrTkGeometryData[0].GUID : 0;

        private MBINHeader CreateMockHeader(
                    uint magic        = MBINHeader.MBIN_MAGIC,
                    uint formatID     = FORMAT_ID2,
                    ulong versionID   = ~1ul,
                    ulong guid        = TEMPLATE_GUID,
                    string name       = TEMPLATE_NAME,
                    ulong metaOffset  = METAOFFSET
        ) {
            return new MBINHeader() {
                MagicID       = magic,
                FormatID      = formatID,
                VersionID     = (versionID == ~1ul) ? VERSION_ID : versionID,
                TemplateGUID  = guid,
                TemplateName  = name,
                MetaOffset    = metaOffset
            };
        }

        private MBINHeader HeaderCommon => CreateMockHeader();
        private MBINHeader HeaderTkGeometryData => CreateMockHeader(
                magic:      MBINHeader.MBIN_MAGIC_PC,
                formatID:   MBINHeader.MBIN_VERSION_OLD,
                versionID:  MBINHeader.TKGEOMETRYDATA_TAG,
                guid:       TKGEOMETRYDATA_GUID,
                metaOffset: MBINHeader.TKGEOMETRYDATA_PADDING
        );

        [TestMethod]
        public void TestIsValid() {
            Assert.IsTrue( HeaderCommon.IsValid );
            Assert.IsTrue( HeaderTkGeometryData.IsValid );
        }

        [TestMethod]
        public void TestGetFormat() {
            Assert.AreEqual( 2, HeaderCommon.GetFormat() );
            Assert.AreEqual( 0, HeaderTkGeometryData.GetFormat() );
        }

        [TestMethod]
        public void TestIsFormatV0() {
            Assert.IsFalse( HeaderCommon.IsFormatV0 );
            Assert.IsTrue(  HeaderTkGeometryData.IsFormatV0 );
        }

        [TestMethod]
        public void TestIsFormatV1() {
            Assert.IsFalse( HeaderCommon.IsFormatV1 );
            Assert.IsFalse( HeaderTkGeometryData.IsFormatV1 );
        }

        [TestMethod]
        public void TestIsFormatV2() {
            Assert.IsTrue(  HeaderCommon.IsFormatV2 );
            Assert.IsFalse( HeaderTkGeometryData.IsFormatV2 );
        }

        [TestMethod]
        public void TestCreateHeaderCommon() {
            Assert.AreEqual( MBINHeader.MBIN_MAGIC,     HeaderCommon.MagicID );
            Assert.AreEqual( FORMAT_ID2,                HeaderCommon.FormatID );
            Assert.AreEqual( VERSION_ID,                HeaderCommon.VersionID );
            Assert.AreEqual( TEMPLATE_GUID,             HeaderCommon.TemplateGUID );
            Assert.AreEqual( TEMPLATE_NAME,             HeaderCommon.TemplateName );
            Assert.AreEqual( METAOFFSET,                HeaderCommon.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD,   HeaderCommon.FormatNMS );
            Assert.AreEqual( FORMAT_V2,                 HeaderCommon.FormatAPI );

            Assert.AreEqual( NMS_VERSION_ID,            HeaderCommon.VersionID_NMS );
            Assert.AreEqual( API_VERSION_ID,            HeaderCommon.VersionID_API );

            Assert.AreEqual( NMS_VERSION_STRING,        HeaderCommon.VersionNMS.ToString() );
            Assert.AreEqual( API_VERSION_STRING,        HeaderCommon.VersionAPI.ToString() );
        }

        [TestMethod]
        public void TestCreateHeaderTkGeometryData() {
            Assert.AreEqual( MBINHeader.MBIN_MAGIC_PC,          HeaderTkGeometryData.MagicID      );
            Assert.AreEqual( FORMAT_ID0,                        HeaderTkGeometryData.FormatID     );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_TAG,     HeaderTkGeometryData.VersionID    );
            Assert.AreEqual( TKGEOMETRYDATA_GUID,               HeaderTkGeometryData.TemplateGUID );
            Assert.AreEqual( TEMPLATE_NAME,                     HeaderTkGeometryData.TemplateName );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_PADDING, HeaderTkGeometryData.MetaOffset   );

            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD,           HeaderTkGeometryData.FormatNMS    );
            Assert.AreEqual( FORMAT_V0,                         HeaderTkGeometryData.FormatAPI    );
        }

        [TestMethod]
        public void TestSetDefaultsV2Common() {
            var header = new MBINHeader();
            header.SetDefaultsV2();

            Assert.AreEqual( MBINHeader.MBIN_MAGIC,   header.MagicID );
            Assert.AreEqual( FORMAT_ID2,              header.FormatID );
            Assert.AreEqual( VERSION_ID,              header.VersionID );
            Assert.AreEqual( 0ul,                     header.TemplateGUID );
            Assert.AreEqual( "",                      header.TemplateName );
            Assert.AreEqual( 0ul,                     header.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD, header.FormatNMS );
            Assert.AreEqual( FORMAT_V2,               header.FormatAPI );

            Assert.AreEqual( NMS_VERSION_STRING,      header.VersionNMS.ToString() );
            Assert.AreEqual( API_VERSION_STRING,      header.VersionAPI.ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsV2TkGeometry() {
            var header = new MBINHeader();
            header.SetDefaultsV2( typeof( NMS.Toolkit.TkGeometryData ) );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC_PC,          header.MagicID               );
            Assert.AreEqual( FORMAT_ID0,                        header.FormatID              );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_TAG,     header.VersionID             );
            Assert.AreEqual( TKGEOMETRYDATA_GUID,               header.TemplateGUID          );
            Assert.AreEqual( "",                                header.TemplateName          );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_PADDING, header.MetaOffset            );

            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD,           header.FormatNMS             );
            Assert.AreEqual( FORMAT_V0,                         header.FormatAPI             );
        }

        [TestMethod]
        public void TestSetDefaultsCommon() {
            var header = new MBINHeader();
            header.SetDefaults( format: MBINHeader.Format.V2 );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC,   header.MagicID );
            Assert.AreEqual( FORMAT_ID2,              header.FormatID );
            Assert.AreEqual( VERSION_ID,              header.VersionID );
            Assert.AreEqual( 0ul,                     header.TemplateGUID );
            Assert.AreEqual( "",                      header.TemplateName );
            Assert.AreEqual( 0ul,                     header.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD, header.FormatNMS );
            Assert.AreEqual( FORMAT_V2,               header.FormatAPI );

            Assert.AreEqual( NMS_VERSION_STRING,      header.VersionNMS.ToString() );
            Assert.AreEqual( API_VERSION_STRING,      header.VersionAPI.ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsTkGeometry() {
            var header = new MBINHeader();
            header.SetDefaults( typeof( NMS.Toolkit.TkGeometryData ), MBINHeader.Format.V2 );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC_PC,          header.MagicID );
            Assert.AreEqual( FORMAT_ID0,                        header.FormatID );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_TAG,     header.VersionID );
            Assert.AreEqual( TKGEOMETRYDATA_GUID,               header.TemplateGUID );
            Assert.AreEqual( "",                                header.TemplateName );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_PADDING, header.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD,           header.FormatNMS );
            Assert.AreEqual( FORMAT_V0,                         header.FormatAPI );
        }

        [TestMethod]
        public void TestSetDefaultsImplicitCommon() {
            var header = new MBINHeader();
            header.SetDefaults();

            Assert.AreEqual( MBINHeader.MBIN_MAGIC,   header.MagicID );
            Assert.AreEqual( FORMAT_ID2,               header.FormatID );
            Assert.AreEqual( VERSION_ID,              header.VersionID );
            Assert.AreEqual( 0ul,                     header.TemplateGUID );
            Assert.AreEqual( "",                      header.TemplateName );
            Assert.AreEqual( 0ul,                     header.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD, header.FormatNMS );
            Assert.AreEqual( FORMAT_V2,               header.FormatAPI );

            Assert.AreEqual( NMS_VERSION_STRING,      header.VersionNMS.ToString() );
            Assert.AreEqual( API_VERSION_STRING,      header.VersionAPI.ToString() );
        }

        [TestMethod]
        public void TestSetDefaultsImplicitTkGeometry() {
            var header = new MBINHeader();
            header.SetDefaults( typeof( NMS.Toolkit.TkGeometryData ) );

            Assert.AreEqual( MBINHeader.MBIN_MAGIC_PC,          header.MagicID );
            Assert.AreEqual( FORMAT_ID0,                        header.FormatID );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_TAG,     header.VersionID );
            Assert.AreEqual( TKGEOMETRYDATA_GUID,               header.TemplateGUID );
            Assert.AreEqual( "",                                header.TemplateName );
            Assert.AreEqual( MBINHeader.TKGEOMETRYDATA_PADDING, header.MetaOffset );

            Assert.AreEqual( MBINHeader.MBIN_VERSION_OLD,           header.FormatNMS );
            Assert.AreEqual( FORMAT_V0,                         header.FormatAPI );
        }

    }

}
