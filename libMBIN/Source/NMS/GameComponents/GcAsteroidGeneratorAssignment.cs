using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAsteroidGeneratorAssignment : NMSTemplate // 0x48 bytes
    {
        public int PlanetIndex;
        public GcSolarSystemLocatorChoice Locator;
        public GcSeed Seed;
        public int AsteroidCount;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding44;
    }
}
