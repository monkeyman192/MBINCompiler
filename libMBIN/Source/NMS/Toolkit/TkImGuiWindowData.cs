namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x14273A3293A528F0, NameHash = 0x431A784D584CBE50)]
    public class TkImGuiWindowData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public int WindowH;
        [NMS(Index = 6)]
        /* 0x04 */ public int WindowMinH;
        [NMS(Index = 5)]
        /* 0x08 */ public int WindowMinW;
        [NMS(Index = 8)]
        /* 0x0C */ public int WindowScroll;
        [NMS(Index = 9)]
        /* 0x10 */ public int WindowTab;
        [NMS(Index = 3)]
        /* 0x14 */ public int WindowW;
        [NMS(Index = 1)]
        /* 0x18 */ public int WindowX;
        [NMS(Index = 2)]
        /* 0x1C */ public int WindowY;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x80 Type;
        [NMS(Index = 11)]
        /* 0xA0 */ public bool WindowMinimised;
        [NMS(Index = 10)]
        /* 0xA1 */ public bool WindowOpen;
        [NMS(Index = 7)]
        /* 0xA2 */ public bool WindowResize;
        [NMS(Index = 12)]
        /* 0xA3 */ public bool WindowUsed;
    }
}
