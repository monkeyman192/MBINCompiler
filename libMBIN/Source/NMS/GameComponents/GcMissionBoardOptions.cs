using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x488C70AF08924F61, NameHash = 0x90E0452F)]
    public class GcMissionBoardOptions : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public NMSString0x20A LocalMissionLocationScanEvent;
        [NMS(Index = 11)]
        /* 0x20 */ public NMSString0x20A MultiplayerMissionInitialWarpScanEvent;
        [NMS(Index = 15)]
        /* 0x40 */ public List<NMSString0x10> BasePartBlueprints;
        [NMS(Index = 13)]
        /* 0x50 */ public List<NMSString0x20A> DefaultItemInitialWarpScanEvents;
        [NMS(Index = 8)]
        /* 0x60 */ public List<GcMissionFaction> Faction;
        [NMS(Index = 16)]
        /* 0x70 */ public List<NMSString0x10> MandatorySalvageEquipment;
        [NMS(Index = 7)]
        /* 0x80 */ public NMSString0x10 RewardPenaltyOnAbandon;
        // size: 0x5
        public enum DefaultItemTypeForInitialWarpEnum : uint {
            None,
            PrimaryProduct,
            PrimarySubstance,
            SecondaryProduct,
            SecondarySubstance,
        }
        [NMS(Index = 14)]
        /* 0x90 */ public DefaultItemTypeForInitialWarpEnum DefaultItemTypeForInitialWarp;
        [NMS(Index = 1)]
        /* 0x94 */ public GcMissionDifficulty Difficulty;
        [NMS(Index = 2)]
        /* 0x98 */ public int MinRank;
        [NMS(Index = 18)]
        /* 0x9C */ public GcSpacePoiType RequireUncompletedPOIOfType;
        [NMS(Index = 0)]
        /* 0xA0 */ public GcMissionType Type;
        [NMS(Index = 9)]
        /* 0xA4 */ public int Weighting;
        [NMS(Index = 3)]
        /* 0xA8 */ public bool CloseMissionGiver;
        [NMS(Index = 10)]
        /* 0xA9 */ public bool IgnoreCalculatedObjective;
        [NMS(Index = 4)]
        /* 0xAA */ public bool IsGuildShopMission;
        [NMS(Index = 6)]
        /* 0xAB */ public bool IsMultiplayerEventMission;
        [NMS(Index = 5)]
        /* 0xAC */ public bool IsPlanetProcMission;
        [NMS(Index = 17)]
        /* 0xAD */ public bool RequireUncompletedPOI;
    }
}
