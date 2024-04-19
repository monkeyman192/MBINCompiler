using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF68740FE9FF1B370, NameHash = 0x43843485E8F56932)]
    public class TkAudioComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 AmbientState;
        /* 0x10 */ public List<TkAudioAnimTrigger> AnimTriggers;
        /* 0x20 */ public int MaxDistance;
        /* 0x24 */ public NMSString0x80 Ambient;
        /* 0xA4 */ public NMSString0x80 Shutdown;
    }
}
