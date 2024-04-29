using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47069A681949A26F, NameHash = 0x1232AC16AD2DF95C)]
    public class GcCreatureCrystalMovementDataParams : NMSTemplate
    {
        [NMS(Index = 28)]
        /* 0x000 */ public NMSString0x10 DustEffect;
        [NMS(Index = 0)]
        /* 0x010 */ public List<GcBiomeSubType> ValidBiomes;
        [NMS(Index = 1)]
        /* 0x020 */ public List<NMSString0x20A> ValidDescriptors;
        [NMS(Index = 16)]
        /* 0x030 */ public float AppearOvershoot;
        [NMS(Index = 29)]
        /* 0x034 */ public GcAudioWwiseEvents Audio;
        [NMS(Index = 5)]
        /* 0x038 */ public GcAudioWwiseEvents CreationAudio;
        [NMS(Index = 33)]
        /* 0x03C */ public float DeathFadeStart;
        [NMS(Index = 34)]
        /* 0x040 */ public float DeathFadeTime;
        // size: 0x2
        public enum DeathTypeEnum : uint {
            Explode,
            Drop,
        }
        [NMS(Index = 35)]
        /* 0x044 */ public DeathTypeEnum DeathType;
        [NMS(Index = 7)]
        /* 0x048 */ public float DespawnDist;
        [NMS(Index = 20)]
        /* 0x04C */ public float HideOffset;
        [NMS(Index = 24)]
        /* 0x050 */ public float IdleSpeedModifier;
        [NMS(Index = 15)]
        /* 0x054 */ public float MaxAppearTime;
        [NMS(Index = 18)]
        /* 0x058 */ public float MaxDisappearTime;
        [NMS(Index = 8)]
        /* 0x05C */ public float MaxOffset;
        [NMS(Index = 9)]
        /* 0x060 */ public float MaxOffsetZ;
        [NMS(Index = 13)]
        /* 0x064 */ public float MaxScale;
        [NMS(Index = 10)]
        /* 0x068 */ public float MaxTilt;
        [NMS(Index = 14)]
        /* 0x06C */ public float MinAppearTime;
        [NMS(Index = 17)]
        /* 0x070 */ public float MinDisappearTime;
        [NMS(Index = 12)]
        /* 0x074 */ public float MinScale;
        [NMS(Index = 21)]
        /* 0x078 */ public float MinShowTime;
        [NMS(Index = 31)]
        /* 0x07C */ public GcAudioWwiseEvents MoveStartAudio;
        [NMS(Index = 32)]
        /* 0x080 */ public GcAudioWwiseEvents MoveStopAudio;
        [NMS(Index = 2)]
        /* 0x084 */ public int NumShards;
        [NMS(Index = 11)]
        /* 0x088 */ public float OffsetTilt;
        [NMS(Index = 27)]
        /* 0x08C */ public float ParticleScale;
        [NMS(Index = 30)]
        /* 0x090 */ public GcAudioWwiseEvents RetractAudio;
        [NMS(Index = 26)]
        /* 0x094 */ public float RunSpeedModifier;
        [NMS(Index = 19)]
        /* 0x098 */ public float ShowOffset;
        [NMS(Index = 6)]
        /* 0x09C */ public float SpawnDist;
        // size: 0x2
        public enum SubTypeEnum : uint {
            Crystal,
            Tentacle,
        }
        [NMS(Index = 36)]
        /* 0x0A0 */ public SubTypeEnum SubType;
        [NMS(Index = 40)]
        /* 0x0A4 */ public float TentacleChurnSpeed;
        [NMS(Index = 41)]
        /* 0x0A8 */ public float TentacleIdleLookChance;
        [NMS(Index = 44)]
        /* 0x0AC */ public float TentacleMoveSwingAngle;
        [NMS(Index = 50)]
        /* 0x0B0 */ public float TentacleMoveTimeMax;
        [NMS(Index = 49)]
        /* 0x0B4 */ public float TentacleMoveTimeMin;
        [NMS(Index = 51)]
        /* 0x0B8 */ public float TentaclePitchRange;
        [NMS(Index = 53)]
        /* 0x0BC */ public float TentacleRollRange;
        [NMS(Index = 47)]
        /* 0x0C0 */ public float TentacleRotationApplyBase;
        [NMS(Index = 48)]
        /* 0x0C4 */ public float TentacleRotationApplyTip;
        [NMS(Index = 46)]
        /* 0x0C8 */ public float TentacleRunSwingSpeed;
        [NMS(Index = 39)]
        /* 0x0CC */ public float TentacleSpeed;
        [NMS(Index = 43)]
        /* 0x0D0 */ public float TentacleStretchMax;
        [NMS(Index = 42)]
        /* 0x0D4 */ public float TentacleStretchMin;
        [NMS(Index = 45)]
        /* 0x0D8 */ public float TentacleWalkSwingSpeed;
        [NMS(Index = 52)]
        /* 0x0DC */ public float TentacleYawRange;
        [NMS(Index = 25)]
        /* 0x0E0 */ public float WalkSpeedModifier;
        [NMS(Index = 38)]
        /* 0x0E4 */ public NMSString0x20 TentacleEndJoint;
        [NMS(Index = 37)]
        /* 0x104 */ public NMSString0x20 TentacleStartJoint;
        [NMS(Index = 22)]
        /* 0x124 */ public bool CustomHideCurve;
        [NMS(Index = 23)]
        /* 0x125 */ public TkCurveType HideCurve;
        [NMS(Index = 4)]
        /* 0x126 */ public bool ScaleOnAppear;
        [NMS(Index = 3)]
        /* 0x127 */ public bool UseTerrainAngle;
    }
}
