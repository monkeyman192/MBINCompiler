using Microsoft.VisualStudio.TestTools.UnitTesting;

using libMBIN.Models.Structs;

namespace libMBIN.UnitTests {

    [TestClass]
    public class MBINCompilerTemplateTests {

        [TestMethod, TestProperty( "Time", "Fast" )]
        public void TestMBINCompilerTemplate() {
            const string path = "../../MBINCompilerTestTemplate.MBIN";
            var file = new MBINFile( path );
            file.Load();
            Assert.AreEqual( "MBINCompilerTestTemplate", file.Header.GetXMLTemplateName(), $"{path} header not using TemplateType MBINCompilerTestTemplate!" );

            var data = file.GetData();
            Assert.IsNotNull( data, $"{path} deserialized data was null" );
            Assert.IsNotNull( data.SerializeEXml( false ), $"{path} xml serialization was null" );
            Assert.IsInstanceOfType( data, typeof( MBINCompilerTestTemplate ), $"{path} template isn't of type MBINCompilerTestTemplate!" );

            MBINCompilerTestTemplate test = (MBINCompilerTestTemplate) data;
            Assert.AreEqual( true   , test.TestBoolTrue  );
            Assert.AreEqual( false  , test.TestBoolFalse );
            Assert.AreEqual( true   , test.TestBool3     );
            Assert.AreEqual( 1337   , test.TestInt16     );
            Assert.AreEqual( 2448   , test.TestInt32     );
            Assert.AreEqual( 3559   , test.TestInt64     );
            Assert.AreEqual( 1337.0 , test.TestFloat     );
            Assert.AreEqual( 1      , test.TestEnumYes   );
            Assert.AreEqual( 0      , test.TestEnumNo    );

            var expectedString = "SixteenByteStrng";
            Assert.AreEqual( expectedString, test.TestString );

            var expectedDynamicString = "NoWayToControlItIt'sTotallyDynamicWheneverYou'reAround";
            Assert.AreEqual( expectedDynamicString, test.TestDynamicString.Value );

            string[] expectedStrings = new[] { "FirstEntry", "SecondEntry", "ThirdEntry" };
            Assert.AreEqual( expectedStrings.Length, test.Test0x80ByteStringList.Count );

            for ( int i = 0; i < expectedStrings.Length; i++ ) {
                Assert.AreEqual( expectedStrings[i], test.Test0x80ByteStringList[i].Value );
            }
        }

    }
}
