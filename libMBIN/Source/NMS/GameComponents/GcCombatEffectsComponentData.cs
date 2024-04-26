using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A3EA8ABB3E5F243, NameHash = 0x74FCF5B2A55D262B)]
    public class GcCombatEffectsComponentData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcCombatEffectType.CombatEffectTypeEnum))]
        /* 0x0 */ public GcCombatEffectsProperties[] EffectsProperties;
    }
}
