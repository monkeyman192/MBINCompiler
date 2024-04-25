namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD86131FEFF826FFC, NameHash = 0x2B740202A0E2CC57)]
    public class GcCreatureHostilityDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum CreatureHostilityDifficultyEnum : uint {
            NeverAttack,
            AttackIfProvoked,
            FullEcosystem,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureHostilityDifficultyEnum CreatureHostilityDifficulty;
    }
}
