using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x510, GUID = 0x7CA24430493DA074, NameHash = 0xF75874C269CFFEA3)]
    public class GcSceneSettings : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 NextSettingFile;

        /* 0x080 */ public NMSString0x80 SceneFile;

        /* 0x100 */ public List<NMSString0x80> PlanetSceneFiles;

        /* 0x110 */ public NMSString0x80 SolarSystemFile;

        [NMS(Size = 0x5)]
        /* 0x190 */ public NMSString0x80[] PlanetFiles;

        /* 0x410 */ public List<NMSString0x80> ShipPreloadFiles;
        /* 0x420 */ public bool SpawnShip;
        /* 0x421 */ public bool SpawnInsideShip;

        [NMS(Size = 0xE, Ignore = true)]
        /* 0x422 */ public byte[] Padding422;

        /* 0x430 */ public GcPlayerSpawnStateData PlayerState;

        /* 0x4E0 */ public List<NMSTemplate> Events;
        /* 0x4F0 */ public List<NMSTemplate> PostWarpEvents;

        /* 0x500 */ public NMSString0x10 SpawnerOptionId;
    }
}
