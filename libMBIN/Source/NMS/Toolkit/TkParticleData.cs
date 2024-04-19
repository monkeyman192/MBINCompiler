using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x193FC11F040913E9, NameHash = 0xE9525144C4F949EB)]
    public class TkParticleData : NMSTemplate
    {
        /* 0x000 */ public Colour ColourEnd;
        /* 0x010 */ public Colour ColourMiddle;
        /* 0x020 */ public Colour ColourStart;
        /* 0x030 */ public Vector3f EmitterDirection;
        /* 0x040 */ public Vector3f RotateAroundEmitterAxis;
        /* 0x050 */ public Vector3f RotationPivot;
        /* 0x060 */ public Vector3f SpawnOffsetParams;
        /* 0x070 */ public TkParticleBurstData BurstData;
        /* 0x168 */ public TkEmitterFloatProperty AlphaThreshold;
        /* 0x1E0 */ public TkEmitterFloatProperty EmissionRate;
        /* 0x258 */ public TkEmitterFloatProperty EmitterLife;
        /* 0x2D0 */ public TkEmitterFloatProperty ParticleDamping;
        /* 0x348 */ public TkEmitterFloatProperty ParticleDrag;
        /* 0x3C0 */ public TkEmitterFloatProperty ParticleGravity;
        /* 0x438 */ public TkEmitterFloatProperty ParticleLife;
        /* 0x4B0 */ public TkEmitterFloatProperty ParticleSize;
        /* 0x528 */ public TkEmitterFloatProperty ParticleSizeY;
        /* 0x5A0 */ public TkEmitterFloatProperty ParticleSpeedMultiplier;
        /* 0x618 */ public TkEmitterFloatProperty Rotation;
        /* 0x690 */ public NMSString0x10 UserColour;
        /* 0x6A0 */ public TkFloatRange CameraDistanceFade;
        /* 0x6A8 */ public TkEmitFromParticleInfo EmitFromParticleInfo;
        // size: 0x3
        public enum AlignmentEnum : uint {
            Rotation,
            Velocity,
            VelocityScreenSpace,
        }
        /* 0x6B0 */ public AlignmentEnum Alignment;
        /* 0x6B4 */ public float AlphaVariance;
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
        /* 0x6BC */ public BillboardAlignmentEnum BillboardAlignment;
        /* 0x6C0 */ public float Delay;
        // size: 0x3
        public enum DragTypeEnum : uint {
            IgnoreGravity,
            PhysicallyBased,
            ApplyWind,
        }
        /* 0x6C4 */ public DragTypeEnum DragType;
        /* 0x6C8 */ public float EmitterMidLifeRatio;
        // size: 0x3
        public enum EmitterQualityLevelEnum : uint {
            All,
            Low,
            High,
        }
        /* 0x6CC */ public EmitterQualityLevelEnum EmitterQualityLevel;
        /* 0x6D0 */ public float EmitterSpreadAngle;
        /* 0x6D4 */ public float EmitterSpreadAngleMin;
        // size: 0x4
        public enum FlipbookPlaybackRateEnum : uint {
            Absolute,
            RelativeToMax,
            OnceToCompletion,
            Random,
        }
        /* 0x6D8 */ public FlipbookPlaybackRateEnum FlipbookPlaybackRate;
        /* 0x6DC */ public float HueVariance;
        /* 0x6E0 */ public float LightnessVariance;
        /* 0x6E4 */ public int MaxCount;
        /* 0x6E8 */ public float MaxRenderDistance;
        /* 0x6EC */ public float MaxSpawnDistance;
        // size: 0x2
        public enum OnRefractionsDisabledEnum : uint {
            Hide,
            AlphaBlend,
        }
        /* 0x6F0 */ public OnRefractionsDisabledEnum OnRefractionsDisabled;
        /* 0x6F4 */ public float RotateAroundEmitter;
        /* 0x6F8 */ public float SaturationVariance;
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
        /* 0x700 */ public SpawnOffsetTypeEnum SpawnOffsetType;
        /* 0x704 */ public float StartOffset;
        /* 0x708 */ public float StartRotationVariation;
        /* 0x70C */ public float SurfaceDistanceFadeStrength;
        /* 0x710 */ public float TrackEmitterPosition;
        /* 0x714 */ public TkCoordinateOrientation UCoordinate;
        /* 0x718 */ public TkCoordinateOrientation VCoordinate;
        /* 0x71C */ public float Variation;
        /* 0x720 */ public float VelocityInheritance;
        /* 0x724 */ public TkCurveType EmitterLifeCurve1;
        /* 0x725 */ public TkCurveType EmitterLifeCurve2;
        /* 0x726 */ public bool FadeRefractionsAtScreenEdge;
        /* 0x727 */ public bool Oneshot;
        /* 0x728 */ public bool StartEnabled;
    }
}
