using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBF9AD056B83B4043, NameHash = 0x458BD6BED0D5C445)]
    public class GcPlanetRingData : NMSTemplate
    {
        /* 0x00 */ public bool HasRings;
        /* 0x10 */ public Vector3f Up;
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
