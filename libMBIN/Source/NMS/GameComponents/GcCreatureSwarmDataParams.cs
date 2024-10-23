using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4DB0AAF2F60F74CC, NameHash = 0x53731F3E)]
    public class GcCreatureSwarmDataParams : NMSTemplate
    {
        [NMS(Index = 41)]
        /* 0x00 */ public NMSString0x10 AnimThrustCycleAnim;
        [NMS(Index = 0)]
        /* 0x10 */ public List<NMSString0x20A> ValidDescriptors;
        [NMS(Index = 6)]
        /* 0x20 */ public float Alignment;
        [NMS(Index = 11)]
        /* 0x24 */ public float AlignTime;
        [NMS(Index = 44)]
        /* 0x28 */ public float AnimThrustCycleEnd;
        [NMS(Index = 45)]
        /* 0x2C */ public float AnimThrustCycleMax;
        [NMS(Index = 46)]
        /* 0x30 */ public float AnimThrustCycleMin;
        [NMS(Index = 43)]
        /* 0x34 */ public float AnimThrustCyclePeak;
        [NMS(Index = 42)]
        /* 0x38 */ public float AnimThrustCycleStart;
        [NMS(Index = 12)]
        /* 0x3C */ public float BankingTime;
        [NMS(Index = 5)]
        /* 0x40 */ public float Coherence;
        [NMS(Index = 20)]
        /* 0x44 */ public float FaceMoveDirStrength;
        [NMS(Index = 30)]
        /* 0x48 */ public float FlyTimeMax;
        [NMS(Index = 29)]
        /* 0x4C */ public float FlyTimeMin;
        [NMS(Index = 9)]
        /* 0x50 */ public float Follow;
        [NMS(Index = 23)]
        /* 0x54 */ public float LandAdjustDist;
        [NMS(Index = 24)]
        /* 0x58 */ public float LandClampBegin;
        [NMS(Index = 34)]
        /* 0x5C */ public float LandIdleTimeMax;
        [NMS(Index = 33)]
        /* 0x60 */ public float LandIdleTimeMin;
        [NMS(Index = 25)]
        /* 0x64 */ public float LandSlowDown;
        [NMS(Index = 32)]
        /* 0x68 */ public float LandTimeMax;
        [NMS(Index = 31)]
        /* 0x6C */ public float LandTimeMin;
        [NMS(Index = 36)]
        /* 0x70 */ public float LandWalkTimeMax;
        [NMS(Index = 35)]
        /* 0x74 */ public float LandWalkTimeMin;
        [NMS(Index = 13)]
        /* 0x78 */ public float MaxBankingAmount;
        [NMS(Index = 16)]
        /* 0x7C */ public float MaxPitchAmount;
        [NMS(Index = 1)]
        /* 0x80 */ public float MaxSpeed;
        [NMS(Index = 15)]
        /* 0x84 */ public float MinPitchAmount;
        [NMS(Index = 10)]
        /* 0x88 */ public float Range;
        [NMS(Index = 7)]
        /* 0x8C */ public float SeparateStrength;
        [NMS(Index = 8)]
        /* 0x90 */ public float Spacing;
        [NMS(Index = 18)]
        /* 0x94 */ public float SpeedForMaxPitch;
        [NMS(Index = 17)]
        /* 0x98 */ public float SpeedForMinPitch;
        [NMS(Index = 3)]
        /* 0x9C */ public float SteeringSpringSmoothTime;
        [NMS(Index = 27)]
        /* 0xA0 */ public float TakeOffStartSpeed;
        [NMS(Index = 26)]
        /* 0xA4 */ public float TakeOffTime;
        [NMS(Index = 28)]
        /* 0xA8 */ public float TakeOffUpwardBoost;
        [NMS(Index = 14)]
        /* 0xAC */ public float TurnRequiredForMaxBanking;
        [NMS(Index = 19)]
        /* 0xB0 */ public float UpwardMovementForMaxPitch;
        [NMS(Index = 38)]
        /* 0xB4 */ public float WalkSpeed;
        [NMS(Index = 39)]
        /* 0xB8 */ public float WalkTurnTime;
        [NMS(Index = 2)]
        /* 0xBC */ public bool ApplyScaleToSpeed;
        [NMS(Index = 4)]
        /* 0xBD */ public bool ApplyScaleToSteeringSmoothTime;
        [NMS(Index = 22)]
        /* 0xBE */ public bool CanLand;
        [NMS(Index = 37)]
        /* 0xBF */ public bool CanWalk;
        [NMS(Index = 21)]
        /* 0xC0 */ public bool FaceMoveDirYawOnly;
        [NMS(Index = 40)]
        /* 0xC1 */ public bool UseAnimThrustCycle;
    }
}
