using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0x9507B42892191B2A, NameHash = 0x71B66F631708B3B1)]
    public class GcSolarSystemEventWarpIn : NMSTemplate
    {
        /* 0x00 */ public GcSolarSystemLocatorChoice Locator;
        /* 0x2C */ public float Time;
        /* 0x30 */ public int Repeat;
        /* 0x34 */ public Vector2f RepeatIntervalRange;
        /* 0x3C */ public bool InvertDirection;
        /* 0x3D */ public bool InstantWarpIn;
        /* 0x3E */ public NMSString0x20 SquadName;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x60 */ public GcSeed Seed;
        /* 0x70 */ public GcRealityCommonFactions Faction;
        /* 0x74 */ public GcAISpaceshipRoles ShipRole;
        /* 0x78 */ public List<int> ShipChoiceSequence;
        /* 0x88 */ public Vector2f ShipCountRange;
        /* 0x90 */ public Vector2f WarpIntervalRange;
        /* 0x98 */ public Vector2f SpeedRange;
    }
}