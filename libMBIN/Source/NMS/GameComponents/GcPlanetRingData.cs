namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DC3BCA8345F0164, NameHash = 0x458BD6BED0D5C445)]
    public class GcPlanetRingData : NMSTemplate
    {
        /* 0x00 */ public Colour Colour1;
        /* 0x10 */ public Colour Colour2;
        /* 0x20 */ public Vector3f Up;
        /* 0x30 */ public float AlphaMultiplier;
        /* 0x34 */ public float Depth;
        /* 0x38 */ public float LargeScale1;
        /* 0x3C */ public float LargeScale2;
        /* 0x40 */ public float MidScale;
        /* 0x44 */ public float MidStrength;
        /* 0x48 */ public float Offset;
        /* 0x4C */ public float SmallScale;
        /* 0x50 */ public bool HasRings;
    }
}
