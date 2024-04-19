using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E185E70D1EAA16D, NameHash = 0x2862D9C79079A037)]
    public class GcCreatureHoverMovementDataParams : NMSTemplate
    {
        /* 0x000 */ public List<GcCreatureHoverTintableEffect> TintableEffects;
        /* 0x010 */ public List<NMSString0x20A> ValidDescriptors;
        /* 0x020 */ public float GroundAlignTimeModifier;
        /* 0x024 */ public float GroundAvoidTimeModifier;
        /* 0x028 */ public float GroundEffectHeightForMaxAlpha;
        /* 0x02C */ public float GroundEffectHeightForMinAlpha;
        /* 0x030 */ public float GroundHeightOffset;
        /* 0x034 */ public float HeightForMaxGroundAlign;
        /* 0x038 */ public float HeightForMaxGroundAvoid;
        /* 0x03C */ public float HeightForMinGroundAlign;
        /* 0x040 */ public float HeightForMinGroundAvoid;
        /* 0x044 */ public float NavOffsetY;
        /* 0x048 */ public float NavOffsetZ;
        /* 0x04C */ public float RayCastDown;
        /* 0x050 */ public float RayCastUp;
        /* 0x054 */ public NMSString0x100 GroundEffect;
        /* 0x154 */ public bool CanJump;
        /* 0x155 */ public bool GroundAlign;
        /* 0x156 */ public bool GroundAvoid;
    }
}
