using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2C67E251BC6CFCFA, NameHash = 0x6522C6AC)]
    public class TkHeavyAirData : NMSTemplate
    {
        [NMS(Index = 19, MxmlName = "Amplitude Max")]
        /* 0x00 */ public Vector3f AmplitudeMax;
        [NMS(Index = 18, MxmlName = "Amplitude Min")]
        /* 0x10 */ public Vector3f AmplitudeMin;
        [NMS(Index = 20, MxmlName = "Colour 1")]
        /* 0x20 */ public Colour Colour1;
        [NMS(Index = 21, MxmlName = "Colour 2")]
        /* 0x30 */ public Colour Colour2;
        [NMS(Index = 14, MxmlName = "Major Direction")]
        /* 0x40 */ public Vector3f MajorDirection;
        [NMS(Index = 16, MxmlName = "Rotation Speed Range")]
        /* 0x50 */ public Vector3f RotationSpeedRange;
        [NMS(Index = 15, MxmlName = "Scale Range")]
        /* 0x60 */ public Vector3f ScaleRange;
        [NMS(Index = 17, MxmlName = "Twinkle Range")]
        /* 0x70 */ public Vector3f TwinkleRange;
        [NMS(Index = 0)]
        /* 0x80 */ public GcFilename Material;
        [NMS(Index = 24)]
        /* 0x90 */ public TkEmitterWindDrift WindDrift;
        [NMS(Index = 6, MxmlName = "Effect Fade Time")]
        /* 0xAC */ public float EffectFadeTime;
        // size: 0x3
        public enum EmitterShapeEnum : uint {
            Sphere,
            UpperHalfSphere,
            BottomHalfSphere,
        }
        [NMS(Index = 22)]
        /* 0xB0 */ public EmitterShapeEnum EmitterShape;
        [NMS(Index = 5, MxmlName = "Max Particle Lifetime")]
        /* 0xB4 */ public float MaxParticleLifetime;
        [NMS(Index = 11, MxmlName = "Max Visible Speed")]
        /* 0xB8 */ public float MaxVisibleSpeed;
        [NMS(Index = 4, MxmlName = "Min Particle Lifetime")]
        /* 0xBC */ public float MinParticleLifetime;
        [NMS(Index = 9, MxmlName = "Min Visible Speed")]
        /* 0xC0 */ public float MinVisibleSpeed;
        [NMS(Index = 1, MxmlName = "Number Of Particles")]
        /* 0xC4 */ public int NumberOfParticles;
        [NMS(Index = 7, MxmlName = "Particle Fade Time")]
        /* 0xC8 */ public float ParticleFadeTime;
        [NMS(Index = 2)]
        /* 0xCC */ public float Radius;
        [NMS(Index = 3)]
        /* 0xD0 */ public float RadiusY;
        [NMS(Index = 12, MxmlName = "Soft Fade Strength")]
        /* 0xD4 */ public float SoftFadeStrength;
        [NMS(Index = 13, MxmlName = "Spawn Rotation Range")]
        /* 0xD8 */ public float SpawnRotationRange;
        [NMS(Index = 8, MxmlName = "Speed Fade In Time")]
        /* 0xDC */ public float SpeedFadeInTime;
        [NMS(Index = 10, MxmlName = "Speed Fade Out Time")]
        /* 0xE0 */ public float SpeedFadeOutTime;
        [NMS(Index = 23)]
        /* 0xE4 */ public bool VelocityAlignment;
    }
}
