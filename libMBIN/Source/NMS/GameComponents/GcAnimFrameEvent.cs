using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, Alignment = 0x8, GUID = 0x81EFA1D4D693E25A, NameHash = 0x6D7E63CBE4F67CF0)]
    public class GcAnimFrameEvent : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Anim;
        public int FrameStart;
        public bool StartFromEnd;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding15;
    }
}
