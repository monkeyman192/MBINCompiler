using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x957D14BA0450E58A, NameHash = 0x9BD23889)]
    public class GcPlanetGenerationIntermediateData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public GcCreatureRoleDataTable CreatureRoles;
        [NMS(Index = 14)]
        /* 0x020 */ public VariableSizeString CreatureAirFile;
        [NMS(Index = 11)]
        /* 0x030 */ public VariableSizeString CreatureCaveFile;
        [NMS(Index = 13)]
        /* 0x040 */ public VariableSizeString CreatureExtraWaterFile;
        [NMS(Index = 10)]
        /* 0x050 */ public VariableSizeString CreatureLandFile;
        [NMS(Index = 15)]
        /* 0x060 */ public VariableSizeString CreatureRobotFile;
        [NMS(Index = 12)]
        /* 0x070 */ public VariableSizeString CreatureWaterFile;
        [NMS(Index = 17)]
        /* 0x080 */ public List<int> ExternalObjectListIndices;
        [NMS(Index = 16)]
        /* 0x090 */ public List<GcExternalObjectListOptions> ExternalObjectLists;
        [NMS(Index = 0)]
        /* 0x0A0 */ public GcSeed Seed;
        [NMS(Index = 9)]
        /* 0x0B0 */ public VariableSizeString TerrainFile;
        [NMS(Index = 6)]
        /* 0x0C0 */ public GcTerrainControls Terrain;
        [NMS(Index = 7)]
        /* 0x138 */ public GcBiomeType Biome;
        [NMS(Index = 8)]
        /* 0x13C */ public GcBiomeSubType BiomeSubType;
        [NMS(Index = 3)]
        /* 0x140 */ public GcPlanetClass Class;
        [NMS(Index = 4)]
        /* 0x144 */ public GcPlanetSize Size;
        [NMS(Index = 2)]
        /* 0x148 */ public GcGalaxyStarTypes StarType;
        [NMS(Index = 1)]
        /* 0x14C */ public int TerrainSettingIndex;
        [NMS(Index = 18)]
        /* 0x150 */ public bool Prime;
    }
}
