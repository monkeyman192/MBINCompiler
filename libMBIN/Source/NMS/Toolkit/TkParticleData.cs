using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x100, GUID = 0xE4D91D086120647, NameHash = 0xE9525144C4F949EB)]
    public class TkParticleData : NMSTemplate
    {
        /* 0x00 */ public bool StartEnabled;
        /* 0x01 */ public bool Oneshot;
        /* 0x04 */ public int MaxCount;
        /* 0x08 */ public float EmissionRate;
        /* 0x0C */ public float Delay;
        /* 0x10 */ public float ParticleLife;
        /* 0x14 */ public float EmitterLife;
        /* 0x18 */ public float EmitterMidLifeRatio;
        /* 0x1C */ public TkCurveType EmitterLifeCurve1;
        /* 0x20 */ public TkCurveType EmitterLifeCurve2;
        /* 0x24 */ public float EmitterSpreadAngle;
        /* 0x28 */ public float EmitterSpreadAngleMin;
        /* 0x30 */ public Vector3f EmitterDirection;
        /* 0x40 */ public float EmitterGravity;
        /* 0x44 */ public float EmitterDamping;
        /* 0x48 */ public float Variation;
        /* 0x4C */ public float StartOffset;
        public enum SpawnOffsetTypeEnum { Sphere, Box, Disc, Cone, Donut }
        /* 0x50 */ public SpawnOffsetTypeEnum SpawnOffsetType;
        /* 0x60 */ public Vector3f SpawnOffsetParams;
        /* 0x70 */ public float SizeStart;
        /* 0x74 */ public float SizeMiddle;
        /* 0x78 */ public float SizeEnd;
        /* 0x7C */ public float Rotation;
        /* 0x80 */ public float VelocityInheritance;
        /* 0x84 */ public float Bounce;
        /* 0x88 */ public float RotateAroundEmitter;
        /* 0x90 */ public Vector3f RotateAroundEmitterAxis;
        /* 0xA0 */ public float HueVariance;
        /* 0xA4 */ public float SaturationVariance;
        /* 0xA8 */ public float LightnessVariance;
        /* 0xAC */ public float AlphaVariance;
        /* 0xB0 */ public Colour ColourStart;
        /* 0xC0 */ public Colour ColourMiddle;
        /* 0xD0 */ public Colour ColourEnd;
        /* 0xE0 */ public NMSString0x10 UserColour;
        /* 0xF0 */ public float MaxRenderDistance;
        /* 0xF4 */ public float MaxSpawnDistance;
        [NMS(Size = 8, Ignore = true)]
        /* 0xF8 */ public byte[] EndPadding;
    }
}
