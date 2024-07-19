using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D155C0F26AFFE31, NameHash = 0x90C3AAAC)]
    public class GcSolarSystemEventWarpIn : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public GcSeed Seed;
        [NMS(Index = 10)]
        /* 0x10 */ public List<int> ShipChoiceSequence;
        [NMS(Index = 0)]
        /* 0x20 */ public GcSolarSystemLocatorChoice Locator;
        [NMS(Index = 3)]
        /* 0x4C */ public Vector2f RepeatIntervalRange;
        [NMS(Index = 11)]
        /* 0x54 */ public Vector2f ShipCountRange;
        [NMS(Index = 13)]
        /* 0x5C */ public Vector2f SpeedRange;
        [NMS(Index = 12)]
        /* 0x64 */ public Vector2f WarpIntervalRange;
        [NMS(Index = 8)]
        /* 0x6C */ public GcRealityCommonFactions Faction;
        [NMS(Index = 2)]
        /* 0x70 */ public int Repeat;
        [NMS(Index = 9)]
        /* 0x74 */ public GcAISpaceshipRoles ShipRole;
        [NMS(Index = 1)]
        /* 0x78 */ public float Time;
        [NMS(Index = 6)]
        /* 0x7C */ public NMSString0x20 SquadName;
        [NMS(Index = 5)]
        /* 0x9C */ public bool InstantWarpIn;
        [NMS(Index = 4)]
        /* 0x9D */ public bool InvertDirection;
    }
}
