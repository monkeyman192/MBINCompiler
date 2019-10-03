using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0xBF9AD056B83B4043, NameHash = 0x458BD6BED0D5C445)]
    public class GcPlanetRingData : NMSTemplate
    {
        /* 0x00 */ public bool HasRings;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x01 */ public byte[] Padding1;
        /* 0x10 */ public Vector4f Up;
        /* 0x20 */ public Colour Colour1;
        /* 0x30 */ public Colour Colour2;
        /* 0x40 */ public float LargeScale1;
        /* 0x44 */ public float LargeScale2;
        /* 0x48 */ public float MidScale;
        /* 0x4C */ public float SmallScale;
        /* 0x50 */ public float MidStrength;
        /* 0x54 */ public float Offset;
        /* 0x58 */ public float Depth;
        /* 0x5C */ public float AlphaMultiplier;
    }
}
