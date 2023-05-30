using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkAnimPoseData : NMSTemplate // 0x18 bytes
    {
        public NMSString0x10 Anim;
        public int FrameStart;
        public int FrameEnd;
    }
}
