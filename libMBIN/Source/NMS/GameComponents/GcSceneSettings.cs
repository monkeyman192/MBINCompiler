using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3D244C4E181E581D, NameHash = 0xF75874C269CFFEA3)]
    public class GcSceneSettings : NMSTemplate
    {
        /* 0x000 */ public GcPlayerSpawnStateData PlayerState;
        /* 0x0D0 */ public List<NMSTemplate> Events;
        /* 0x0E0 */ public List<NMSString0x80> PlanetSceneFiles;
        /* 0x0F0 */ public List<NMSTemplate> PostWarpEvents;
        /* 0x100 */ public List<NMSString0x80> ShipPreloadFiles;
        /* 0x110 */ public NMSString0x10 SpawnerOptionId;
        [NMS(Size = 0x5)]
        /* 0x120 */ public NMSString0x80[] PlanetFiles;
        /* 0x3A0 */ public NMSString0x80 NextSettingFile;
        /* 0x420 */ public NMSString0x80 SceneFile;
        /* 0x4A0 */ public NMSString0x80 SolarSystemFile;
        /* 0x520 */ public bool SpawnInsideShip;
        /* 0x521 */ public bool SpawnShip;
    }
}
