using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSceneSettings : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string NextSettingFile;

        [NMS(Size = 0x80)]
        /* 0x080 */ public string SceneFile;

        /* 0x100 */ public List<NMSString0x80> PlanetSceneFiles;

        [NMS(Size = 0x80)]
        /* 0x110 */ public string SolarSystemFile;

        [NMS(Size = 0x80)]
        /* 0x190 */ public string PlanetFiles1;

        [NMS(Size = 0x80)]
        /* 0x210 */ public string PlanetFiles2;

        [NMS(Size = 0x80)]
        /* 0x290 */ public string PlanetFiles3;

        [NMS(Size = 0x80)]
        /* 0x310 */ public string PlanetFiles4;

        [NMS(Size = 0x80)]
        /* 0x390 */ public string PlanetFiles5;

        /* 0x410 */ public List<NMSString0x80> ShipPreloadFiles;
        /* 0x420 */ public bool SpawnShip;
        /* 0x421 */ public bool SpawnInsideShip;

        [NMS(Size = 0xE, Ignore = true)]
        /* 0x422 */ public byte[] Padding422;

        /* 0x430 */ public GcPlayerSpawnStateData PlayerState;

        /* 0x480 */ public List<NMSTemplate> Events;
        /* 0x490 */ public List<NMSTemplate> PostWarpEvents;

        [NMS(Size = 0x10)]
        /* 0x4A0 */ public string SpawnerOptionId;
    }
}
