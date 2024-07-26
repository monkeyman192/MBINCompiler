using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x81D95163BF89320E, NameHash = 0x1CF33F48)]
    public class TkAudioComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 AmbientState;
        [NMS(Index = 4)]
        /* 0x10 */ public List<TkAudioAnimTrigger> AnimTriggers;
        [NMS(Index = 5)]
        /* 0x20 */ public List<NMSTemplate> Emitters;
        [NMS(Index = 3)]
        /* 0x30 */ public int MaxDistance;
        [NMS(Index = 0)]
        /* 0x34 */ public NMSString0x80 Ambient;
        [NMS(Index = 2)]
        /* 0xB4 */ public NMSString0x80 Shutdown;
    }
}
