using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99555AB6DEA170E8, NameHash = 0x1C862912)]
    public class GcCombatEffectsComponentData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcCombatEffectType.CombatEffectTypeEnum))]
        /* 0x0 */ public GcCombatEffectsProperties[] EffectsProperties;
    }
}
