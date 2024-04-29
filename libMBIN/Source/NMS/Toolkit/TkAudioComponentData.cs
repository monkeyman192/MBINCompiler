using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1AE65FCEE97904F1, NameHash = 0x43843485E8F56932)]
    public class TkAudioComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 AmbientState;
        [NMS(Index = 4)]
        /* 0x10 */ public List<TkAudioAnimTrigger> AnimTriggers;
        [NMS(Index = 3)]
        /* 0x20 */ public int MaxDistance;
        [NMS(Index = 0)]
        /* 0x24 */ public NMSString0x80 Ambient;
        [NMS(Index = 2)]
        /* 0xA4 */ public NMSString0x80 Shutdown;
    }
}
