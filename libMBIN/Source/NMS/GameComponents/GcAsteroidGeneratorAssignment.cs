using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBBB06D4BB08E4128, NameHash = 0xA3D40DA508711D13)]
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
