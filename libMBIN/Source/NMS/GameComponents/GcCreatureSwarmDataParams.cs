using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD80E0E4AE0B17E92, NameHash = 0x691F170D5F26887A)]
    public class GcCreatureSwarmDataParams : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x20A> ValidDescriptors;
        [NMS(Index = 2)]
        /* 0x10 */ public float Alignment;
        [NMS(Index = 32)]
        /* 0x14 */ public float AlignTime;
        [NMS(Index = 33)]
        /* 0x18 */ public float BankingTime;
        [NMS(Index = 1)]
        /* 0x1C */ public float Coherence;
        [NMS(Index = 11)]
        /* 0x20 */ public float FaceMoveDirStrength;
        [NMS(Index = 24)]
        /* 0x24 */ public float FlyTimeMax;
        [NMS(Index = 23)]
        /* 0x28 */ public float FlyTimeMin;
        [NMS(Index = 5)]
        /* 0x2C */ public float Follow;
        [NMS(Index = 14)]
        /* 0x30 */ public float LandAdjustDist;
        [NMS(Index = 15)]
        /* 0x34 */ public float LandClampBegin;
        [NMS(Index = 28)]
        /* 0x38 */ public float LandIdleTimeMax;
        [NMS(Index = 27)]
        /* 0x3C */ public float LandIdleTimeMin;
        [NMS(Index = 16)]
        /* 0x40 */ public float LandSlowDown;
        [NMS(Index = 26)]
        /* 0x44 */ public float LandTimeMax;
        [NMS(Index = 25)]
        /* 0x48 */ public float LandTimeMin;
        [NMS(Index = 30)]
        /* 0x4C */ public float LandWalkTimeMax;
        [NMS(Index = 29)]
        /* 0x50 */ public float LandWalkTimeMin;
        [NMS(Index = 7)]
        /* 0x54 */ public float MaxBankingAmount;
        [NMS(Index = 9)]
        /* 0x58 */ public float MaxPitchAmount;
        [NMS(Index = 31)]
        /* 0x5C */ public float MaxSpeed;
        [NMS(Index = 6)]
        /* 0x60 */ public float Range;
        [NMS(Index = 3)]
        /* 0x64 */ public float SeparateStrength;
        [NMS(Index = 4)]
        /* 0x68 */ public float Spacing;
        [NMS(Index = 34)]
        /* 0x6C */ public float SpringSmoothTime;
        [NMS(Index = 18)]
        /* 0x70 */ public float TakeOffStartSpeed;
        [NMS(Index = 17)]
        /* 0x74 */ public float TakeOffTime;
        [NMS(Index = 19)]
        /* 0x78 */ public float TakeOffUpwardBoost;
        [NMS(Index = 8)]
        /* 0x7C */ public float TurnRequiredForMaxBanking;
        [NMS(Index = 10)]
        /* 0x80 */ public float UpwardMovementForMaxPitch;
        [NMS(Index = 21)]
        /* 0x84 */ public float WalkSpeed;
        [NMS(Index = 22)]
        /* 0x88 */ public float WalkTurnTime;
        [NMS(Index = 35)]
        /* 0x8C */ public bool ApplyScaleToSpeed;
        [NMS(Index = 13)]
        /* 0x8D */ public bool CanLand;
        [NMS(Index = 20)]
        /* 0x8E */ public bool CanWalk;
        [NMS(Index = 12)]
        /* 0x8F */ public bool FaceMoveDirYawOnly;
    }
}
