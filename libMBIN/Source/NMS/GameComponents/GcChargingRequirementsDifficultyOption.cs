namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF94E671711FD8656, NameHash = 0x5F6767A5FB0B2FEA)]
    public class GcChargingRequirementsDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum ChargingRequirementsDifficultyEnum : uint {
            None,
            Low,
            Normal,
            High,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ChargingRequirementsDifficultyEnum ChargingRequirementsDifficulty;
    }
}
