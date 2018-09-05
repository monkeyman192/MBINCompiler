using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x3D0)]
    public class GcPlanetGenerationIntermediateData : NMSTemplate
    {
        /* 0x000 */ public GcSeed Seed;
        /* 0x010 */ public int TerrainSettingIndex;
        /* 0x014 */ public GcGalaxyStarTypes GalaxyStarType;
        /* 0x018 */ public GcPlanetClass PlanetClass;
        /* 0x01C */ public GcPlanetSize PlanetSize;
        /* 0x020 */ public GcCreatureRoleDataTable CreatureRoleData;
        /* 0x030 */ public GcTerrainControls Terrain;
        /* 0x0A4 */ public GcBiomeType Biome;
        /* 0x0A8 */ public int BiomeFileIndex;

        [NMS(Size = 0x80)]
        /* 0x0AC */ public string TerrainFile;
        [NMS(Size = 0x80)]
        /* 0x12C */ public string CreatureLandFile;
        [NMS(Size = 0x80)]
        /* 0x1AC */ public string CreatureCaveFile;
        [NMS(Size = 0x80)]
        /* 0x22C */ public string CreatureWaterFile;
        [NMS(Size = 0x80)]
        /* 0x2AC */ public string CreatureAirFile;
        [NMS(Size = 0x80)]
        /* 0x32C */ public string CreatureRobotFile;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3AC */ public byte[] Padding3AC;
        /* 0x3B0 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        /* 0x3C0 */ public List<int> ExternalObjectListIndices;
    }
}
