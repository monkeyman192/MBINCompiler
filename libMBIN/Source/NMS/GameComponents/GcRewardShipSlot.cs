namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0BB8D17766199A6, NameHash = 0x278294BC)]
    public class GcRewardShipSlot : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Cost;
        [NMS(Index = 2)]
        /* 0x10 */ public int NumTokens;
        [NMS(Index = 1)]
        /* 0x14 */ public bool AwardCostAndOpenWindow;
        [NMS(Index = 4)]
        /* 0x15 */ public bool FallbackOpenWindowIfBlocked;
        [NMS(Index = 3)]
        /* 0x16 */ public bool IsAlien;
    }
}
