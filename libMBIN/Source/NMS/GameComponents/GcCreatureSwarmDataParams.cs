using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0xBA28CE84EE0E0A96, NameHash = 0x691F170D5F26887A)]
    public class GcCreatureSwarmDataParams : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x20> ValidDescriptors;
        /* 0x10 */ public float Coherence;
        /* 0x14 */ public float Alignment;
        /* 0x18 */ public float SeparateStrength;
        /* 0x1C */ public float Spacing;
        /* 0x20 */ public float Follow;
        /* 0x24 */ public float Range;
        /* 0x28 */ public float MaxbankingAmount;
        /* 0x2C */ public float TurnRequiredForMaxBanking;
        /* 0x30 */ public float MaxPitchAmount;
        /* 0x34 */ public float UpwardMovementForMaxPitch;
        /* 0x38 */ public float FaceMoveDirStrength;
        /* 0x3C */ public float TiltMoveDirStrength;
        /* 0x40 */ public bool CanLand;
        /* 0x44 */ public float MaxSpeed;
        /* 0x48 */ public float AlignTime;
        /* 0x4C */ public float SpringSmoothTime;
    }
}
