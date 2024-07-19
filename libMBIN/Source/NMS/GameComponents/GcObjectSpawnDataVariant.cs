namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFF00F54A9D9BCC37, NameHash = 0x88D4B84A)]
    public class GcObjectSpawnDataVariant : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 10, Size = 0x5)]
        /* 0x10 */ public float[] LodDistances;
        [NMS(Index = 1)]
        /* 0x24 */ public float Coverage;
        [NMS(Index = 8)]
        /* 0x28 */ public float FadeOutEndDistance;
        [NMS(Index = 9)]
        /* 0x2C */ public float FadeOutOffsetDistance;
        [NMS(Index = 7)]
        /* 0x30 */ public float FadeOutStartDistance;
        [NMS(Index = 2)]
        /* 0x34 */ public float FlatDensity;
        [NMS(Index = 6)]
        /* 0x38 */ public int MaxImposterRadius;
        [NMS(Index = 5)]
        /* 0x3C */ public int MaxRegionRadius;
        [NMS(Index = 3)]
        /* 0x40 */ public float SlopeDensity;
        [NMS(Index = 4)]
        /* 0x44 */ public float SlopeMultiplier;
    }
}
