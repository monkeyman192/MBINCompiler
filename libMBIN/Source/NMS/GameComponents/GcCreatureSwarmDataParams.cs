using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0x4E0F39978D25E57E, NameHash = 0x691F170D5F26887A)]
    public class GcCreatureSwarmDataParams : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x20A> ValidDescriptors;
        /* 0x10 */ public float Coherence;
        /* 0x14 */ public float Alignment;
        /* 0x18 */ public float SeparateStrength;
        /* 0x1C */ public float Spacing;
        /* 0x20 */ public float Follow;
        /* 0x24 */ public float Range;
        /* 0x28 */ public float MaxBankingAmount;
        /* 0x2C */ public float TurnRequiredForMaxBanking;
        /* 0x30 */ public float MaxPitchAmount;
        /* 0x34 */ public float UpwardMovementForMaxPitch;
        /* 0x38 */ public float FaceMoveDirStrength;
        /* 0x3C */ public float TiltMoveDirStrength;
        /* 0x40 */ public bool CanLand;
        /* 0x44 */ public float LandAdjustDist;
        /* 0x48 */ public float LandClampBegin;
        /* 0x4C */ public float LandSlowDown;
        /* 0x50 */ public float TakeOffTime;
        /* 0x54 */ public float TakeOffStartSpeed;
        /* 0x58 */ public float TakeOffUpwardBoost;
        /* 0x5C */ public bool CanWalk;
        /* 0x60 */ public float WalkSpeed;
        /* 0x64 */ public float WalkTurnTime;
        /* 0x68 */ public float FlyTimeMin;
        /* 0x6C */ public float FlyTimeMax;
        /* 0x70 */ public float LandTimeMin;
        /* 0x74 */ public float LandTimeMax;
        /* 0x78 */ public float LandIdleTimeMin;
        /* 0x7C */ public float LandIdleTimeMax;
        /* 0x80 */ public float LandWalkTimeMin;
        /* 0x84 */ public float LandWalkTimeMax;
        /* 0x88 */ public float MaxSpeed;
        /* 0x8C */ public float AlignTime;
        /* 0x90 */ public float BankingTime;
        /* 0x94 */ public float SpringSmoothTime;
        /* 0x98 */ public bool ApplyScaleToSpeed;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x99 */ public byte[] EndPadding;
    }
}
