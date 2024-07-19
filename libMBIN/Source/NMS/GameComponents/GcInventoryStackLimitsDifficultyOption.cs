namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F13D862186143AB, NameHash = 0xB0ECA3FA)]
    public class GcInventoryStackLimitsDifficultyOption : NMSTemplate
    {
        // size: 0x3
        public enum InventoryStackLimitsDifficultyEnum : uint {
            High,
            Normal,
            Low,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryStackLimitsDifficultyEnum InventoryStackLimitsDifficulty;
    }
}
