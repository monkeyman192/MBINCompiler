using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60FA4350EFA4CE84, NameHash = 0xDD272E15749CCDF5)]
    public class GcMissionBoardOptions : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A MultiplayerMissionInitialWarpScanEvent;
        /* 0x20 */ public List<NMSString0x10> BasePartBlueprints;
        /* 0x30 */ public List<NMSString0x20A> DefaultItemInitialWarpScanEvents;
        /* 0x40 */ public List<GcMissionFaction> Faction;
        /* 0x50 */ public NMSString0x10 RewardPenaltyOnAbandon;
        // size: 0x5
        public enum DefaultItemTypeForInitialWarpEnum : uint {
            None,
            PrimaryProduct,
            PrimarySubstance,
            SecondaryProduct,
            SecondarySubstance,
        }
        /* 0x60 */ public DefaultItemTypeForInitialWarpEnum DefaultItemTypeForInitialWarp;
        /* 0x64 */ public GcMissionDifficulty Difficulty;
        /* 0x68 */ public int MinRank;
        /* 0x6C */ public GcMissionType Type;
        /* 0x70 */ public int Weighting;
        /* 0x74 */ public bool CloseMissionGiver;
        /* 0x75 */ public bool IgnoreCalculatedObjective;
        /* 0x76 */ public bool IsGuildShopMission;
        /* 0x77 */ public bool IsMultiplayerEventMission;
        /* 0x78 */ public bool IsPlanetProcMission;
    }
}
