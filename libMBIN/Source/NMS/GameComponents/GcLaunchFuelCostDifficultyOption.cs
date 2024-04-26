namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6DA718B3683C3F52, NameHash = 0xB8138F7D4F230C2B)]
    public class GcLaunchFuelCostDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum LaunchFuelCostDifficultyEnum : uint {
            Free,
            Low,
            Normal,
            High,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LaunchFuelCostDifficultyEnum LaunchFuelCostDifficulty;
    }
}
