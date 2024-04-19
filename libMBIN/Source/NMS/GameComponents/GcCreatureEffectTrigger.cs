using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF2C93E6788CE0821, NameHash = 0x4E07F5FB46E3BD82)]
    public class GcCreatureEffectTrigger : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Anim;
        /* 0x10 */ public NMSString0x10 Effect;
        /* 0x20 */ public List<NMSString0x100> JointName;
        /* 0x30 */ public int Frame;
        /* 0x34 */ public float Scale;
        /* 0x38 */ public bool GroundTint;
    }
}
