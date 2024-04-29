using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57BE9EA5EF1EB23, NameHash = 0x1C1691C0F8971C4A)]
    public class GcAdvancedTweaks : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public List<NMSString0x40> NodesThatMustBePresent;
        [NMS(Index = 6)]
        /* 0x10 */ public List<NMSString0x40> NodesToHide;
        [NMS(Index = 2)]
        /* 0x20 */ public float EdgeMultiplierForTangentI;
        [NMS(Index = 3)]
        /* 0x24 */ public float EdgeMultiplierForTangentJ;
        [NMS(Index = 0)]
        /* 0x28 */ public float ParticleKillSpeed;
        [NMS(Index = 1)]
        /* 0x2C */ public float ParticleKillSpeedWrtFixed;
        [NMS(Index = 4)]
        /* 0x30 */ public float RenderNormalMultiplier;
        [NMS(Index = 7)]
        /* 0x34 */ public float StretchUvsToHideTextureEdges;
        [NMS(Index = 8)]
        /* 0x38 */ public bool LeaveRenderedTrianglesUnaffected;
    }
}
