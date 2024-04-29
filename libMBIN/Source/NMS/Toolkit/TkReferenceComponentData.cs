namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAFB5D2D59D2FE69E, NameHash = 0xECF89DFCB0AF1DBF)]
    public class TkReferenceComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x80 LSystem;
        [NMS(Index = 0)]
        /* 0x80 */ public NMSString0x80 Reference;
    }
}
