using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x29B05B34F3DFDABA, NameHash = 0x166980043AF05C9E)]
    public class GcPlanetGenerationIntermediateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public GcCreatureRoleDataTable CreatureRoles;
        [NMS(Index = 17)]
        /* 0x020 */ public List<int> ExternalObjectListIndices;
        [NMS(Index = 16)]
        /* 0x030 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        [NMS(Index = 0)]
        /* 0x040 */ public GcSeed Seed;
        [NMS(Index = 6)]
        /* 0x050 */ public GcTerrainControls Terrain;
        [NMS(Index = 7)]
        /* 0x0C8 */ public GcBiomeType Biome;
        [NMS(Index = 8)]
        /* 0x0CC */ public GcBiomeSubType BiomeSubType;
        [NMS(Index = 3)]
        /* 0x0D0 */ public GcPlanetClass Class;
        [NMS(Index = 4)]
        /* 0x0D4 */ public GcPlanetSize Size;
        [NMS(Index = 2)]
        /* 0x0D8 */ public GcGalaxyStarTypes StarType;
        [NMS(Index = 1)]
        /* 0x0DC */ public int TerrainSettingIndex;
        [NMS(Index = 14)]
        /* 0x0E0 */ public NMSString0x80 CreatureAirFile;
        [NMS(Index = 11)]
        /* 0x160 */ public NMSString0x80 CreatureCaveFile;
        [NMS(Index = 13)]
        /* 0x1E0 */ public NMSString0x80 CreatureExtraWaterFile;
        [NMS(Index = 10)]
        /* 0x260 */ public NMSString0x80 CreatureLandFile;
        [NMS(Index = 15)]
        /* 0x2E0 */ public NMSString0x80 CreatureRobotFile;
        [NMS(Index = 12)]
        /* 0x360 */ public NMSString0x80 CreatureWaterFile;
        [NMS(Index = 9)]
        /* 0x3E0 */ public NMSString0x80 TerrainFile;
        [NMS(Index = 18)]
        /* 0x460 */ public bool Prime;
    }
}
