namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4263632D17FDFC6D, NameHash = 0x56BC170774FBDFB4)]
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
