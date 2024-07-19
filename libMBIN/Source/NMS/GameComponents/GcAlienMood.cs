namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24CC01D94B6A1C1B, NameHash = 0x66CF327A)]
    public class GcAlienMood : NMSTemplate
    {
        // size: 0x9
        public enum MoodEnum : uint {
            Neutral,
            Positive,
            VeryPositive,
            Negative,
            VeryNegative,
            Pity,
            Sad,
            Dead,
            Confused,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MoodEnum Mood;
    }
}
