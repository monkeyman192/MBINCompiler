using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D274E737EA18C13, NameHash = 0x89A5F03E5191DE14)]
    public class GcWeatherHazardMeteorData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 DamageID;
        /* 0x010 */ public NMSString0x10 ImpactParticle;
        /* 0x020 */ public NMSString0x10 ShakeID;
        /* 0x030 */ public TkModelResource ImpactEffect;
        /* 0x0B4 */ public TkModelResource ImpactExplode;
        /* 0x138 */ public TkModelResource IndicatorDecal;
        /* 0x1BC */ public TkModelResource Meteor;
        /* 0x240 */ public TkModelResource StaticDecal;
        /* 0x2C4 */ public float DamageRadius;
        /* 0x2C8 */ public float DecalFullGrowthProgress;
        /* 0x2CC */ public float EarliestImpact;
        /* 0x2D0 */ public float EarliestImpactFirstInstance;
        /* 0x2D4 */ public float FlashStartProgress;
        /* 0x2D8 */ public float FullDamageRadius;
        /* 0x2DC */ public int MaxMeteors;
        /* 0x2E0 */ public float MaxRadius;
        /* 0x2E4 */ public int MinMeteors;
        /* 0x2E8 */ public float MinRadius;
        /* 0x2EC */ public float NumFlashes;
        /* 0x2F0 */ public float Speed;
        /* 0x2F4 */ public float StormDuration;
    }
}
