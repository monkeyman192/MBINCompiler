using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkImGuiData : NMSTemplate
    {
        public TkImGuiWindowData MainWindow;
        public bool Maximised;
        public int DimensionX;
        public int DimensionY;
        [NMS(Size = 0xA)]
        public NMSString0x80[] RecentToolbox;
        [NMS(Size = 0x80)]
        public TkImGuiWindowData[] WindowTable;
        public int WindowCount;
    }
}
