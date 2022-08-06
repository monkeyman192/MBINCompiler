using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x52F00107D89FE21C, NameHash = 0x43843485E8F56932)]
    public class TkAudioComponentData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Ambient;
        /* 0x080 */ public NMSString0x10 AmbientState;
        /* 0x090 */ public NMSString0x80 Shutdown;
        /* 0x110 */ public int MaxDistance;
        /* 0x118 */ public List<TkAudioAnimTrigger> AnimTriggers;
    }
}
