using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x450, GUID = 0x867F18146DAFFE58, NameHash = 0x166980043AF05C9E)]
    public class GcPlanetGenerationIntermediateData : NMSTemplate
    {
        /* 0x000 */ public GcSeed Seed;
        /* 0x010 */ public int TerrainSettingIndex;
        /* 0x014 */ public GcGalaxyStarTypes StarType;
        /* 0x018 */ public GcPlanetClass PlanetClass;
        /* 0x01C */ public GcPlanetSize PlanetSize;
        /* 0x020 */ public GcCreatureRoleDataTable CreatureRoles;
        /* 0x030 */ public GcTerrainControls Terrain;
        /* 0x0A8 */ public GcBiomeType Biome;
        /* 0x0AC */ public GcBiomeSubType BiomeSubType;

        [NMS(Size = 0x80)]
        /* 0x0B0 */ public string TerrainFile;
        [NMS(Size = 0x80)]
        /* 0x130 */ public string CreatureLandFile;
        [NMS(Size = 0x80)]
        /* 0x1B0 */ public string CreatureCaveFile;
        [NMS(Size = 0x80)]
        /* 0x230 */ public string CreatureWaterFile;
        [NMS(Size = 0x80)]
        /* 0x2B0 */ public string CreatureExtraWaterFile;
        [NMS(Size = 0x80)]
        /* 0x330 */ public string CreatureAirFile;
        [NMS(Size = 0x80)]
        /* 0x3B0 */ public string CreatureRobotFile;
        /* 0x430 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        /* 0x440 */ public List<int> ExternalObjectListIndices;
    }
}
