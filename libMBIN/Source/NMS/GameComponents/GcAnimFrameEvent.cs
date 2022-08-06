using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81EFA1D4D693E25A, NameHash = 0x6D7E63CBE4F67CF0)]
    public class GcAnimFrameEvent : NMSTemplate
    {
        public NMSString0x10 Anim;
        public int FrameStart;
        public bool StartFromEnd;
    }
}
