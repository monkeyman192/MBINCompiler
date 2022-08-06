using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x9A55EA80BBEF4621, NameHash = 0x789352C972E7FBAA)]
    public class TkAnimPoseData : NMSTemplate
    {
        public NMSString0x10 Anim;
        public int FrameStart;
        public int FrameEnd;
    }
}