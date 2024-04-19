namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4290FF761007EBBA, NameHash = 0x5EB3ADA9F4E70000)]
    public class GcRewardShipSlot : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Cost;
        /* 0x10 */ public int NumTokens;
        /* 0x14 */ public bool AwardCostAndOpenWindow;
        /* 0x15 */ public bool FallbackOpenWindowIfBlocked;
        /* 0x16 */ public bool IsAlien;
    }
}
