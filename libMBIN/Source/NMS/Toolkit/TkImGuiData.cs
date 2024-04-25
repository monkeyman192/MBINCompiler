using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x401F7F6C34A94AA4, NameHash = 0xE8F15AD4B3CB30AC)]
    public class TkImGuiData : NMSTemplate
    {
        [NMS(Index = 5, Size = 0x80)]
        /* 0x0000 */ public TkImGuiWindowData[] WindowTable;
        [NMS(Index = 0)]
        /* 0x5200 */ public TkImGuiWindowData MainWindow;
        [NMS(Index = 2)]
        /* 0x52A4 */ public int DimensionX;
        [NMS(Index = 3)]
        /* 0x52A8 */ public int DimensionY;
        [NMS(Index = 6)]
        /* 0x52AC */ public int WindowCount;
        [NMS(Index = 4, Size = 0xA)]
        /* 0x52B0 */ public NMSString0x80[] RecentToolbox;
        [NMS(Index = 1)]
        /* 0x57B0 */ public bool Maximised;
    }
}
