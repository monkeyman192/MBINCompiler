using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB66CB6E7E0D4B11A, NameHash = 0x3213D59A0301372C)]
    public class GcImpactCombatEffectData : NMSTemplate
    {
        /* 0x0 */ public GcCombatEffectType CombatEffectType;
        /* 0x4 */ public float CurrentDuration;
        /* 0x8 */ public float DamagePerSeccond;
        /* 0xC */ public float TotalDuration;
    }
}
