namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA354D70279797182, NameHash = 0x5B21B72DF30D668C)]
    public class GcFrigateStatType : NMSTemplate
    {
        // size: 0xB
        public enum FrigateStatTypeEnum : uint {
            Combat,
            Exploration,
            Mining,
            Diplomatic,
            FuelBurnRate,
            FuelCapacity,
            Speed,
            ExtraLoot,
            Repair,
            Invulnerable,
            Stealth,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FrigateStatTypeEnum FrigateStatType;
    }
}
