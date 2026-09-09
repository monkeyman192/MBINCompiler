using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x92833E2C2AC9D4CE, NameHash = 0x95D309FC)]
    public class GcAsteroidSystemGenerationData : NMSTemplate
    {
        [NMS(Index = 0, MxmlName = "Common Asteroid Data")]
        /* 0x00 */ public GcAsteroidGenerationData CommonAsteroidData;
        [NMS(Index = 1, MxmlName = "Fuel Asteroid Data")]
        /* 0x24 */ public GcAsteroidGenerationData FuelAsteroidData;
        [NMS(Index = 3, MxmlName = "Large Asteroid Data")]
        /* 0x48 */ public GcAsteroidGenerationData LargeAsteroidData;
        [NMS(Index = 4, MxmlName = "Rare Asteroid Data")]
        /* 0x6C */ public GcAsteroidGenerationData RareAsteroidData;
        [NMS(Index = 2, MxmlName = "Ring Asteroid Data")]
        /* 0x90 */ public GcAsteroidGenerationData RingAsteroidData;
    }
}
