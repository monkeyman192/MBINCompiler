namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C6C416D934CB2D, NameHash = 0x8E9AB1DD)]
    public class GcCostTableEntry : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x00 */ public NMSString0x20A CannotAffordOSDMsg;
        [NMS(Index = 10)]
        /* 0x20 */ public NMSString0x20A CommunityContributionCapLocID;
        [NMS(Index = 13)]
        /* 0x40 */ public NMSTemplate Cost;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x10 Id;
        [NMS(Index = 12)]
        /* 0x60 */ public NMSString0x10 MissionMessageWhenCharged;
        [NMS(Index = 9)]
        /* 0x70 */ public int CommunityContributionValue;
        [NMS(Index = 1)]
        /* 0x74 */ public bool DisplayCost;
        [NMS(Index = 4)]
        /* 0x75 */ public bool DisplayOnlyCostIfCantAfford;
        [NMS(Index = 2)]
        /* 0x76 */ public bool DontCharge;
        [NMS(Index = 5)]
        /* 0x77 */ public bool HideCostStringIfCanAfford;
        [NMS(Index = 3)]
        /* 0x78 */ public bool HideOptionAndDisplayCostOnly;
        [NMS(Index = 7)]
        /* 0x79 */ public bool InvertCanAffordOutcome;
        [NMS(Index = 8)]
        /* 0x7A */ public bool MustAffordInCreative;
        [NMS(Index = 6)]
        /* 0x7B */ public bool RemoveOptionIfCantAfford;
    }
}
