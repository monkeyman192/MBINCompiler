using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xD0, GUID = 0x6FFE4AC2BE301EB6, NameHash = 0xE9525144C4F949EB)]
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
        [NMS(Size = 4, Ignore = true)]
        /* 0x2C */ public byte[] Padding2C;

        /* 0x30 */ public Vector4f EmitterDirection;
        /* 0x40 */ public float EmitterGravity;
        /* 0x44 */ public float EmitterDamping;
        /* 0x48 */ public float Variation;
        /* 0x4C */ public float StartOffset;
        /* 0x50 */ public float SizeStart;
        /* 0x54 */ public float SizeMiddle;
        /* 0x58 */ public float SizeEnd;
        /* 0x5C */ public float Rotation;
        /* 0x60 */ public float VelocityInheritance;
        /* 0x64 */ public float Bounce;
        /* 0x68 */ public float HueVariance;
        /* 0x6C */ public float SaturationVariance;
        /* 0x70 */ public float LightnessVariance;
        /* 0x74 */ public float AlphaVariance;
        /* 0x80 */ public Colour ColourStart;
        /* 0x90 */ public Colour ColourMiddle;
        /* 0xA0 */ public Colour ColourEnd;
        [NMS(Size = 0x10)]
        /* 0xB0 */ public string UserColour;

        /* 0xC0 */ public float MaxRenderDistance;
        /* 0xC4 */ public float MaxSpawnDistance;

        [NMS(Size = 8, Ignore = true)]
        /* 0xC8 */ public byte[] EndPadding;
    }
}
