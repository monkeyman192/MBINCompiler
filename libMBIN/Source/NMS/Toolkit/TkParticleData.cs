using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDBB25C326305ADBD, NameHash = 0xE9525144C4F949EB)]
    public class TkParticleData : NMSTemplate
    {
        [NMS(Index = 46)]
        /* 0x000 */ public Colour ColourEnd;
        [NMS(Index = 45)]
        /* 0x010 */ public Colour ColourMiddle;
        [NMS(Index = 44)]
        /* 0x020 */ public Colour ColourStart;
        [NMS(Index = 16)]
        /* 0x030 */ public Vector3f EmitterDirection;
        [NMS(Index = 38)]
        /* 0x040 */ public Vector3f RotateAroundEmitterAxis;
        [NMS(Index = 32)]
        /* 0x050 */ public Vector3f RotationPivot;
        [NMS(Index = 25)]
        /* 0x060 */ public Vector3f SpawnOffsetParams;
        [NMS(Index = 5)]
        /* 0x070 */ public TkParticleBurstData BurstData;
        [NMS(Index = 47)]
        /* 0x168 */ public TkEmitterFloatProperty AlphaThreshold;
        [NMS(Index = 6)]
        /* 0x1E0 */ public TkEmitterFloatProperty EmissionRate;
        [NMS(Index = 10)]
        /* 0x258 */ public TkEmitterFloatProperty EmitterLife;
        [NMS(Index = 19)]
        /* 0x2D0 */ public TkEmitterFloatProperty ParticleDamping;
        [NMS(Index = 20)]
        /* 0x348 */ public TkEmitterFloatProperty ParticleDrag;
        [NMS(Index = 18)]
        /* 0x3C0 */ public TkEmitterFloatProperty ParticleGravity;
        [NMS(Index = 9)]
        /* 0x438 */ public TkEmitterFloatProperty ParticleLife;
        [NMS(Index = 26)]
        /* 0x4B0 */ public TkEmitterFloatProperty ParticleSize;
        [NMS(Index = 27)]
        /* 0x528 */ public TkEmitterFloatProperty ParticleSizeY;
        [NMS(Index = 17)]
        /* 0x5A0 */ public TkEmitterFloatProperty ParticleSpeedMultiplier;
        [NMS(Index = 29)]
        /* 0x618 */ public TkEmitterFloatProperty Rotation;
        [NMS(Index = 50)]
        /* 0x690 */ public NMSString0x10 UserColour;
        [NMS(Index = 55)]
        /* 0x6A0 */ public TkFloatRange CameraDistanceFade;
        [NMS(Index = 8)]
        /* 0x6A8 */ public TkEmitFromParticleInfo EmitFromParticleInfo;
        // size: 0x3
        public enum AlignmentEnum : uint {
            Rotation,
            Velocity,
            VelocityScreenSpace,
        }
        [NMS(Index = 30)]
        /* 0x6B0 */ public AlignmentEnum Alignment;
        [NMS(Index = 43)]
        /* 0x6B4 */ public float AlphaVariance;
        [NMS(Index = 1)]
        /* 0x6B8 */ public uint AudioEvent;
        // size: 0x8
        public enum BillboardAlignmentEnum : uint {
            Screen,
            XLocal,
            YLocal,
            ZLocal,
            NegativeXLocal,
            NegativeYLocal,
            NegativeZLocal,
            ScreenWorld,
        }
        [NMS(Index = 31)]
        /* 0x6BC */ public BillboardAlignmentEnum BillboardAlignment;
        [NMS(Index = 7)]
        /* 0x6C0 */ public float Delay;
        // size: 0x3
        public enum DragTypeEnum : uint {
            IgnoreGravity,
            PhysicallyBased,
            ApplyWind,
        }
        [NMS(Index = 21)]
        /* 0x6C4 */ public DragTypeEnum DragType;
        [NMS(Index = 11)]
        /* 0x6C8 */ public float EmitterMidLifeRatio;
        // size: 0x3
        public enum EmitterQualityLevelEnum : uint {
            All,
            Low,
            High,
        }
        [NMS(Index = 0)]
        /* 0x6CC */ public EmitterQualityLevelEnum EmitterQualityLevel;
        [NMS(Index = 14)]
        /* 0x6D0 */ public float EmitterSpreadAngle;
        [NMS(Index = 15)]
        /* 0x6D4 */ public float EmitterSpreadAngleMin;
        // size: 0x4
        public enum FlipbookPlaybackRateEnum : uint {
            Absolute,
            RelativeToMax,
            OnceToCompletion,
            Random,
        }
        [NMS(Index = 39)]
        /* 0x6D8 */ public FlipbookPlaybackRateEnum FlipbookPlaybackRate;
        [NMS(Index = 40)]
        /* 0x6DC */ public float HueVariance;
        [NMS(Index = 42)]
        /* 0x6E0 */ public float LightnessVariance;
        [NMS(Index = 4)]
        /* 0x6E4 */ public int MaxCount;
        [NMS(Index = 51)]
        /* 0x6E8 */ public float MaxRenderDistance;
        [NMS(Index = 52)]
        /* 0x6EC */ public float MaxSpawnDistance;
        // size: 0x2
        public enum OnRefractionsDisabledEnum : uint {
            Hide,
            AlphaBlend,
        }
        [NMS(Index = 48)]
        /* 0x6F0 */ public OnRefractionsDisabledEnum OnRefractionsDisabled;
        [NMS(Index = 37)]
        /* 0x6F4 */ public float RotateAroundEmitter;
        [NMS(Index = 41)]
        /* 0x6F8 */ public float SaturationVariance;
        [NMS(Index = 53)]
        /* 0x6FC */ public float SoftFadeStrength;
        // size: 0x6
        public enum SpawnOffsetTypeEnum : uint {
            Sphere,
            Box,
            Disc,
            Cone,
            Donut,
            Point,
        }
        [NMS(Index = 24)]
        /* 0x700 */ public SpawnOffsetTypeEnum SpawnOffsetType;
        [NMS(Index = 23)]
        /* 0x704 */ public float StartOffset;
        [NMS(Index = 28)]
        /* 0x708 */ public float StartRotationVariation;
        [NMS(Index = 54)]
        /* 0x70C */ public float SurfaceDistanceFadeStrength;
        [NMS(Index = 36)]
        /* 0x710 */ public float TrackEmitterPosition;
        [NMS(Index = 33)]
        /* 0x714 */ public TkCoordinateOrientation UCoordinate;
        [NMS(Index = 34)]
        /* 0x718 */ public TkCoordinateOrientation VCoordinate;
        [NMS(Index = 22)]
        /* 0x71C */ public float Variation;
        [NMS(Index = 35)]
        /* 0x720 */ public float VelocityInheritance;
        [NMS(Index = 12)]
        /* 0x724 */ public TkCurveType EmitterLifeCurve1;
        [NMS(Index = 13)]
        /* 0x725 */ public TkCurveType EmitterLifeCurve2;
        [NMS(Index = 49)]
        /* 0x726 */ public bool FadeRefractionsAtScreenEdge;
        [NMS(Index = 3)]
        /* 0x727 */ public bool Oneshot;
        [NMS(Index = 2)]
        /* 0x728 */ public bool StartEnabled;
    }
}
