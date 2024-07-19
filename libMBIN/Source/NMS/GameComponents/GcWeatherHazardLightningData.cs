using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3249F05979424FAA, NameHash = 0x7BA27CDA)]
    public class GcWeatherHazardLightningData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource IndicatorDecal;
        [NMS(Index = 1)]
        /* 0x18 */ public TkModelResource StaticDecal;
        [NMS(Index = 14)]
        /* 0x30 */ public NMSString0x10 DamageID;
        [NMS(Index = 13)]
        /* 0x40 */ public NMSString0x10 ImpactParticle;
        [NMS(Index = 12)]
        /* 0x50 */ public NMSString0x10 ShakeID;
        [NMS(Index = 16)]
        /* 0x60 */ public float DamageRadius;
        [NMS(Index = 4)]
        /* 0x64 */ public float DecalFullGrowthProgress;
        [NMS(Index = 7)]
        /* 0x68 */ public float EarliestImpact;
        [NMS(Index = 8)]
        /* 0x6C */ public float EarliestImpactFirstInstance;
        [NMS(Index = 6)]
        /* 0x70 */ public float FlashStartProgress;
        [NMS(Index = 15)]
        /* 0x74 */ public float FullDamageRadius;
        [NMS(Index = 3)]
        /* 0x78 */ public float MaxRadius;
        [NMS(Index = 11)]
        /* 0x7C */ public int MaxStrikes;
        [NMS(Index = 2)]
        /* 0x80 */ public float MinRadius;
        [NMS(Index = 10)]
        /* 0x84 */ public int MinStrikes;
        [NMS(Index = 5)]
        /* 0x88 */ public float NumFlashes;
        [NMS(Index = 9)]
        /* 0x8C */ public float StormDuration;
    }
}
