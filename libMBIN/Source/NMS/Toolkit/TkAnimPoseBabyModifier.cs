namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE1CD27AD52F1E7E9, NameHash = 0xB95D6DB5)]
    public class TkAnimPoseBabyModifier : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Item;
        [NMS(Index = 1)]
        /* 0x10 */ public float Value;
        [NMS(Index = 2)]
        /* 0x14 */ public float Weight;
    }
}
