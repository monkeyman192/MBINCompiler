using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x62546FD561FE4161, NameHash = 0x5289598B4907DC8E)]
    public class GcNPCComponentData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<GcCharacterAlternateAnimation> AlternateAnims;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 HologramEffect;
        [NMS(Index = 5)]
        /* 0x20 */ public List<NMSString0x10> Tags;
        [NMS(Index = 0)]
        /* 0x30 */ public GcAlienRace Race;
        [NMS(Index = 3)]
        /* 0x34 */ public bool IsMech;
        [NMS(Index = 2)]
        /* 0x35 */ public bool IsOldStyleNPC;
    }
}
