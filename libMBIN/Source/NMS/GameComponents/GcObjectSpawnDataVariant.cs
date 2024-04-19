namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x338FD10AF4E1E015, NameHash = 0xB5D7AD8F4482D8AE)]
    public class GcObjectSpawnDataVariant : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Size = 0x5)]
        /* 0x10 */ public float[] LodDistances;
        /* 0x24 */ public float Coverage;
        /* 0x28 */ public float FadeOutEndDistance;
        /* 0x2C */ public float FadeOutOffsetDistance;
        /* 0x30 */ public float FadeOutStartDistance;
        /* 0x34 */ public float FlatDensity;
        /* 0x38 */ public int MaxImposterRadius;
        /* 0x3C */ public int MaxRegionRadius;
        /* 0x40 */ public float SlopeDensity;
        /* 0x44 */ public float SlopeMultiplier;
    }
}
