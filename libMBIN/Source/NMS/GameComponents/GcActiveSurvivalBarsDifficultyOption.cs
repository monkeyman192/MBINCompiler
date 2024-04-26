namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x63F32414B145C38C, NameHash = 0x96CF7C217D988FDF)]
    public class GcActiveSurvivalBarsDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum ActiveSurvivalBarsDifficultyEnum : uint {
            None,
            HealthOnly,
            HealthAndHazard,
            All,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ActiveSurvivalBarsDifficultyEnum ActiveSurvivalBarsDifficulty;
    }
}
