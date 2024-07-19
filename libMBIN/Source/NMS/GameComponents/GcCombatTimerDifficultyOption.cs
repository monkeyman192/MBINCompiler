namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39060AAC417BAD2A, NameHash = 0xAD500621)]
    public class GcCombatTimerDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum CombatTimerDifficultyOptionEnum : uint {
            Off,
            Slow,
            Normal,
            Fast,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CombatTimerDifficultyOptionEnum CombatTimerDifficultyOption;
    }
}
