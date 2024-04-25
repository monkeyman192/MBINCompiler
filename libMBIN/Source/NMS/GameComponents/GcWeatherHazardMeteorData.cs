using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D274E737EA18C13, NameHash = 0x89A5F03E5191DE14)]
    public class GcWeatherHazardMeteorData : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x000 */ public NMSString0x10 DamageID;
        [NMS(Index = 17)]
        /* 0x010 */ public NMSString0x10 ImpactParticle;
        [NMS(Index = 16)]
        /* 0x020 */ public NMSString0x10 ShakeID;
        [NMS(Index = 3)]
        /* 0x030 */ public TkModelResource ImpactEffect;
        [NMS(Index = 4)]
        /* 0x0B4 */ public TkModelResource ImpactExplode;
        [NMS(Index = 0)]
        /* 0x138 */ public TkModelResource IndicatorDecal;
        [NMS(Index = 2)]
        /* 0x1BC */ public TkModelResource Meteor;
        [NMS(Index = 1)]
        /* 0x240 */ public TkModelResource StaticDecal;
        [NMS(Index = 20)]
        /* 0x2C4 */ public float DamageRadius;
        [NMS(Index = 7)]
        /* 0x2C8 */ public float DecalFullGrowthProgress;
        [NMS(Index = 10)]
        /* 0x2CC */ public float EarliestImpact;
        [NMS(Index = 11)]
        /* 0x2D0 */ public float EarliestImpactFirstInstance;
        [NMS(Index = 9)]
        /* 0x2D4 */ public float FlashStartProgress;
        [NMS(Index = 19)]
        /* 0x2D8 */ public float FullDamageRadius;
        [NMS(Index = 15)]
        /* 0x2DC */ public int MaxMeteors;
        [NMS(Index = 6)]
        /* 0x2E0 */ public float MaxRadius;
        [NMS(Index = 14)]
        /* 0x2E4 */ public int MinMeteors;
        [NMS(Index = 5)]
        /* 0x2E8 */ public float MinRadius;
        [NMS(Index = 8)]
        /* 0x2EC */ public float NumFlashes;
        [NMS(Index = 13)]
        /* 0x2F0 */ public float Speed;
        [NMS(Index = 12)]
        /* 0x2F4 */ public float StormDuration;
    }
}
