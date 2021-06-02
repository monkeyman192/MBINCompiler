using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x128, Alignment = 0x8, GUID = 0x52F00107D89FE21C, NameHash = 0x43843485E8F56932)]
    public class TkAudioComponentData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Ambient;
        /* 0x080 */ public NMSString0x10 AmbientState;
        /* 0x090 */ public NMSString0x80 Shutdown;
        /* 0x110 */ public int MaxDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x114 */ public byte[] Padding114;
        /* 0x118 */ public List<TkAudioAnimTrigger> AnimTriggers;
    }
}
