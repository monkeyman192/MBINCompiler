using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x29B05B34F3DFDABA, NameHash = 0x166980043AF05C9E)]
    public class GcPlanetGenerationIntermediateData : NMSTemplate
    {
        /* 0x000 */ public GcCreatureRoleDataTable CreatureRoles;
        /* 0x020 */ public List<int> ExternalObjectListIndices;
        /* 0x030 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        /* 0x040 */ public GcSeed Seed;
        /* 0x050 */ public GcTerrainControls Terrain;
        /* 0x0C8 */ public GcBiomeType Biome;
        /* 0x0CC */ public GcBiomeSubType BiomeSubType;
        /* 0x0D0 */ public GcPlanetClass Class;
        /* 0x0D4 */ public GcPlanetSize Size;
        /* 0x0D8 */ public GcGalaxyStarTypes StarType;
        /* 0x0DC */ public int TerrainSettingIndex;
        /* 0x0E0 */ public NMSString0x80 CreatureAirFile;
        /* 0x160 */ public NMSString0x80 CreatureCaveFile;
        /* 0x1E0 */ public NMSString0x80 CreatureExtraWaterFile;
        /* 0x260 */ public NMSString0x80 CreatureLandFile;
        /* 0x2E0 */ public NMSString0x80 CreatureRobotFile;
        /* 0x360 */ public NMSString0x80 CreatureWaterFile;
        /* 0x3E0 */ public NMSString0x80 TerrainFile;
        /* 0x460 */ public bool Prime;
    }
}
