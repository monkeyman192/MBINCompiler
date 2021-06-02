using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x168, Alignment = 0x8, GUID = 0xF126BA8FB804DBA6, NameHash = 0xD85F7F00F1F64BD1)]
    public class GcWeatherHazardLightningData : NMSTemplate
    {
        /* 0x000 */ public TkModelResource IndicatorDecal;
        /* 0x084 */ public TkModelResource StaticDecal;
        /* 0x108 */ public float MinRadius;
        /* 0x10C */ public float MaxRadius;
        /* 0x110 */ public float DecalFullGrowthProgress;
        /* 0x114 */ public float NumFlashes;
        /* 0x118 */ public float FlashStartProgress;
        /* 0x11C */ public float EarliestImpact;
        /* 0x120 */ public float EarliestImpactFirstInstance;
        /* 0x124 */ public float StormDuration;
        /* 0x128 */ public int MinStrikes;
        /* 0x12C */ public int MaxStrikes;
        /* 0x130 */ public NMSString0x10 ShakeID;
        /* 0x140 */ public NMSString0x10 ImpactParticle;
        /* 0x150 */ public NMSString0x10 DamageID;
        /* 0x160 */ public float FullDamageRadius;
        /* 0x164 */ public float DamageRadius;
    }
}
