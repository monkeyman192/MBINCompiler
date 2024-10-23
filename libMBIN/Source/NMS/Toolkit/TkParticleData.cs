using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7180EF39AA992E2C, NameHash = 0xFA1C5236)]
    public class TkParticleData : NMSTemplate
    {
        [NMS(Index = 48)]
        /* 0x000 */ public Colour ColourEnd;
        [NMS(Index = 47)]
        /* 0x010 */ public Colour ColourMiddle;
        [NMS(Index = 46)]
        /* 0x020 */ public Colour ColourStart;
        [NMS(Index = 18)]
        /* 0x030 */ public Vector3f EmitterDirection;
        [NMS(Index = 40)]
        /* 0x040 */ public Vector3f RotateAroundEmitterAxis;
        [NMS(Index = 34)]
        /* 0x050 */ public Vector3f RotationPivot;
        [NMS(Index = 27)]
        /* 0x060 */ public Vector3f SpawnOffsetParams;
        [NMS(Index = 7)]
        /* 0x070 */ public TkParticleBurstData BurstData;
        [NMS(Index = 49)]
        /* 0x0E8 */ public TkEmitterFloatProperty AlphaThreshold;
        [NMS(Index = 8)]
        /* 0x120 */ public TkEmitterFloatProperty EmissionRate;
        [NMS(Index = 12)]
        /* 0x158 */ public TkEmitterFloatProperty EmitterLife;
        [NMS(Index = 21)]
        /* 0x190 */ public TkEmitterFloatProperty ParticleDamping;
        [NMS(Index = 22)]
        /* 0x1C8 */ public TkEmitterFloatProperty ParticleDrag;
        [NMS(Index = 20)]
        /* 0x200 */ public TkEmitterFloatProperty ParticleGravity;
        [NMS(Index = 11)]
        /* 0x238 */ public TkEmitterFloatProperty ParticleLife;
        [NMS(Index = 28)]
        /* 0x270 */ public TkEmitterFloatProperty ParticleSize;
        [NMS(Index = 29)]
        /* 0x2A8 */ public TkEmitterFloatProperty ParticleSizeY;
        [NMS(Index = 19)]
        /* 0x2E0 */ public TkEmitterFloatProperty ParticleSpeedMultiplier;
        [NMS(Index = 31)]
        /* 0x318 */ public TkEmitterFloatProperty Rotation;
        [NMS(Index = 52)]
        /* 0x350 */ public NMSString0x10 UserColour;
        [NMS(Index = 59)]
        /* 0x360 */ public TkEmitterWindDrift WindDrift;
        [NMS(Index = 33)]
        /* 0x37C */ public TkEmitterBillboardAlignment BillboardAlignment;
        [NMS(Index = 58)]
        /* 0x384 */ public TkFloatRange CameraDistanceFade;
        [NMS(Index = 10)]
        /* 0x38C */ public TkEmitFromParticleInfo EmitFromParticleInfo;
        // size: 0x3
        public enum AlignmentEnum : uint {
            Rotation,
            Velocity,
            VelocityScreenSpace,
        }
        [NMS(Index = 32)]
        /* 0x394 */ public AlignmentEnum Alignment;
        [NMS(Index = 45)]
        /* 0x398 */ public float AlphaVariance;
        [NMS(Index = 3)]
        /* 0x39C */ public uint AudioEvent;
        [NMS(Index = 9)]
        /* 0x3A0 */ public float Delay;
        // size: 0x3
        public enum DragTypeEnum : uint {
            IgnoreGravity,
            PhysicallyBased,
            ApplyWind,
        }
        [NMS(Index = 23)]
        /* 0x3A4 */ public DragTypeEnum DragType;
        [NMS(Index = 13)]
        /* 0x3A8 */ public float EmitterMidLifeRatio;
        // size: 0x3
        public enum EmitterQualityLevelEnum : uint {
            All,
            Low,
            High,
        }
        [NMS(Index = 0)]
        /* 0x3AC */ public EmitterQualityLevelEnum EmitterQualityLevel;
        [NMS(Index = 16)]
        /* 0x3B0 */ public float EmitterSpreadAngle;
        [NMS(Index = 17)]
        /* 0x3B4 */ public float EmitterSpreadAngleMin;
        // size: 0x4
        public enum FlipbookPlaybackRateEnum : uint {
            Absolute,
            RelativeToMax,
            OnceToCompletion,
            Random,
        }
        [NMS(Index = 41)]
        /* 0x3B8 */ public FlipbookPlaybackRateEnum FlipbookPlaybackRate;
        [NMS(Index = 42)]
        /* 0x3BC */ public float HueVariance;
        [NMS(Index = 44)]
        /* 0x3C0 */ public float LightnessVariance;
        [NMS(Index = 6)]
        /* 0x3C4 */ public int MaxCount;
        [NMS(Index = 54)]
        /* 0x3C8 */ public float MaxRenderCameraHeight;
        [NMS(Index = 53)]
        /* 0x3CC */ public float MaxRenderDistance;
        [NMS(Index = 55)]
        /* 0x3D0 */ public float MaxSpawnDistance;
        // size: 0x2
        public enum OnRefractionsDisabledEnum : uint {
            Hide,
            AlphaBlend,
        }
        [NMS(Index = 50)]
        /* 0x3D4 */ public OnRefractionsDisabledEnum OnRefractionsDisabled;
        [NMS(Index = 39)]
        /* 0x3D8 */ public float RotateAroundEmitter;
        [NMS(Index = 43)]
        /* 0x3DC */ public float SaturationVariance;
        [NMS(Index = 56)]
        /* 0x3E0 */ public float SoftFadeStrength;
        // size: 0x6
        public enum SpawnOffsetTypeEnum : uint {
            Sphere,
            Box,
            Disc,
            Cone,
            Donut,
            Point,
        }
        [NMS(Index = 26)]
        /* 0x3E4 */ public SpawnOffsetTypeEnum SpawnOffsetType;
        [NMS(Index = 25)]
        /* 0x3E8 */ public float StartOffset;
        [NMS(Index = 30)]
        /* 0x3EC */ public float StartRotationVariation;
        [NMS(Index = 57)]
        /* 0x3F0 */ public float SurfaceDistanceFadeStrength;
        [NMS(Index = 38)]
        /* 0x3F4 */ public float TrackEmitterPosition;
        [NMS(Index = 2)]
        /* 0x3F8 */ public float TrailRatio;
        [NMS(Index = 35)]
        /* 0x3FC */ public TkCoordinateOrientation UCoordinate;
        [NMS(Index = 36)]
        /* 0x400 */ public TkCoordinateOrientation VCoordinate;
        [NMS(Index = 24)]
        /* 0x404 */ public float Variation;
        [NMS(Index = 37)]
        /* 0x408 */ public float VelocityInheritance;
        [NMS(Index = 1)]
        /* 0x40C */ public NMSString0x100 TrailPath;
        [NMS(Index = 14)]
        /* 0x50C */ public TkCurveType EmitterLifeCurve1;
        [NMS(Index = 15)]
        /* 0x50D */ public TkCurveType EmitterLifeCurve2;
        [NMS(Index = 51)]
        /* 0x50E */ public bool FadeRefractionsAtScreenEdge;
        [NMS(Index = 5)]
        /* 0x50F */ public bool Oneshot;
        [NMS(Index = 4)]
        /* 0x510 */ public bool StartEnabled;
    }
}
