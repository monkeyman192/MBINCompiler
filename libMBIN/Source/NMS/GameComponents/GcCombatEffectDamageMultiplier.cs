using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5EA00CEF7BC6D386, NameHash = 0xD755EBC8945CB867)]
    public class GcCombatEffectDamageMultiplier : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcCombatEffectType CombatEffectType;
        [NMS(Index = 1)]
        /* 0x4 */ public float DamageMultiplier;
    }
}
