namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8F872E8A3E7FBE8D, NameHash = 0xA655E8FCC4246967)]
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
