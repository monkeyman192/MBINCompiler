namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5ED48C0489FB7DD4, NameHash = 0xCB25F378CA730AFC)]
    public class TkHeavyAirData : NMSTemplate
    {
        /* 0x00 */ public Vector3f AmplitudeMax;
        /* 0x10 */ public Vector3f AmplitudeMin;
        /* 0x20 */ public Colour Colour1;
        /* 0x30 */ public Colour Colour2;
        /* 0x40 */ public Vector3f MajorDirection;
        /* 0x50 */ public Vector3f RotationSpeedRange;
        /* 0x60 */ public Vector3f ScaleRange;
        /* 0x70 */ public Vector3f TwinkleRange;
        // size: 0x3
        public enum EmitterShapeEnum : uint {
            Sphere,
            UpperHalfSphere,
            BottomHalfSphere,
        }
        /* 0x80 */ public EmitterShapeEnum EmitterShape;
        /* 0x84 */ public float FadeTime;
        /* 0x88 */ public float MaxParticleLifetime;
        /* 0x8C */ public float MaxVisibleSpeed;
        /* 0x90 */ public float MinParticleLifetime;
        /* 0x94 */ public float MinVisibleSpeed;
        /* 0x98 */ public int NumberOfParticles;
        /* 0x9C */ public float Radius;
        /* 0xA0 */ public float RadiusY;
        /* 0xA4 */ public float SoftFadeStrength;
        /* 0xA8 */ public float SpawnRotationRange;
        /* 0xAC */ public float SpeedFadeInTime;
        /* 0xB0 */ public float SpeedFadeOutTime;
        /* 0xB4 */ public NMSString0x80 Material;
    }
}
