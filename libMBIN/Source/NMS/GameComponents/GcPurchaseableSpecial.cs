namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E2D47DAD1161EA, NameHash = 0x3D9281DDAAB505CF)]
    public class GcPurchaseableSpecial : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 2)]
        /* 0x10 */ public int MissionTier;
        [NMS(Index = 1)]
        /* 0x14 */ public int ShopNumber;
        [NMS(Index = 3)]
        /* 0x18 */ public bool IsConsumable;
    }
}
