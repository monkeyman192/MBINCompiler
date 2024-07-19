using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x51B81BA08A2141A6, NameHash = 0x2C5D102E)]
    public class GcCombatEffectDamageMultiplier : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcCombatEffectType CombatEffectType;
        [NMS(Index = 1)]
        /* 0x4 */ public float DamageMultiplier;
    }
}
