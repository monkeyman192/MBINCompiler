namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC20E05A80B75CA6, NameHash = 0x8FD3FE17A0260717)]
    public class GcCreatureFoodList : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 DebrisEffect;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 FoodProduct;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x80 ResourceFile;
    }
}
