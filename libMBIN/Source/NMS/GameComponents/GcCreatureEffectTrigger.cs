using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x136FE5E14CD7D098, NameHash = 0x4E07F5FB46E3BD82)]
    public class GcCreatureEffectTrigger : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Effect;
        /* 0x10 */ public List<NMSString0x100> JointName;
        /* 0x20 */ public float Scale;
        /* 0x28 */ public NMSString0x10 Anim;
        /* 0x38 */ public int Frame;
        /* 0x3C */ public bool GroundTint;
    }
}
