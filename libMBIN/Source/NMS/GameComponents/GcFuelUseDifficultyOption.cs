namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16E68CFACEBF2BA6, NameHash = 0xEAE2666F)]
    public class GcFuelUseDifficultyOption : NMSTemplate
    {
        // size: 0x4
        public enum FuelUseDifficultyEnum : uint {
            Free,
            Cheap,
            Normal,
            Expensive,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FuelUseDifficultyEnum FuelUseDifficulty;
    }
}
