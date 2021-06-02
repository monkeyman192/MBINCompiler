using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x98, GUID = 0xB2224162A8931EAF, NameHash = 0x537216694166E761)]
    public class TkAudioAnimTrigger : NMSTemplate
    {
        public NMSString0x80 Sound;
        public NMSString0x10 Anim;

        public int FrameStart;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding94;
    }
}