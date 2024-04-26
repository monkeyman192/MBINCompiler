namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x60A28562E21B7ED3, NameHash = 0x57A3CABFA5A7BDA8)]
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
