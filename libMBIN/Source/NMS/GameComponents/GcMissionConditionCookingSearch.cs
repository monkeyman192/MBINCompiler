namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7876A6C27FE78F0, NameHash = 0x6A504B01F7CE5428)]
    public class GcMissionConditionCookingSearch : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Product;
        /* 0x10 */ public int Amount;
        /* 0x14 */ public bool ReturnTrueIfCanMakeProduct;
        /* 0x15 */ public bool SetIcon;
    }
}
