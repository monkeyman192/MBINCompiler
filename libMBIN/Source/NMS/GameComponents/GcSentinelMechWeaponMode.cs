namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1D77A254B2256815, NameHash = 0x611210D4)]
    public class GcSentinelMechWeaponMode : NMSTemplate
    {
        // size: 0x3
        public enum SentinelMechWeaponModeEnum : uint {
            Gun,
            Canon,
            Flamethrower,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SentinelMechWeaponModeEnum SentinelMechWeaponMode;
    }
}
