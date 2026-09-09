using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x525BE9309FE3D0D8, NameHash = 0xFA1C5236)]
    public class TkParticleData : NMSTemplate
    {
        [NMS(Index = 40)]
        /* 0x000 */ public TkEmitterRotation SecondRotationInfo;
        [NMS(Index = 62)]
        /* 0x060 */ public Colour ColourEnd;
        [NMS(Index = 59)]
        /* 0x070 */ public Colour ColourMiddle;
        [NMS(Index = 56)]
        /* 0x080 */ public Colour ColourStart;
        [NMS(Index = 21)]
        /* 0x090 */ public Vector3f EmitterDirection;
        [NMS(Index = 50)]
        /* 0x0A0 */ public Vector3f RotateAroundEmitterAxis;
        [NMS(Index = 38)]
        /* 0x0B0 */ public Vector3f RotationAxis;
        [NMS(Index = 43)]
        /* 0x0C0 */ public Vector3f RotationPivot;
        [NMS(Index = 30)]
        /* 0x0D0 */ public Vector3f SpawnOffsetParams;
        [NMS(Index = 31)]
        /* 0x0E0 */ public TkParticleSize ParticleSize;
        [NMS(Index = 10)]
        /* 0x1F0 */ public TkParticleBurstData BurstData;
        [NMS(Index = 65)]
        /* 0x268 */ public TkEmitterFloatProperty AlphaThreshold;
        [NMS(Index = 11)]
        /* 0x2A0 */ public TkEmitterFloatProperty EmissionRate;
        [NMS(Index = 15)]
        /* 0x2D8 */ public TkEmitterFloatProperty EmitterLife;
        [NMS(Index = 24)]
        /* 0x310 */ public TkEmitterFloatProperty ParticleDamping;
        [NMS(Index = 25)]
        /* 0x348 */ public TkEmitterFloatProperty ParticleDrag;
        [NMS(Index = 23)]
        /* 0x380 */ public TkEmitterFloatProperty ParticleGravity;
        [NMS(Index = 14)]
        /* 0x3B8 */ public TkEmitterFloatProperty ParticleLife;
        [NMS(Index = 33)]
        /* 0x3F0 */ public TkEmitterFloatProperty ParticleSizeY;
        [NMS(Index = 22)]
        /* 0x428 */ public TkEmitterFloatProperty ParticleSpeedMultiplier;
        [NMS(Index = 37)]
        /* 0x460 */ public TkEmitterFloatProperty Rotation;
        [NMS(Index = 47)]
        /* 0x498 */ public TkEmitterFloatProperty TrackEmitterPosition;
        [NMS(Index = 1, MxmlName = "3DGeom")]
        /* 0x4D0 */ public GcFilename _3DGeom;
        [NMS(Index = 3)]
        /* 0x4E0 */ public GcFilename TrailPath;
        [NMS(Index = 68)]
        /* 0x4F0 */ public NMSString0x10 UserColour;
        [NMS(Index = 76)]
        /* 0x500 */ public TkEmitterWindDrift WindDrift;
        [NMS(Index = 64)]
        /* 0x51C */ public TkPaletteTexture ColourEndPalette;
        [NMS(Index = 61)]
        /* 0x528 */ public TkPaletteTexture ColourMiddlePalette;
        [NMS(Index = 58)]
        /* 0x534 */ public TkPaletteTexture ColourStartPalette;
        [NMS(Index = 41, MxmlName = "Billboard Alignment")]
        /* 0x540 */ public TkEmitterBillboardAlignment BillboardAlignment;
        [NMS(Index = 74)]
        /* 0x548 */ public TkFloatRange CameraDistanceFade;
        [NMS(Index = 13)]
        /* 0x550 */ public TkEmitFromParticleInfo EmitFromParticleInfo;
        // size: 0x3
        public enum AlignmentEnum : uint {
            Rotation,
            Velocity,
            VelocityScreenSpace,
        }
        [NMS(Index = 34)]
        /* 0x558 */ public AlignmentEnum Alignment;
        [NMS(Index = 55)]
        /* 0x55C */ public float AlphaVariance;
        [NMS(Index = 6)]
        /* 0x560 */ public uint AudioEvent;
        [NMS(Index = 42)]
        /* 0x564 */ public float BillboardAngleFadeThreshold;
        [NMS(Index = 12)]
        /* 0x568 */ public float Delay;
        // size: 0x3
        public enum DisableDaytimeEnum : uint {
            None,
            Day,
            Night,
        }
        [NMS(Index = 77)]
        /* 0x56C */ public DisableDaytimeEnum DisableDaytime;
        // size: 0x3
        public enum DragTypeEnum : uint {
            IgnoreGravity,
            PhysicallyBased,
            ApplyWind,
        }
        [NMS(Index = 26)]
        /* 0x570 */ public DragTypeEnum DragType;
        [NMS(Index = 16)]
        /* 0x574 */ public float EmitterMidLifeRatio;
        // size: 0x3
        public enum EmitterQualityLevelEnum : uint {
            All,
            Low,
            High,
        }
        [NMS(Index = 0)]
        /* 0x578 */ public EmitterQualityLevelEnum EmitterQualityLevel;
        [NMS(Index = 19)]
        /* 0x57C */ public float EmitterSpreadAngle;
        [NMS(Index = 20)]
        /* 0x580 */ public float EmitterSpreadAngleMin;
        // size: 0x4
        public enum FlipbookPlaybackRateEnum : uint {
            Absolute,
            RelativeToMax,
            OnceToCompletion,
            Random,
        }
        [NMS(Index = 51)]
        /* 0x584 */ public FlipbookPlaybackRateEnum FlipbookPlaybackRate;
        [NMS(Index = 52)]
        /* 0x588 */ public float HueVariance;
        [NMS(Index = 54)]
        /* 0x58C */ public float LightnessVariance;
        [NMS(Index = 75)]
        /* 0x590 */ public float LimitLifetimeOnMove;
        [NMS(Index = 9)]
        /* 0x594 */ public int MaxCount;
        [NMS(Index = 70)]
        /* 0x598 */ public float MaxRenderCameraHeight;
        [NMS(Index = 69)]
        /* 0x59C */ public float MaxRenderDistance;
        [NMS(Index = 71)]
        /* 0x5A0 */ public float MaxSpawnDistance;
        // size: 0x2
        public enum OnRefractionsDisabledEnum : uint {
            Hide,
            AlphaBlend,
        }
        [NMS(Index = 66)]
        /* 0x5A4 */ public OnRefractionsDisabledEnum OnRefractionsDisabled;
        [NMS(Index = 32)]
        /* 0x5A8 */ public float ParticleSizeCurveVariation;
        [NMS(Index = 49)]
        /* 0x5AC */ public float RotateAroundEmitter;
        [NMS(Index = 36)]
        /* 0x5B0 */ public float RotationOffset;
        [NMS(Index = 53)]
        /* 0x5B4 */ public float SaturationVariance;
        [NMS(Index = 72)]
        /* 0x5B8 */ public float SoftFadeStrength;
        // size: 0x6
        public enum SpawnOffsetTypeEnum : uint {
            Sphere,
            Box,
            Disc,
            Cone,
            Donut,
            Point,
        }
        [NMS(Index = 29)]
        /* 0x5BC */ public SpawnOffsetTypeEnum SpawnOffsetType;
        [NMS(Index = 28)]
        /* 0x5C0 */ public float StartOffset;
        [NMS(Index = 35)]
        /* 0x5C4 */ public float StartRotationVariation;
        [NMS(Index = 73)]
        /* 0x5C8 */ public float SurfaceDistanceFadeStrength;
        [NMS(Index = 4)]
        /* 0x5CC */ public float TrailRatio;
        [NMS(Index = 44, MxmlName = "U Coordinate")]
        /* 0x5D0 */ public TkCoordinateOrientation UCoordinate;
        [NMS(Index = 45, MxmlName = "V Coordinate")]
        /* 0x5D4 */ public TkCoordinateOrientation VCoordinate;
        [NMS(Index = 27)]
        /* 0x5D8 */ public float Variation;
        [NMS(Index = 46)]
        /* 0x5DC */ public float VelocityInheritance;
        [NMS(Index = 17)]
        /* 0x5E0 */ public TkCurveType EmitterLifeCurve1;
        [NMS(Index = 18)]
        /* 0x5E1 */ public TkCurveType EmitterLifeCurve2;
        [NMS(Index = 39)]
        /* 0x5E2 */ public bool EnableSecondRotation;
        [NMS(Index = 67)]
        /* 0x5E3 */ public bool FadeRefractionsAtScreenEdge;
        [NMS(Index = 2)]
        /* 0x5E4 */ public bool GPURender;
        [NMS(Index = 8)]
        /* 0x5E5 */ public bool Oneshot;
        [NMS(Index = 7)]
        /* 0x5E6 */ public bool StartEnabled;
        [NMS(Index = 48)]
        /* 0x5E7 */ public bool TrackEmitterRotation;
        [NMS(Index = 5)]
        /* 0x5E8 */ public bool TrailIsRibbon;
        [NMS(Index = 63)]
        /* 0x5E9 */ public bool UseColourEndPalette;
        [NMS(Index = 60)]
        /* 0x5EA */ public bool UseColourMiddlePalette;
        [NMS(Index = 57)]
        /* 0x5EB */ public bool UseColourStartPalette;
    }
}
