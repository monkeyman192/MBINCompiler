namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4263632D17FDFC6D, NameHash = 0xB865E9CD)]
    public class GcHazardDrainDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum HazardDrainDifficultyEnum : uint {
            Slow,
            Normal,
            Fast,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HazardDrainDifficultyEnum HazardDrainDifficulty;
    }
}
