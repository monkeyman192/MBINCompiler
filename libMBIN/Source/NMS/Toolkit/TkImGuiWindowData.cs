using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x159F70DC858BFEB9, NameHash = 0x431A784D584CBE50)]
    public class TkImGuiWindowData : NMSTemplate
    {
        public NMSString0x80 Type;

        public int WindowX;
        public int WindowY;
        public int WindowW;
        public int WindowH;
        public int WindowMinW;
        public int WindowMinH;
        public bool WindowResize;
        public int WindowScroll;
        public int WindowTab;
        public bool WindowOpen;
        public bool WindowMinimised;
        public bool WindowUsed;
    }
}