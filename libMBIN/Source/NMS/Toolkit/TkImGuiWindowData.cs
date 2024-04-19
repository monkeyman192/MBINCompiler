namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x14273A3293A528F0, NameHash = 0x431A784D584CBE50)]
    public class TkImGuiWindowData : NMSTemplate
    {
        /* 0x00 */ public int WindowH;
        /* 0x04 */ public int WindowMinH;
        /* 0x08 */ public int WindowMinW;
        /* 0x0C */ public int WindowScroll;
        /* 0x10 */ public int WindowTab;
        /* 0x14 */ public int WindowW;
        /* 0x18 */ public int WindowX;
        /* 0x1C */ public int WindowY;
        /* 0x20 */ public NMSString0x80 Type;
        /* 0xA0 */ public bool WindowMinimised;
        /* 0xA1 */ public bool WindowOpen;
        /* 0xA2 */ public bool WindowResize;
        /* 0xA3 */ public bool WindowUsed;
    }
}
