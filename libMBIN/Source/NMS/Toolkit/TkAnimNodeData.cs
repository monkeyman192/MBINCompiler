using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkAnimNodeData : NMSTemplate
    {
        public NMSString0x10 Node;

        public bool CanCompress; // set to 0xFE, with following 3 padding bytes also set to 0xFE, might be padding indicating that this is 0? currently treated as 1...
        public int RotIndex;
        public int TransIndex;
        public int ScaleIndex;
    }
}
