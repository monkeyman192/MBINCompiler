using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8D618F9696127DA9, NameHash = 0x1232AC16AD2DF95C)]
    public class GcCreatureCrystalMovementDataParams : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 DustEffect;
        /* 0x010 */ public List<GcBiomeSubType> ValidBiomes;
        /* 0x020 */ public List<NMSString0x20A> ValidDescriptors;
        /* 0x030 */ public float AppearOvershoot;
        /* 0x034 */ public GcAudioWwiseEvents Audio;
        /* 0x038 */ public GcAudioWwiseEvents CreationAudio;
        /* 0x03C */ public float DeathFadeStart;
        /* 0x040 */ public float DeathFadeTime;
        // size: 0x2
        public enum DeathTypeEnum : uint {
            Explode,
            Drop,
        }
        /* 0x044 */ public DeathTypeEnum DeathType;
        /* 0x048 */ public float DespawnDist;
        /* 0x04C */ public float HideOffset;
        /* 0x050 */ public float IdleSpeedModifier;
        /* 0x054 */ public float MaxAppearTime;
        /* 0x058 */ public float MaxDisappearTime;
        /* 0x05C */ public float MaxOffset;
        /* 0x060 */ public float MaxOffsetZ;
        /* 0x064 */ public float MaxScale;
        /* 0x068 */ public float MaxTilt;
        /* 0x06C */ public float MinAppearTime;
        /* 0x070 */ public float MinDisappearTime;
        /* 0x074 */ public float MinScale;
        /* 0x078 */ public float MinShowTime;
        /* 0x07C */ public GcAudioWwiseEvents MoveStartAudio;
        /* 0x080 */ public GcAudioWwiseEvents MoveStopAudio;
        /* 0x084 */ public int NumShards;
        /* 0x088 */ public float OffsetTilt;
        /* 0x08C */ public float ParticleScale;
        /* 0x090 */ public GcAudioWwiseEvents RetractAudio;
        /* 0x094 */ public float RunSpeedModifier;
        /* 0x098 */ public float ShowOffset;
        /* 0x09C */ public float SpawnDist;
        // size: 0x2
        public enum SubTypeEnum : uint {
            Crystal,
            Tentacle,
        }
        /* 0x0A0 */ public SubTypeEnum SubType;
        /* 0x0A4 */ public float TentacleChurnSpeed;
        /* 0x0A8 */ public float TentacleIdleLookChance;
        /* 0x0AC */ public float TentacleMoveSwingAngle;
        /* 0x0B0 */ public float TentacleMoveTimeMax;
        /* 0x0B4 */ public float TentacleMoveTimeMin;
        /* 0x0B8 */ public float TentaclePitchRange;
        /* 0x0BC */ public float TentacleRollRange;
        /* 0x0C0 */ public float TentacleRotationApplyBase;
        /* 0x0C4 */ public float TentacleRotationApplyTip;
        /* 0x0C8 */ public float TentacleRunSwingSpeed;
        /* 0x0CC */ public float TentacleSpeed;
        /* 0x0D0 */ public float TentacleStretchMax;
        /* 0x0D4 */ public float TentacleStretchMin;
        /* 0x0D8 */ public float TentacleWalkSwingSpeed;
        /* 0x0DC */ public float TentacleYawRange;
        /* 0x0E0 */ public float WalkSpeedModifier;
        /* 0x0E4 */ public NMSString0x20 TentacleEndJoint;
        /* 0x104 */ public NMSString0x20 TentacleStartJoint;
        /* 0x124 */ public bool CustomHideCurve;
        /* 0x125 */ public TkCurveType HideCurve;
        /* 0x126 */ public bool ScaleOnAppear;
        /* 0x127 */ public bool UseTerrainAngle;
    }
}
