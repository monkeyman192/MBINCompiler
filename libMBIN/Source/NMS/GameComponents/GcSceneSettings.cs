using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3D244C4E181E581D, NameHash = 0xF75874C269CFFEA3)]
    public class GcSceneSettings : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public GcPlayerSpawnStateData PlayerState;
        [NMS(Index = 9)]
        /* 0x0D0 */ public List<NMSTemplate> Events;
        [NMS(Index = 2)]
        /* 0x0E0 */ public List<NMSString0x80> PlanetSceneFiles;
        [NMS(Index = 10)]
        /* 0x0F0 */ public List<NMSTemplate> PostWarpEvents;
        [NMS(Index = 5)]
        /* 0x100 */ public List<NMSString0x80> ShipPreloadFiles;
        [NMS(Index = 11)]
        /* 0x110 */ public NMSString0x10 SpawnerOptionId;
        [NMS(Index = 4, Size = 0x5)]
        /* 0x120 */ public NMSString0x80[] PlanetFiles;
        [NMS(Index = 0)]
        /* 0x3A0 */ public NMSString0x80 NextSettingFile;
        [NMS(Index = 1)]
        /* 0x420 */ public NMSString0x80 SceneFile;
        [NMS(Index = 3)]
        /* 0x4A0 */ public NMSString0x80 SolarSystemFile;
        [NMS(Index = 7)]
        /* 0x520 */ public bool SpawnInsideShip;
        [NMS(Index = 6)]
        /* 0x521 */ public bool SpawnShip;
    }
}
