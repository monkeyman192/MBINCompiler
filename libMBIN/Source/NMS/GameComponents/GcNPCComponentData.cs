using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99E1E36F4DD15F18, NameHash = 0x5289598B4907DC8E)]
    public class GcNPCComponentData : NMSTemplate
    {
        /* 0x00 */ public List<GcCharacterAlternateAnimation> AlternateAnims;
        /* 0x10 */ public NMSString0x10 HologramEffect;
        /* 0x20 */ public List<NMSString0x10> Tags;
        /* 0x30 */ public GcAlienRace Race;
        /* 0x34 */ public bool IsMech;
        /* 0x35 */ public bool IsOldStyleNPC;
    }
}
