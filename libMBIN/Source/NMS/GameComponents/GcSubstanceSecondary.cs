namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFF64683379065AA, NameHash = 0x8875D487)]
    public class GcSubstanceSecondary : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 3)]
        /* 0x10 */ public float AmountMax;
        [NMS(Index = 2)]
        /* 0x14 */ public float AmountMin;
        [NMS(Index = 1)]
        /* 0x18 */ public float Chance;
    }
}
