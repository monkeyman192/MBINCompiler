using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF760C8952ED4DBE6, NameHash = 0xD85F7F00F1F64BD1)]
    public class GcWeatherHazardLightningData : NMSTemplate
    {
        [NMS(Index = 14)]
        /* 0x000 */ public NMSString0x10 DamageID;
        [NMS(Index = 13)]
        /* 0x010 */ public NMSString0x10 ImpactParticle;
        [NMS(Index = 12)]
        /* 0x020 */ public NMSString0x10 ShakeID;
        [NMS(Index = 0)]
        /* 0x030 */ public TkModelResource IndicatorDecal;
        [NMS(Index = 1)]
        /* 0x0B4 */ public TkModelResource StaticDecal;
        [NMS(Index = 16)]
        /* 0x138 */ public float DamageRadius;
        [NMS(Index = 4)]
        /* 0x13C */ public float DecalFullGrowthProgress;
        [NMS(Index = 7)]
        /* 0x140 */ public float EarliestImpact;
        [NMS(Index = 8)]
        /* 0x144 */ public float EarliestImpactFirstInstance;
        [NMS(Index = 6)]
        /* 0x148 */ public float FlashStartProgress;
        [NMS(Index = 15)]
        /* 0x14C */ public float FullDamageRadius;
        [NMS(Index = 3)]
        /* 0x150 */ public float MaxRadius;
        [NMS(Index = 11)]
        /* 0x154 */ public int MaxStrikes;
        [NMS(Index = 2)]
        /* 0x158 */ public float MinRadius;
        [NMS(Index = 10)]
        /* 0x15C */ public int MinStrikes;
        [NMS(Index = 5)]
        /* 0x160 */ public float NumFlashes;
        [NMS(Index = 9)]
        /* 0x164 */ public float StormDuration;
    }
}
