using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBADC6797B5A16762, NameHash = 0x64786DD8F4475C9B)]
    public class GcSettlementJudgementOption : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A OptionText;
        /* 0x20 */ public List<NMSString0x10> AdditionalRewards;
        /* 0x30 */ public NMSString0x10 ChainedJudgementID;
        /* 0x40 */ public List<GcSettlementJudgementPerkOption> Perks;
        /* 0x50 */ public List<GcSettlementStatChange> StatChanges;
        /* 0x60 */ public bool HidePerkInJudgement;
        /* 0x61 */ public bool OptionIsPositiveForNPC;
        /* 0x62 */ public bool UseGiftReward;
        /* 0x63 */ public bool UsePolicyPerk;
        /* 0x64 */ public bool UsePolicyStat;
        /* 0x65 */ public bool UseTechPerk;
    }
}
