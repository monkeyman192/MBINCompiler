using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E19E270B1259544, NameHash = 0x5180E7C9)]
    public class GcSceneSettings : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public GcPlayerSpawnStateData PlayerState;
        [NMS(Index = 4, Size = 0x5)]
        /* 0x0D0 */ public VariableSizeString[] PlanetFiles;
        [NMS(Index = 9)]
        /* 0x120 */ public List<NMSTemplate> Events;
        [NMS(Index = 0)]
        /* 0x130 */ public VariableSizeString NextSettingFile;
        [NMS(Index = 2)]
        /* 0x140 */ public List<VariableSizeString> PlanetSceneFiles;
        [NMS(Index = 10)]
        /* 0x150 */ public List<NMSTemplate> PostWarpEvents;
        [NMS(Index = 1)]
        /* 0x160 */ public VariableSizeString SceneFile;
        [NMS(Index = 5)]
        /* 0x170 */ public List<VariableSizeString> ShipPreloadFiles;
        [NMS(Index = 3)]
        /* 0x180 */ public VariableSizeString SolarSystemFile;
        [NMS(Index = 11)]
        /* 0x190 */ public NMSString0x10 SpawnerOptionId;
        [NMS(Index = 7)]
        /* 0x1A0 */ public bool SpawnInsideShip;
        [NMS(Index = 6)]
        /* 0x1A1 */ public bool SpawnShip;
    }
}
