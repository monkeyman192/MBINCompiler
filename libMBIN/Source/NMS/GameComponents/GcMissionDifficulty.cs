namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5B1EB7573A2AD22, NameHash = 0x81EBB5E64823914E)]
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
