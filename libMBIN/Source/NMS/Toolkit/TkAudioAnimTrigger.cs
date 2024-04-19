using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6C2C6ADADB8FF6BB, NameHash = 0x537216694166E761)]
    public class TkAudioAnimTrigger : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Anim;
        /* 0x10 */ public List<NMSString0x20A> OnlyValidWithParts;
        /* 0x20 */ public int FrameStart;
        /* 0x24 */ public NMSString0x80 Sound;
    }
}
