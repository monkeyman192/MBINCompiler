using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97AEF0310BDAF14F, NameHash = 0x90E0452F)]
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
        [NMS(Index = 15)]
        /* 0x50 */ public List<NMSString0x10> MandatorySalvageEquipment;
        [NMS(Index = 7)]
        /* 0x60 */ public NMSString0x10 RewardPenaltyOnAbandon;
        // size: 0x5
        public enum DefaultItemTypeForInitialWarpEnum : uint {
            None,
            PrimaryProduct,
            PrimarySubstance,
            SecondaryProduct,
            SecondarySubstance,
        }
        [NMS(Index = 13)]
        /* 0x70 */ public DefaultItemTypeForInitialWarpEnum DefaultItemTypeForInitialWarp;
        [NMS(Index = 1)]
        /* 0x74 */ public GcMissionDifficulty Difficulty;
        [NMS(Index = 2)]
        /* 0x78 */ public int MinRank;
        [NMS(Index = 17)]
        /* 0x7C */ public GcSpacePoiType RequireUncompletedPOIOfType;
        [NMS(Index = 0)]
        /* 0x80 */ public GcMissionType Type;
        [NMS(Index = 9)]
        /* 0x84 */ public int Weighting;
        [NMS(Index = 3)]
        /* 0x88 */ public bool CloseMissionGiver;
        [NMS(Index = 10)]
        /* 0x89 */ public bool IgnoreCalculatedObjective;
        [NMS(Index = 4)]
        /* 0x8A */ public bool IsGuildShopMission;
        [NMS(Index = 6)]
        /* 0x8B */ public bool IsMultiplayerEventMission;
        [NMS(Index = 5)]
        /* 0x8C */ public bool IsPlanetProcMission;
        [NMS(Index = 16)]
        /* 0x8D */ public bool RequireUncompletedPOI;
    }
}
