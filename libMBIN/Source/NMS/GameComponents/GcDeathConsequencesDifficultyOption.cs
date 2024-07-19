namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8CBB25AF0B05F86, NameHash = 0x117409BC)]
    public class GcDeathConsequencesDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum DeathConsequencesDifficultyEnum : uint {
            None,
            ItemGrave,
            DestroyItems,
            DestroySave,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DeathConsequencesDifficultyEnum DeathConsequencesDifficulty;
    }
}
