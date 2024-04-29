namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x36E8AD5F62B703C6, NameHash = 0xCB25F378CA730AFC)]
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
        // size: 0x3
        public enum EmitterShapeEnum : uint {
            Sphere,
            UpperHalfSphere,
            BottomHalfSphere,
        }
        [NMS(Index = 21)]
        /* 0x80 */ public EmitterShapeEnum EmitterShape;
        [NMS(Index = 6)]
        /* 0x84 */ public float FadeTime;
        [NMS(Index = 5)]
        /* 0x88 */ public float MaxParticleLifetime;
        [NMS(Index = 10)]
        /* 0x8C */ public float MaxVisibleSpeed;
        [NMS(Index = 4)]
        /* 0x90 */ public float MinParticleLifetime;
        [NMS(Index = 8)]
        /* 0x94 */ public float MinVisibleSpeed;
        [NMS(Index = 1)]
        /* 0x98 */ public int NumberOfParticles;
        [NMS(Index = 2)]
        /* 0x9C */ public float Radius;
        [NMS(Index = 3)]
        /* 0xA0 */ public float RadiusY;
        [NMS(Index = 11)]
        /* 0xA4 */ public float SoftFadeStrength;
        [NMS(Index = 12)]
        /* 0xA8 */ public float SpawnRotationRange;
        [NMS(Index = 7)]
        /* 0xAC */ public float SpeedFadeInTime;
        [NMS(Index = 9)]
        /* 0xB0 */ public float SpeedFadeOutTime;
        [NMS(Index = 0)]
        /* 0xB4 */ public NMSString0x80 Material;
    }
}
