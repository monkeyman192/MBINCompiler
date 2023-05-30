using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAnimFrameEvent : NMSTemplate
    {
        public NMSString0x10 Anim;
        public int FrameStart;
        public bool StartFromEnd;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding15;
    }
}
