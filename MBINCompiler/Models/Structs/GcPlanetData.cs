namespace MBINCompiler.Models.Structs
{
    public class GcPlanetData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Name;
        public GcPlanetLife Life;
        public GcPlanetLife CreatureLife;
        public GcPlanetHazardData Hazard;

        public int ResourceLevel;
        /* 0x0100 */ public string[] ResourceLevelValues()
        {
            return new[] { "Low", "High" };
        }

        public GcBuildingDensityLevels BuildingDensityLevels;
        [NMS(Size = 0x10)]
        public string CommonSubstanceID;
        [NMS(Size = 0x10)]
        public string UncommonSubstanceID;
        [NMS(Size = 0x10)]
        public string RareSubstanceID;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding138;

        public GcPlanetColourData Colours;

        [NMS(Size = 0xD)]
        public Colour[] TileColours;
        public GcPlanetWeatherData Weather;
        public GcPlanetWaterData Water;
        [NMS(Size = 0x80)]
        public string TerrainFile;
        public TkVoxelGeneratorData Terrain;
        [NMS(Size = 0xA)]
        public TkListedPaletteTexture[] TileTypes;
        [NMS(Size = 0x80)]
        public string DiffuseTexture;
        [NMS(Size = 0x80)]
        public string NormalMap;
        public GcEnvironmentSpawnData SpawnData;
        public GcAlienRace InhabitingRace;
        public GcPlanetBuildingData BuildingData;
        public GcPlanetGenerationIntermediateData GenerationData;
        public Vector2f SentinelTimer;
        public Vector2f FlybyTimer;
        public GcPlanetInfo PlanetInfo;
        [NMS(Size = 2, Ignore = true)]
        public byte[] Padding2E8A;

        public GcPlanetSentinelData SentinelData;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding2E94;
    }
}
