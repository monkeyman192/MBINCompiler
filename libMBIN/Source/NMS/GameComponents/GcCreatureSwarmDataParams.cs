using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7BCB779856C3ADF6, NameHash = 0x691F170D5F26887A)]
    public class GcCreatureSwarmDataParams : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x20A> ValidDescriptors;
        /* 0x10 */ public float Alignment;
        /* 0x14 */ public float AlignTime;
        /* 0x18 */ public float BankingTime;
        /* 0x1C */ public float Coherence;
        /* 0x20 */ public float FaceMoveDirStrength;
        /* 0x24 */ public float FlyTimeMax;
        /* 0x28 */ public float FlyTimeMin;
        /* 0x2C */ public float Follow;
        /* 0x30 */ public float LandAdjustDist;
        /* 0x34 */ public float LandClampBegin;
        /* 0x38 */ public float LandIdleTimeMax;
        /* 0x3C */ public float LandIdleTimeMin;
        /* 0x40 */ public float LandSlowDown;
        /* 0x44 */ public float LandTimeMax;
        /* 0x48 */ public float LandTimeMin;
        /* 0x4C */ public float LandWalkTimeMax;
        /* 0x50 */ public float LandWalkTimeMin;
        /* 0x54 */ public float MaxBankingAmount;
        /* 0x58 */ public float MaxPitchAmount;
        /* 0x5C */ public float MaxSpeed;
        /* 0x60 */ public float Range;
        /* 0x64 */ public float SeparateStrength;
        /* 0x68 */ public float Spacing;
        /* 0x6C */ public float SpringSmoothTime;
        /* 0x70 */ public float TakeOffStartSpeed;
        /* 0x74 */ public float TakeOffTime;
        /* 0x78 */ public float TakeOffUpwardBoost;
        /* 0x7C */ public float TurnRequiredForMaxBanking;
        /* 0x80 */ public float UpwardMovementForMaxPitch;
        /* 0x84 */ public float WalkSpeed;
        /* 0x88 */ public float WalkTurnTime;
        /* 0x8C */ public bool ApplyScaleToSpeed;
        /* 0x8D */ public bool CanLand;
        /* 0x8E */ public bool CanWalk;
        /* 0x8F */ public bool FaceMoveDirYawOnly;
    }
}
