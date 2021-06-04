using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x48, GUID = 0xACF1A1C9560AFE02, NameHash = 0xB5D7AD8F4482D8AE)]
    public class GcObjectSpawnDataVariant : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public float Coverage;
        /* 0x14 */ public float FlatDensity;
        /* 0x18 */ public float SlopeDensity;
        /* 0x1C */ public float SlopeMultiplier;
        /* 0x20 */ public int MaxRegionRadius;
        /* 0x24 */ public int MaxImposterRadius;
        /* 0x28 */ public float FadeOutStartDistance;
        /* 0x2C */ public float FadeOutEndDistance;
        /* 0x30 */ public float FadeOutOffsetDistance;
        [NMS(Size = 0x5)]
        /* 0x34 */ public float[] LodDistances;
    }
}
