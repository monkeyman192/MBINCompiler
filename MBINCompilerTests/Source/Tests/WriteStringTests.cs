using System.Collections.Generic;
using System.IO;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace libMBIN.UnitTests.BinaryStream {

    [TestClass]
    public class WriteStringTests {

        private class TestCase {

            public string Value { get; set; }

            public Encoding Encoding { get; set; }

            public int? Size { get; set; }

            public bool NullTerminated { get; set; }

            public byte[] Expected { get; set; }

            public override string ToString() {
                string size = Size.HasValue ? Size.ToString() : "null";
                return $"{nameof( Size )}: {size}, {nameof( NullTerminated )}: {NullTerminated}, Value: \'{Value}\'";
            }

        }

        private class TestCaseASCII : TestCase {

            public TestCaseASCII() : base() {
                this.Encoding = Encoding.ASCII;
                this.NullTerminated = false;
            }

        }

        private class TestCaseASCIIsz : TestCase {

            public TestCaseASCIIsz() : base() {
                this.Encoding = Encoding.ASCII;
                this.NullTerminated = true;
            }

        }

        private class TestCaseUTF8 : TestCase {

            public TestCaseUTF8() : base() {
                this.Encoding = Encoding.UTF8;
                this.NullTerminated = false;
            }

        }

        private class TestCaseUTF8sz : TestCase {

            public TestCaseUTF8sz() : base() {
                this.Encoding = Encoding.UTF8;
                this.NullTerminated = true;
            }

        }

        [TestMethod, TestProperty( "Time", "Fast" )]
        public void TestWriteStringAscii() {
            List<TestCase> testCases = new List<TestCase>() {
                new TestCaseASCII   { Value = "",    Size = null, Expected = new byte[] { } }
               ,new TestCaseASCII   { Value = "abc", Size = null, Expected = new byte[] { 0x61, 0x62, 0x63 } }

               ,new TestCaseASCII   { Value = "",    Size = null, Expected = new byte[] { } }
               ,new TestCaseASCII   { Value = "abc", Size = 2,    Expected = new byte[] { 0x61, 0x62 } }
               ,new TestCaseASCII   { Value = "abc", Size = 3,    Expected = new byte[] { 0x61, 0x62, 0x63 } }
               ,new TestCaseASCII   { Value = "abc", Size = 4,    Expected = new byte[] { 0x61, 0x62, 0x63, 0x00 } }

               ,new TestCaseASCIIsz { Value = "",    Size = null, Expected = new byte[] { 0x00 } }

               ,new TestCaseASCIIsz { Value = "abc", Size = null, Expected = new byte[] { 0x61, 0x62, 0x63, 0x00 } }

               ,new TestCaseASCIIsz { Value = "",    Size = 0,    Expected = new byte[] { } }
               ,new TestCaseASCIIsz { Value = "",    Size = 2,    Expected = new byte[] { 0x00, 0x00 } }

               ,new TestCaseASCIIsz { Value = "abc", Size = 1,    Expected = new byte[] { 0x00 } }
               ,new TestCaseASCIIsz { Value = "abc", Size = 2,    Expected = new byte[] { 0x61, 0x00 } }
               ,new TestCaseASCIIsz { Value = "abc", Size = 5,    Expected = new byte[] { 0x61, 0x62, 0x63, 0x00, 0x00 } }
            };

            RunWriteStringTests( testCases );
        }

        [TestMethod, TestProperty( "Time", "Fast" )]
        public void TestWriteStringUtf8() {
            List<TestCase> testCases = new List<TestCase>() {
                new TestCaseUTF8 { Value = "", Size = null, Expected = new byte[] { } }
               ,new TestCaseUTF8 { Value = "𠜎𢱑𩶘", Size = null, Expected = new byte[] {
                    0xF0, 0xA0, 0x9C, 0x8E,
                    0xF0, 0xA2, 0xB1, 0x91,
                    0xF0, 0xA9, 0xB6, 0x98
                } }

               //,new TestCaseUTF8 { Value = "𠜎𢱑𩶘", Size = 7, Expected = new byte[] { 0xF0, 0xA0, 0x9C, 0x8E } }
               ,new TestCaseUTF8 { Value = "𠜎𢱑𩶘", Size = 8, Expected = new byte[] {
                    0xF0, 0xA0, 0x9C, 0x8E,
                    0xF0, 0xA2, 0xB1, 0x91,
                } }
               ,new TestCaseUTF8 { Value = "𠜎𢱑𩶘", Size = 12, Expected = new byte[] {
                    0xF0, 0xA0, 0x9C, 0x8E,
                    0xF0, 0xA2, 0xB1, 0x91,
                    0xF0, 0xA9, 0xB6, 0x98
                } }
               ,new TestCaseUTF8 { Value = "𠜎𢱑𩶘", Size = 13, Expected = new byte[] {
                    0xF0, 0xA0, 0x9C, 0x8E,
                    0xF0, 0xA2, 0xB1, 0x91,
                    0xF0, 0xA9, 0xB6, 0x98,
                    0x00
                } }

               ,new TestCaseUTF8sz { Value = "", Size = null, Expected = new byte[] { 0x00 } }
               ,new TestCaseUTF8sz { Value = "𠜎𢱑𩶘", Size = null, Expected = new byte[] {
                    0xF0, 0xA0, 0x9C, 0x8E,
                    0xF0, 0xA2, 0xB1, 0x91,
                    0xF0, 0xA9, 0xB6, 0x98,
                    0x00
                } }

               ,new TestCaseUTF8sz { Value = "", Size = 0, Expected = new byte[] { } }
               ,new TestCaseUTF8sz { Value = "", Size = 2, Expected = new byte[] { 0x00, 0x00 } }

               ,new TestCaseUTF8sz { Value = "𠜎𢱑𩶘", Size = 1, Expected = new byte[] { 0x00 } }
               //,new TestCaseUTF8sz { Value = "𠜎𢱑𩶘", Size = 8, Expected = new byte[] {
               //     0xF0, 0xA0, 0x9C, 0x8E,
               //     0x00, 0x00, 0x00, 0x00
               // } }
               ,new TestCaseUTF8sz { Value = "𠜎𢱑𩶘", Size = 14, Expected = new byte[] {
                    0xF0, 0xA0, 0x9C, 0x8E,
                    0xF0, 0xA2, 0xB1, 0x91,
                    0xF0, 0xA9, 0xB6, 0x98,
                    0x00, 0x00
                } }
            };

            RunWriteStringTests( testCases );
       }

        private static void RunWriteStringTests( List<TestCase> testCases ) {
            foreach ( var testCase in testCases ) {
                var stream = new MemoryStream();
                var writer = new BinaryWriter( stream );

                writer.WriteString( testCase.Value, testCase.Encoding, testCase.Size, testCase.NullTerminated );

                byte[] actual = stream.ToArray();
                CollectionAssert.AreEqual( testCase.Expected, actual, testCase.ToString() );
            }
        }
    }
}