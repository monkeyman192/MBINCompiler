using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF27DAD75AEF93B00, NameHash = 0x89DABA975B2143E3)]
    public class GcDiscoveryDisplayComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcScanEffectData DiscoveryScanEffect;
        [NMS(Index = 1)]
        /* 0x50 */ public float DiscoveryScale;
        [NMS(Index = 2)]
        /* 0x54 */ public float DiscoveryScalePlanets;
    }
}
