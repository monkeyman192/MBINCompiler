using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E185E70D1EAA16D, NameHash = 0x2862D9C79079A037)]
    public class GcCreatureHoverMovementDataParams : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x000 */ public List<GcCreatureHoverTintableEffect> TintableEffects;
        [NMS(Index = 0)]
        /* 0x010 */ public List<NMSString0x20A> ValidDescriptors;
        [NMS(Index = 12)]
        /* 0x020 */ public float GroundAlignTimeModifier;
        [NMS(Index = 16)]
        /* 0x024 */ public float GroundAvoidTimeModifier;
        [NMS(Index = 5)]
        /* 0x028 */ public float GroundEffectHeightForMaxAlpha;
        [NMS(Index = 6)]
        /* 0x02C */ public float GroundEffectHeightForMinAlpha;
        [NMS(Index = 3)]
        /* 0x030 */ public float GroundHeightOffset;
        [NMS(Index = 10)]
        /* 0x034 */ public float HeightForMaxGroundAlign;
        [NMS(Index = 14)]
        /* 0x038 */ public float HeightForMaxGroundAvoid;
        [NMS(Index = 11)]
        /* 0x03C */ public float HeightForMinGroundAlign;
        [NMS(Index = 15)]
        /* 0x040 */ public float HeightForMinGroundAvoid;
        [NMS(Index = 1)]
        /* 0x044 */ public float NavOffsetY;
        [NMS(Index = 2)]
        /* 0x048 */ public float NavOffsetZ;
        [NMS(Index = 8)]
        /* 0x04C */ public float RayCastDown;
        [NMS(Index = 7)]
        /* 0x050 */ public float RayCastUp;
        [NMS(Index = 4)]
        /* 0x054 */ public NMSString0x100 GroundEffect;
        [NMS(Index = 17)]
        /* 0x154 */ public bool CanJump;
        [NMS(Index = 9)]
        /* 0x155 */ public bool GroundAlign;
        [NMS(Index = 13)]
        /* 0x156 */ public bool GroundAvoid;
    }
}
