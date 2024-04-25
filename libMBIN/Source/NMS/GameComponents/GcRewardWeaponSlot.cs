namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA3D1765B5B3C789A, NameHash = 0xC64F181FDA941A39)]
    public class GcRewardWeaponSlot : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Cost;
        [NMS(Index = 2)]
        /* 0x10 */ public int NumTokens;
        [NMS(Index = 1)]
        /* 0x14 */ public bool AwardCostAndOpenWindow;
    }
}
