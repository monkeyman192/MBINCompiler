using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x125F6767075D5BDB, NameHash = 0x3514EB26)]
    public class GcSettlementJudgementOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A OptionText;
        [NMS(Index = 4)]
        /* 0x20 */ public List<NMSString0x10> AdditionalRewards;
        [NMS(Index = 5)]
        /* 0x30 */ public NMSString0x10 ChainedJudgementID;
        [NMS(Index = 1)]
        /* 0x40 */ public List<GcSettlementJudgementPerkOption> Perks;
        [NMS(Index = 3)]
        /* 0x50 */ public List<GcSettlementStatChange> StatChanges;
        [NMS(Index = 2)]
        /* 0x60 */ public bool HidePerkInJudgement;
        [NMS(Index = 10)]
        /* 0x61 */ public bool OptionIsPositiveForNPC;
        [NMS(Index = 8)]
        /* 0x62 */ public bool UseGiftReward;
        [NMS(Index = 6)]
        /* 0x63 */ public bool UsePolicyPerk;
        [NMS(Index = 7)]
        /* 0x64 */ public bool UsePolicyStat;
        [NMS(Index = 9)]
        /* 0x65 */ public bool UseTechPerk;
    }
}
