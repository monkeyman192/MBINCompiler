using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x64B0FDB2C959986B, NameHash = 0x71B66F631708B3B1)]
    public class GcSolarSystemEventWarpIn : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public List<int> ShipChoiceSequence;
        /* 0x20 */ public GcSolarSystemLocatorChoice Locator;
        /* 0x4C */ public Vector2f RepeatIntervalRange;
        /* 0x54 */ public Vector2f ShipCountRange;
        /* 0x5C */ public Vector2f SpeedRange;
        /* 0x64 */ public Vector2f WarpIntervalRange;
        /* 0x6C */ public GcRealityCommonFactions Faction;
        /* 0x70 */ public int Repeat;
        /* 0x74 */ public GcAISpaceshipRoles ShipRole;
        /* 0x78 */ public float Time;
        /* 0x7C */ public NMSString0x20 SquadName;
        /* 0x9C */ public bool InstantWarpIn;
        /* 0x9D */ public bool InvertDirection;
    }
}
