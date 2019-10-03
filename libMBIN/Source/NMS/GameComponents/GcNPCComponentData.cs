using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x8978C4E36935D3B7, NameHash = 0x5289598B4907DC8E)]
    public class GcNPCComponentData : NMSTemplate
    {
        /* 0x00 */ public GcAlienRace AlienRace;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string HologramEffect;
        /* 0x18 */ public bool IsOldStyleNPC;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x19 */ public byte[] Padding19;
        /* 0x20 */ public List<GcCharacterAlternateAnimation> AlternateAnims;
        /* 0x30 */ public List<NMSString0x10> Tags;
    }
}
