namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7876A6C27FE78F0, NameHash = 0x6A504B01F7CE5428)]
    public class GcMissionConditionCookingSearch : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Product;
        [NMS(Index = 1)]
        /* 0x10 */ public int Amount;
        [NMS(Index = 3)]
        /* 0x14 */ public bool ReturnTrueIfCanMakeProduct;
        [NMS(Index = 2)]
        /* 0x15 */ public bool SetIcon;
    }
}
