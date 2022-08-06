using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xB5AD1E575E115E05, NameHash = 0xCB25F378CA730AFC)]
    public class TkHeavyAirData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Material;
        /* 0x080 */ public int NumberOfParticles;
        /* 0x084 */ public float Radius;
        /* 0x088 */ public float RadiusY;
        /* 0x08C */ public float MinParticleLifetime;
        /* 0x090 */ public float MaxParticleLifetime;
        /* 0x094 */ public float FadeTime;
        /* 0x098 */ public float SpeedFadeInTime;
        /* 0x09C */ public float MinVisibleSpeed;
        /* 0x0A0 */ public float SpeedFadeOutTime;
        /* 0x0A4 */ public float MaxVisibleSpeed;
        /* 0x0A8 */ public float SoftFadeStrength;
        /* 0x0AC */ public float SpawnRotationRange;
        /* 0x0B0 */ public Vector3f MajorDirection;
        /* 0x0C0 */ public Vector3f ScaleRange;
        /* 0x0D0 */ public Vector3f RotationSpeedRange;
        /* 0x0E0 */ public Vector3f TwinkleRange;
        /* 0x0F0 */ public Vector3f AmplitudeMin;
        /* 0x100 */ public Vector3f AmplitudeMax;
        /* 0x110 */ public Colour Colour1;
        /* 0x120 */ public Colour Colour2;
		public enum EmitterShapeEnum { Sphere, UpperHalfSphere, BottomHalfSphere }
		/* 0x130 */ public EmitterShapeEnum EmitterShape;
    }
}