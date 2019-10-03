using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xB2224162A8931EAF, NameHash = 0x537216694166E761)]
    public class TkAudioAnimTrigger : NMSTemplate // 0x98 bytes
    {
        [NMS(Size = 0x80)]
        public string Sound;
        [NMS(Size = 0x10)]
        public string Anim;

        public int FrameStart;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding94;
    }
}
