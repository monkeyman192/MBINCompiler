using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0A1A6954120358E, NameHash = 0xA3D1786E)]
    public class GcWeatherHazardMeteorData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public TkModelResource ImpactEffect;
        [NMS(Index = 4)]
        /* 0x18 */ public TkModelResource ImpactExplode;
        [NMS(Index = 0)]
        /* 0x30 */ public TkModelResource IndicatorDecal;
        [NMS(Index = 2)]
        /* 0x48 */ public TkModelResource Meteor;
        [NMS(Index = 1)]
        /* 0x60 */ public TkModelResource StaticDecal;
        [NMS(Index = 18)]
        /* 0x78 */ public NMSString0x10 DamageID;
        [NMS(Index = 17)]
        /* 0x88 */ public NMSString0x10 ImpactParticle;
        [NMS(Index = 16)]
        /* 0x98 */ public NMSString0x10 ShakeID;
        [NMS(Index = 20)]
        /* 0xA8 */ public float DamageRadius;
        [NMS(Index = 7)]
        /* 0xAC */ public float DecalFullGrowthProgress;
        [NMS(Index = 10)]
        /* 0xB0 */ public float EarliestImpact;
        [NMS(Index = 11)]
        /* 0xB4 */ public float EarliestImpactFirstInstance;
        [NMS(Index = 9)]
        /* 0xB8 */ public float FlashStartProgress;
        [NMS(Index = 19)]
        /* 0xBC */ public float FullDamageRadius;
        [NMS(Index = 15)]
        /* 0xC0 */ public int MaxMeteors;
        [NMS(Index = 6)]
        /* 0xC4 */ public float MaxRadius;
        [NMS(Index = 14)]
        /* 0xC8 */ public int MinMeteors;
        [NMS(Index = 5)]
        /* 0xCC */ public float MinRadius;
        [NMS(Index = 8)]
        /* 0xD0 */ public float NumFlashes;
        [NMS(Index = 13)]
        /* 0xD4 */ public float Speed;
        [NMS(Index = 12)]
        /* 0xD8 */ public float StormDuration;
    }
}
