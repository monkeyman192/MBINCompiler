using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkAudioAnimTrigger : NMSTemplate // 0x98 bytes
    {
        public NMSString0x80 Sound;
        public NMSString0x10 Anim;

        public int FrameStart;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding94;
    }
}
