namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB2CC5E20D1D2FA20, NameHash = 0x56E5415F)]
    public class GcSprintingCostDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum SprintingCostDifficultyEnum : uint {
            Free,
            Low,
            Full,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SprintingCostDifficultyEnum SprintingCostDifficulty;
    }
}
