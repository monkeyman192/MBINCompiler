using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7EE55806F366AEED, NameHash = 0x7841754C)]
    public class GcCreatureHoverMovementDataParams : NMSTemplate
    {
        [NMS(Index = 21)]
        /* 0x000 */ public List<GcCreatureHoverTintableEffect> TintableEffects;
        [NMS(Index = 0)]
        /* 0x010 */ public List<NMSString0x20A> ValidDescriptors;
        [NMS(Index = 19)]
        /* 0x020 */ public float ElevationAvoidStrength;
        [NMS(Index = 12)]
        /* 0x024 */ public float GroundAlignTimeModifier;
        [NMS(Index = 5)]
        /* 0x028 */ public float GroundEffectHeightForMaxAlpha;
        [NMS(Index = 6)]
        /* 0x02C */ public float GroundEffectHeightForMinAlpha;
        [NMS(Index = 3)]
        /* 0x030 */ public float GroundHeightOffset;
        [NMS(Index = 17)]
        /* 0x034 */ public float HeightForMaxElevationAvoid;
        [NMS(Index = 10)]
        /* 0x038 */ public float HeightForMaxGroundAlign;
        [NMS(Index = 14)]
        /* 0x03C */ public float HeightForMaxGroundAvoid;
        [NMS(Index = 18)]
        /* 0x040 */ public float HeightForMinElevationAvoid;
        [NMS(Index = 11)]
        /* 0x044 */ public float HeightForMinGroundAlign;
        [NMS(Index = 15)]
        /* 0x048 */ public float HeightForMinGroundAvoid;
        [NMS(Index = 1)]
        /* 0x04C */ public float NavOffsetY;
        [NMS(Index = 2)]
        /* 0x050 */ public float NavOffsetZ;
        [NMS(Index = 8)]
        /* 0x054 */ public float RayCastDown;
        [NMS(Index = 7)]
        /* 0x058 */ public float RayCastUp;
        [NMS(Index = 4)]
        /* 0x05C */ public NMSString0x100 GroundEffect;
        [NMS(Index = 20)]
        /* 0x15C */ public bool CanJump;
        [NMS(Index = 16)]
        /* 0x15D */ public bool ElevationAvoid;
        [NMS(Index = 9)]
        /* 0x15E */ public bool GroundAlign;
        [NMS(Index = 13)]
        /* 0x15F */ public bool GroundAvoid;
    }
}
