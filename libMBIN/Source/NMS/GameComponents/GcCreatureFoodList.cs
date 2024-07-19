namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3DEF036714B601C, NameHash = 0xB5FFDFB5)]
    public class GcCreatureFoodList : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 DebrisEffect;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 FoodProduct;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString ResourceFile;
    }
}
