using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x160, GUID = 0xCDCC9259306D4B7B, NameHash = 0x2862D9C79079A037)]
    public class GcCreatureHoverMovementDataParams : NMSTemplate
    {
        /* 0x000 */ public List<NMSString0x20A> ValidDescriptors;
        /* 0x010 */ public float NavOffsetY;
        /* 0x014 */ public float NavOffsetZ;
        /* 0x018 */ public float GroundHeightOffset;
        /* 0x01C */ public NMSString0x100 GroundEffect;
        /* 0x11C */ public float GroundEffectHeightForMaxAlpha;
        /* 0x120 */ public float GroundEffectHeightForMinAlpha;
        /* 0x124 */ public float RayCastUp;
        /* 0x128 */ public float RayCastDown;
        /* 0x12C */ public bool GroundAlign;
        /* 0x130 */ public float HeightForMaxGroundAlign;
        /* 0x134 */ public float HeightForMinGroundAlign;
        /* 0x138 */ public float GroundAlignTimeModifier;
        /* 0x13C */ public bool GroundAvoid;
        /* 0x140 */ public float HeightForMaxGroundAvoid;
        /* 0x144 */ public float HeightForMinGroundAvoid;
        /* 0x148 */ public float GroundAvoidTimeModifier;
        /* 0x14C */ public bool CanJump;
        /* 0x150 */ public List<GcCreatureHoverTintableEffect> TintableEffects;
    }
}