using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlanetData : NMSTemplate
    {
        public NMSString0x80 Name;
        public GcPlanetLife Life;
        public GcPlanetLife CreatureLife;
        public GcPlanetHazardData Hazard;

        /* 0x100 */ public int ResourceLevel;
        public string[] ResourceLevelValues()
        {
            return new[] { "Low", "High" };
        }

        public GcBuildingDensityLevels BuildingDensityLevels;
        public NMSString0x10 CommonSubstanceID;
        public NMSString0x10 UncommonSubstanceID;
        public NMSString0x10 RareSubstanceID;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding138;

        public GcPlanetColourData Colours;

        [NMS(Size = 0xD)]
        public Colour[] TileColours;
        public GcPlanetWeatherData Weather;
        public GcPlanetWaterData Water;
        public NMSString0x80 TerrainFile;
        public TkVoxelGeneratorData Terrain;
        [NMS(Size = 0xA)]
        public TkPaletteTexture[] TileTypes;
        public NMSString0x80 DiffuseTexture;
        public NMSString0x80 NormalMap;
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
