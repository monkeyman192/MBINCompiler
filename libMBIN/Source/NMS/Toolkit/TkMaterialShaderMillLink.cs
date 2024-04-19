namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB4E29DBAD60FA279, NameHash = 0xFC506DC8F06CBE6D)]
    public class TkMaterialShaderMillLink : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 InputShuffle;
        /* 0x10 */ public NMSString0x10 OutputShuffle;
        /* 0x20 */ public int Count;
        /* 0x24 */ public int InputNode;
        /* 0x28 */ public int OutputNode;
        /* 0x2C */ public NMSString0x20 InputConnect;
        /* 0x4C */ public NMSString0x20 OutputConnect;
    }
}
