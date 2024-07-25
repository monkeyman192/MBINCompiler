using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC0029677C13AE6E, NameHash = 0xD7C08B15)]
    public class GcCombatEffectsTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcCombatEffectType.CombatEffectTypeEnum))]
        /* 0x0 */ public GcCombatEffectData[] EffectsData;
    }
}
