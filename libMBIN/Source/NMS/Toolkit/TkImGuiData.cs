using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2BE5DEEE27884DE0, NameHash = 0xBB8EDF68)]
    public class TkImGuiData : NMSTemplate
    {
        [NMS(Index = 4, Size = 0xA)]
        /* 0x0000 */ public VariableSizeString[] RecentToolbox;
        [NMS(Index = 5, Size = 0x80)]
        /* 0x00A0 */ public TkImGuiWindowData[] WindowTable;
        [NMS(Index = 0)]
        /* 0x52A0 */ public TkImGuiWindowData MainWindow;
        [NMS(Index = 2)]
        /* 0x5344 */ public int DimensionX;
        [NMS(Index = 3)]
        /* 0x5348 */ public int DimensionY;
        [NMS(Index = 6)]
        /* 0x534C */ public int WindowCount;
        [NMS(Index = 1)]
        /* 0x5350 */ public bool Maximised;
    }
}
