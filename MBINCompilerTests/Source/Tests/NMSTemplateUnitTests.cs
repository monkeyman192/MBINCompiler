using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace libMBIN.UnitTests
{
    [TestClass]
    public class NMSTemplateUnitTests
    {
        [TestMethod]
        public void TestOffsetOf() {
            Assert.AreEqual(0x1EA8, NMSTemplate.OffsetOf("GcGameplayGlobals", "WeaponSpawnAltObject"));
            Assert.AreEqual(0x198, NMSTemplate.OffsetOf("GcAIShipSpawnData", "ChildSpawns"));
            Assert.AreEqual(0x16C, NMSTemplate.OffsetOf("GcAIShipSpawnData", "Spread"));
            Assert.AreEqual(0x2C, NMSTemplate.OffsetOf("GcCreatureDebugSpawnData", "SmoothTimer"));
            Assert.AreEqual(0x0, NMSTemplate.OffsetOf("GcCustomisationColourPalettes", "ColourPalettes"));
            Assert.AreEqual(0x5140, NMSTemplate.OffsetOf("GcCustomisationColourPalettes", "ExtraData"));
        }
    }
}
