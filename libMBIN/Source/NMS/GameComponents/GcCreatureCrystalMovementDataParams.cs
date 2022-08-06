using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x301CA5BAF5117C87, NameHash = 0x1232AC16AD2DF95C)]
    public class GcCreatureCrystalMovementDataParams : NMSTemplate
    {
        /* 0x000 */ public List<GcBiomeSubType> ValidBiomes;
        /* 0x010 */ public List<NMSString0x20A> ValidDescriptors;
        /* 0x020 */ public int NumShards;
        /* 0x024 */ public bool UseTerrainAngle;
        /* 0x025 */ public bool ScaleOnAppear;
        /* 0x028 */ public GcAudioWwiseEvents CreationAudio;
        /* 0x02C */ public float SpawnDist;
        /* 0x030 */ public float DespawnDist;
        /* 0x034 */ public float MaxOffset;
        /* 0x038 */ public float MaxOffsetZ;
        /* 0x03C */ public float MaxTilt;
        /* 0x040 */ public float OffsetTilt;
        /* 0x044 */ public float MinScale;
        /* 0x048 */ public float MaxScale;
        /* 0x04C */ public float MinAppearTime;
        /* 0x050 */ public float MaxAppearTime;
        /* 0x054 */ public float AppearOvershoot;
        /* 0x058 */ public float MinDisappearTime;
        /* 0x05C */ public float MaxDisappearTime;
        /* 0x060 */ public float ShowOffset;
        /* 0x064 */ public float HideOffset;
        /* 0x068 */ public float MinShowTime;
        /* 0x06C */ public bool CustomHideCurve;
        /* 0x070 */ public TkCurveType HideCurve;
        /* 0x074 */ public float IdleSpeedModifier;
        /* 0x078 */ public float WalkSpeedModifier;
        /* 0x07C */ public float RunSpeedModifier;
        /* 0x080 */ public float ParticleScale;
        /* 0x088 */ public NMSString0x10 DustEffect;
        /* 0x098 */ public GcAudioWwiseEvents Audio;
        /* 0x09C */ public GcAudioWwiseEvents RetractAudio;
        /* 0x0A0 */ public GcAudioWwiseEvents MoveStartAudio;
        /* 0x0A4 */ public GcAudioWwiseEvents MoveStopAudio;
        /* 0x0A8 */ public float DeathFadeStart;
        /* 0x0AC */ public float DeathFadeTime;
        // size: 0x2
        public enum DeathTypeEnum { Explode, Drop }
        /* 0x0B0 */ public DeathTypeEnum DeathType;
        // size: 0x2
        public enum SubTypeEnum { Crystal, Tentacle }
        /* 0x0B4 */ public SubTypeEnum SubType;
        /* 0x0B8 */ public NMSString0x20 TentacleStartJoint;
        /* 0x0D8 */ public NMSString0x20 TentacleEndJoint;
        /* 0x0F8 */ public float TentacleSpeed;
        /* 0x0FC */ public float TentacleChurnSpeed;
        /* 0x100 */ public float TentacleIdleLookChance;
        /* 0x104 */ public float TentacleStretchMin;
        /* 0x108 */ public float TentacleStretchMax;
        /* 0x10C */ public float TentacleMoveSwingAngle;
        /* 0x110 */ public float TentacleWalkSwingSpeed;
        /* 0x114 */ public float TentacleRunSwingSpeed;
        /* 0x118 */ public float TentacleRotationApplyBase;
        /* 0x11C */ public float TentacleRotationApplyTip;
        /* 0x120 */ public float TentacleMoveTimeMin;
        /* 0x124 */ public float TentacleMoveTimeMax;
        /* 0x128 */ public float TentaclePitchRange;
        /* 0x12C */ public float TentacleYawRange;
        /* 0x130 */ public float TentacleRollRange;
    }
}
