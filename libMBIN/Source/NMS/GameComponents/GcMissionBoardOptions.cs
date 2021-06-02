using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0x4C591D47CCA6F35A, NameHash = 0xDD272E15749CCDF5)]
    public class GcMissionBoardOptions : NMSTemplate
    {
        /* 0x00 */ public GcMissionType Type;
        /* 0x04 */ public GcMissionDifficulty Difficulty;
        /* 0x08 */ public int MinRank;
        /* 0x0C */ public bool CloseMissionGiver;
        /* 0x0D */ public bool IsGuildShopMission;
        /* 0x0E */ public bool IsPlanetProcMission;
        /* 0x0F */ public bool IsMultiplayerEventMission;
        /* 0x10 */ public NMSString0x10 RewardPenaltyOnAbandon;
        /* 0x20 */ public List<GcMissionFaction> Faction;
        /* 0x30 */ public int Weighting;
        /* 0x34 */ public bool IgnoreCalculatedObjective;
        /* 0x38 */ public NMSString0x20A MultiplayerMissionInitialWarpScanEvent;
        /* 0x58 */ public List<NMSString0x20A> DefaultItemInitialWarpScanEvents;
        public enum DefaultItemTypeForInitialWarpEnum { None, PrimaryProduct, PrimarySubstance, SecondaryProduct, SecondarySubstance }
        /* 0x68 */ public DefaultItemTypeForInitialWarpEnum DefaultItemTypeForInitialWarp;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x6C */ public byte[] Padding6C;
        /* 0x70 */ public List<NMSString0x10> BasePartBlueprints;
    }
}
