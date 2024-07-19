namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEF9EFB4964F6DA64, NameHash = 0x6724EB30)]
    public class TkAnimNodeData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int RotIndex;
        [NMS(Index = 3)]
        /* 0x4 */ public int ScaleIndex;
        [NMS(Index = 2)]
        /* 0x8 */ public int TransIndex;
        [NMS(Index = 0)]
        /* 0xC */ public NMSString0x40 Node;
    }
}
