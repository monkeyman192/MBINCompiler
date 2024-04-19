using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD35227A699C8923E, NameHash = 0xA3D40DA508711D13)]
    public class GcAsteroidGeneratorAssignment : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public GcSolarSystemLocatorChoice Locator;
        /* 0x3C */ public int AsteroidCount;
        /* 0x40 */ public int PlanetIndex;
    }
}
