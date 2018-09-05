using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x4E0)]
    public class GcSceneSettings : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string NextSettingFile;

        [NMS(Size = 0x80)]
        /* 0x080 */ public string SceneFile;

        /* 0x100 */ public List<NMSString0x80> PlanetSceneFiles;

        [NMS(Size = 0x80)]
        /* 0x110 */ public string SolarSystemFile;

        [NMS(Size = 0x5)]
        /* 0x190 */ public NMSString0x80[] PlanetFiles;

        /* 0x410 */ public List<NMSString0x80> ShipPreloadFiles;
        /* 0x420 */ public bool SpawnShip;
        /* 0x421 */ public bool SpawnInsideShip;

        [NMS(Size = 0xE, Ignore = true)]
        /* 0x422 */ public byte[] Padding422;

        /* 0x430 */ public GcPlayerSpawnStateData PlayerState;

        /* 0x4B0 */ public List<NMSTemplate> Events;
        /* 0x4C0 */ public List<NMSTemplate> PostWarpEvents;

        [NMS(Size = 0x10)]
        /* 0x4D0 */ public string SpawnerOptionId;
    }
}
