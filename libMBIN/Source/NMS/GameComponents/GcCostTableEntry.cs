namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2FEEF129329F7E46, NameHash = 0x5923C0EE4B9AD427)]
    public class GcCostTableEntry : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate Cost;
        /* 0x50 */ public NMSString0x20A CannotAffordOSDMsg;
        /* 0x70 */ public NMSString0x20A CommunityContributionCapLocID;
        /* 0x90 */ public NMSString0x10 Id;
        /* 0xA0 */ public NMSString0x10 MissionMessageWhenCharged;
        /* 0xB0 */ public int CommunityContributionValue;
        /* 0xB4 */ public bool DisplayCost;
        /* 0xB5 */ public bool DisplayOnlyCostIfCantAfford;
        /* 0xB6 */ public bool DontCharge;
        /* 0xB7 */ public bool HideCostStringIfCanAfford;
        /* 0xB8 */ public bool HideOptionAndDisplayCostOnly;
        /* 0xB9 */ public bool InvertCanAffordOutcome;
        /* 0xBA */ public bool MustAffordInCreative;
        /* 0xBB */ public bool RemoveOptionIfCantAfford;
    }
}
