using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC42BA76B22AFE894, NameHash = 0xD85F7F00F1F64BD1)]
    public class GcWeatherHazardLightningData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 DamageID;
        /* 0x010 */ public NMSString0x10 ImpactParticle;
        /* 0x020 */ public NMSString0x10 ShakeID;
        /* 0x030 */ public TkModelResource IndicatorDecal;
        /* 0x0B4 */ public TkModelResource StaticDecal;
        /* 0x138 */ public float DamageRadius;
        /* 0x13C */ public float DecalFullGrowthProgress;
        /* 0x140 */ public float EarliestImpact;
        /* 0x144 */ public float EarliestImpactFirstInstance;
        /* 0x148 */ public float FlashStartProgress;
        /* 0x14C */ public float FullDamageRadius;
        /* 0x150 */ public float MaxRadius;
        /* 0x154 */ public int MaxStrikes;
        /* 0x158 */ public float MinRadius;
        /* 0x15C */ public int MinStrikes;
        /* 0x160 */ public float NumFlashes;
        /* 0x164 */ public float StormDuration;
    }
}
