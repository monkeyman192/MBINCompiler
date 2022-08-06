using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x443F2EE00325B5E2, NameHash = 0x5289598B4907DC8E)]
    public class GcNPCComponentData : NMSTemplate
    {
        /* 0x00 */ public GcAlienRace AlienRace;
        /* 0x08 */ public NMSString0x10 HologramEffect;
        /* 0x18 */ public bool IsOldStyleNPC;
        /* 0x19 */ public bool IsMech;
        /* 0x20 */ public List<GcCharacterAlternateAnimation> AlternateAnims;
        /* 0x30 */ public List<NMSString0x10> Tags;
    }
}
