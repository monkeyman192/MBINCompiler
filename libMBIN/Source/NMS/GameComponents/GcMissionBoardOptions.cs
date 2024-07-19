using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CDF1BA7CE8518CF, NameHash = 0x90E0452F)]
    public class GcMissionBoardOptions : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x00 */ public NMSString0x20A MultiplayerMissionInitialWarpScanEvent;
        [NMS(Index = 14)]
        /* 0x20 */ public List<NMSString0x10> BasePartBlueprints;
        [NMS(Index = 12)]
        /* 0x30 */ public List<NMSString0x20A> DefaultItemInitialWarpScanEvents;
        [NMS(Index = 8)]
        /* 0x40 */ public List<GcMissionFaction> Faction;
        [NMS(Index = 7)]
        /* 0x50 */ public NMSString0x10 RewardPenaltyOnAbandon;
        // size: 0x5
        public enum DefaultItemTypeForInitialWarpEnum : uint {
            None,
            PrimaryProduct,
            PrimarySubstance,
            SecondaryProduct,
            SecondarySubstance,
        }
        [NMS(Index = 13)]
        /* 0x60 */ public DefaultItemTypeForInitialWarpEnum DefaultItemTypeForInitialWarp;
        [NMS(Index = 1)]
        /* 0x64 */ public GcMissionDifficulty Difficulty;
        [NMS(Index = 2)]
        /* 0x68 */ public int MinRank;
        [NMS(Index = 0)]
        /* 0x6C */ public GcMissionType Type;
        [NMS(Index = 9)]
        /* 0x70 */ public int Weighting;
        [NMS(Index = 3)]
        /* 0x74 */ public bool CloseMissionGiver;
        [NMS(Index = 10)]
        /* 0x75 */ public bool IgnoreCalculatedObjective;
        [NMS(Index = 4)]
        /* 0x76 */ public bool IsGuildShopMission;
        [NMS(Index = 6)]
        /* 0x77 */ public bool IsMultiplayerEventMission;
        [NMS(Index = 5)]
        /* 0x78 */ public bool IsPlanetProcMission;
    }
}
