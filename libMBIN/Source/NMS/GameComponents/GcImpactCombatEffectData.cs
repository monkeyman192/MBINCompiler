using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DBB07A333087833, NameHash = 0x3213D59A0301372C)]
    public class GcImpactCombatEffectData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcCombatEffectType CombatEffectType;
        [NMS(Index = 3)]
        /* 0x4 */ public float CurrentDuration;
        [NMS(Index = 2)]
        /* 0x8 */ public float DamagePerSeccond;
        [NMS(Index = 1)]
        /* 0xC */ public float TotalDuration;
    }
}
