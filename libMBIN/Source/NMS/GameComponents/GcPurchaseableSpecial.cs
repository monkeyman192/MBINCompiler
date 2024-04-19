namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E2D47DAD1161EA, NameHash = 0x3D9281DDAAB505CF)]
    public class GcPurchaseableSpecial : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public int MissionTier;
        /* 0x14 */ public int ShopNumber;
        /* 0x18 */ public bool IsConsumable;
    }
}
