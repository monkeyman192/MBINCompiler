using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD26FD07D79850476, NameHash = 0x2EC0DFAA)]
    public class GcAsteroidGeneratorAssignment : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcSeed Seed;
        [NMS(Index = 1)]
        /* 0x10 */ public GcSolarSystemLocatorChoice Locator;
        [NMS(Index = 3)]
        /* 0x3C */ public int AsteroidCount;
        [NMS(Index = 0)]
        /* 0x40 */ public int PlanetIndex;
    }
}
