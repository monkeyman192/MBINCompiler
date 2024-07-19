using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB0088800DFA16536, NameHash = 0x6522C6AC)]
    public class TkHeavyAirData : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x00 */ public Vector3f AmplitudeMax;
        [NMS(Index = 17)]
        /* 0x10 */ public Vector3f AmplitudeMin;
        [NMS(Index = 19)]
        /* 0x20 */ public Colour Colour1;
        [NMS(Index = 20)]
        /* 0x30 */ public Colour Colour2;
        [NMS(Index = 13)]
        /* 0x40 */ public Vector3f MajorDirection;
        [NMS(Index = 15)]
        /* 0x50 */ public Vector3f RotationSpeedRange;
        [NMS(Index = 14)]
        /* 0x60 */ public Vector3f ScaleRange;
        [NMS(Index = 16)]
        /* 0x70 */ public Vector3f TwinkleRange;
        [NMS(Index = 0)]
        /* 0x80 */ public VariableSizeString Material;
        [NMS(Index = 23)]
        /* 0x90 */ public TkEmitterWindDrift WindDrift;
        // size: 0x3
        public enum EmitterShapeEnum : uint {
            Sphere,
            UpperHalfSphere,
            BottomHalfSphere,
        }
        [NMS(Index = 21)]
        /* 0xAC */ public EmitterShapeEnum EmitterShape;
        [NMS(Index = 6)]
        /* 0xB0 */ public float FadeTime;
        [NMS(Index = 5)]
        /* 0xB4 */ public float MaxParticleLifetime;
        [NMS(Index = 10)]
        /* 0xB8 */ public float MaxVisibleSpeed;
        [NMS(Index = 4)]
        /* 0xBC */ public float MinParticleLifetime;
        [NMS(Index = 8)]
        /* 0xC0 */ public float MinVisibleSpeed;
        [NMS(Index = 1)]
        /* 0xC4 */ public int NumberOfParticles;
        [NMS(Index = 2)]
        /* 0xC8 */ public float Radius;
        [NMS(Index = 3)]
        /* 0xCC */ public float RadiusY;
        [NMS(Index = 11)]
        /* 0xD0 */ public float SoftFadeStrength;
        [NMS(Index = 12)]
        /* 0xD4 */ public float SpawnRotationRange;
        [NMS(Index = 7)]
        /* 0xD8 */ public float SpeedFadeInTime;
        [NMS(Index = 9)]
        /* 0xDC */ public float SpeedFadeOutTime;
        [NMS(Index = 22)]
        /* 0xE0 */ public bool VelocityAlignment;
    }
}
