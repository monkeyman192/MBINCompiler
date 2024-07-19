namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE494DB8A78148F1, NameHash = 0xF985B8FD)]
    public class GcReputationGainDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum ReputationGainDifficultyEnum : uint {
            VeryFast,
            Fast,
            Normal,
            Slow,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ReputationGainDifficultyEnum ReputationGainDifficulty;
    }
}
