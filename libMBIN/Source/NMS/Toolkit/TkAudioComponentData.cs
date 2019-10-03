using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xA8, GUID = 0x1345863FBC0832FF, NameHash = 0x43843485E8F56932)]
    public class TkAudioComponentData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Ambient;
        [NMS(Size = 0x10)]
        /* 0x80 */ public string AmbientState;
        /* 0x90 */ public int MaxDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x94 */ public byte[] Padding94;
        /* 0x98 */ public List<TkAudioAnimTrigger> AnimTriggers;
    }
}
