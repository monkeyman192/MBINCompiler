namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF16071680EFAC781, NameHash = 0x458BD6BED0D5C445)]
    public class GcPlanetRingData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Colour Colour1;
        [NMS(Index = 3)]
        /* 0x10 */ public Colour Colour2;
        [NMS(Index = 1)]
        /* 0x20 */ public Vector3f Up;
        [NMS(Index = 11)]
        /* 0x30 */ public float AlphaMultiplier;
        [NMS(Index = 10)]
        /* 0x34 */ public float Depth;
        [NMS(Index = 4)]
        /* 0x38 */ public float LargeScale1;
        [NMS(Index = 5)]
        /* 0x3C */ public float LargeScale2;
        [NMS(Index = 6)]
        /* 0x40 */ public float MidScale;
        [NMS(Index = 8)]
        /* 0x44 */ public float MidStrength;
        [NMS(Index = 9)]
        /* 0x48 */ public float Offset;
        [NMS(Index = 7)]
        /* 0x4C */ public float SmallScale;
        [NMS(Index = 0)]
        /* 0x50 */ public bool HasRings;
    }
}
