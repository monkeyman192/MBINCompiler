namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2FEEF129329F7E46, NameHash = 0x5923C0EE4B9AD427)]
    public class GcCostTableEntry : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x00 */ public NMSTemplate Cost;
        [NMS(Index = 11)]
        /* 0x50 */ public NMSString0x20A CannotAffordOSDMsg;
        [NMS(Index = 10)]
        /* 0x70 */ public NMSString0x20A CommunityContributionCapLocID;
        [NMS(Index = 0)]
        /* 0x90 */ public NMSString0x10 Id;
        [NMS(Index = 12)]
        /* 0xA0 */ public NMSString0x10 MissionMessageWhenCharged;
        [NMS(Index = 9)]
        /* 0xB0 */ public int CommunityContributionValue;
        [NMS(Index = 1)]
        /* 0xB4 */ public bool DisplayCost;
        [NMS(Index = 4)]
        /* 0xB5 */ public bool DisplayOnlyCostIfCantAfford;
        [NMS(Index = 2)]
        /* 0xB6 */ public bool DontCharge;
        [NMS(Index = 5)]
        /* 0xB7 */ public bool HideCostStringIfCanAfford;
        [NMS(Index = 3)]
        /* 0xB8 */ public bool HideOptionAndDisplayCostOnly;
        [NMS(Index = 7)]
        /* 0xB9 */ public bool InvertCanAffordOutcome;
        [NMS(Index = 8)]
        /* 0xBA */ public bool MustAffordInCreative;
        [NMS(Index = 6)]
        /* 0xBB */ public bool RemoveOptionIfCantAfford;
    }
}
