namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5B1EB7573A2AD22, NameHash = 0x5C4B812F)]
    public class GcMissionDifficulty : NMSTemplate
    {
        // size: 0x3
        public enum MissionDifficultyEnum : uint {
            Easy,
            Normal,
            Hard,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionDifficultyEnum MissionDifficulty;
    }
}
