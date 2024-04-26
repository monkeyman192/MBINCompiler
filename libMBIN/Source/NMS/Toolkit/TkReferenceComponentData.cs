namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1497A90491689A51, NameHash = 0xECF89DFCB0AF1DBF)]
    public class TkReferenceComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x80 LSystem;
        [NMS(Index = 0)]
        /* 0x80 */ public NMSString0x80 Reference;
    }
}
