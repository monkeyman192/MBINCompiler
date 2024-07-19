using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66CD3C3B6213FEEB, NameHash = 0xF1BF6DCC)]
    public class GcCreatureEffectTrigger : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Effect;
        [NMS(Index = 1)]
        /* 0x20 */ public List<NMSString0x100> JointName;
        [NMS(Index = 4)]
        /* 0x30 */ public int Frame;
        [NMS(Index = 2)]
        /* 0x34 */ public float Scale;
        [NMS(Index = 5)]
        /* 0x38 */ public bool GroundTint;
    }
}
