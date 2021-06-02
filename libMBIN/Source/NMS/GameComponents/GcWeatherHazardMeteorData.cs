using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x2F8, Alignment = 0x8, GUID = 0xD0BDC9CD22246DA2, NameHash = 0x89A5F03E5191DE14)]
    public class GcWeatherHazardMeteorData : NMSTemplate
    {
        /* 0x000 */ public TkModelResource IndicatorDecal;
        /* 0x084 */ public TkModelResource StaticDecal;
        /* 0x108 */ public TkModelResource Meteor;
        /* 0x18C */ public TkModelResource ImpactEffect;
        /* 0x210 */ public TkModelResource ImpactExplode;
        /* 0x294 */ public float MinRadius;
        /* 0x298 */ public float MaxRadius;
        /* 0x29C */ public float DecalFullGrowthProgress;
        /* 0x2A0 */ public float NumFlashes;
        /* 0x2A4 */ public float FlashStartProgress;
        /* 0x2A8 */ public float EarliestImpact;
        /* 0x2AC */ public float EarliestImpactFirstInstance;
        /* 0x2B0 */ public float StormDuration;
        /* 0x2B4 */ public float Speed;
        /* 0x2B8 */ public int MinMeteors;
        /* 0x2BC */ public int MaxMeteors;
        /* 0x2C0 */ public NMSString0x10 ShakeID;
        /* 0x2D0 */ public NMSString0x10 ImpactParticle;
        /* 0x2E0 */ public NMSString0x10 DamageID;
        /* 0x2F0 */ public float FullDamageRadius;
        /* 0x2F4 */ public float DamageRadius;
    }
}
