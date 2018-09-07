using Microsoft.VisualStudio.TestTools.UnitTesting;
using libMBIN;
using System;

namespace MBINCompilerTests
{

    [TestClass]
    public class IntRevTest
    {

        [TestMethod]
        public void TestIntRevFromBytes()
        {
            float[] actualValue = INT_2_10_10_10_REV.FromBytes(1592787842);
            float[] expectedValue = new float[4] { -0.24667928063493072f, 0.0f, 0.9690971739229421f, 1.0f };
            Assert.AreEqual(expectedValue, actualValue, $"Assert Failed: Expected [{expectedValue[0]}, {expectedValue[1]}, {expectedValue[2]}, {expectedValue[3]}] but got [{actualValue[0]}, {actualValue[1]}, {actualValue[2]}, {actualValue[3]}]");
        }

        [TestMethod]
        public void TestIntRevFromVerts()
        {
            int actualValue = INT_2_10_10_10_REV.FromVerts(new float[4] { -0.24667928063493072f, 0.0f, 0.9690971739229421f, 1.0f });
            int expectedValue = 1592787842;
            Assert.AreEqual(expectedValue, actualValue, $"Assert Failed: Expected [{expectedValue}] but got [{actualValue}]");
        }
    }
}