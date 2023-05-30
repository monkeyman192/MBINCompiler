using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlanetGenerationInputData : NMSTemplate
    {
        public GcSeed Seed;
        public GcGalaxyStarTypes StarType;
        public GcPlanetClass PlanetClass;
        public NMSString0x10 CommonSubstance;
        public NMSString0x10 RareSubstance;
        public GcPlanetSize PlanetSize;
        public GcBiomeType BiomeType;
    }
}
