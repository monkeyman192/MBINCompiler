namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x201D028F2C6CBDB7, NameHash = 0x6E19250A34E2CE86)]
    public class TkAnimNodeData : NMSTemplate
    {
        /* 0x00 */ public int RotIndex;
        /* 0x04 */ public int ScaleIndex;
        /* 0x08 */ public int TransIndex;
        /* 0x0C */ public NMSString0x40 Node;
        /* 0x4C */ public bool CanCompress;
    }
}
