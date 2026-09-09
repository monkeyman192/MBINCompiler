using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C11B9066756E3B7, NameHash = 0xD7C08B15)]
    public class GcCombatEffectsTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x6, EnumType = typeof(GcCombatEffectType.CombatEffectTypeEnum))]
        /* 0x0 */ public GcCombatEffectData[] EffectsData;
    }
}
