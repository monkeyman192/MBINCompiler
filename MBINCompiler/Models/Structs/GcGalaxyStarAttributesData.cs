namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyStarAttributesData : NMSTemplate // size = 0x58
    {
        public GcGalaxyStarTypes Type;
        public GcGalaxyStarAnomaly Anomaly;
        public int NumberOfPlanets;
        [NMS(Size = 0x10)]
        public GcPlanetSize[] PlanetSizes;
        [NMS(Size = 0x10)]
        public int[] PlanetParentIndices;
        [NMS(Size = 0x10)]
        public GcSeed[] PlanetSeeds;
    }
}
