namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1D77A254B2256815, NameHash = 0xF404ECE05A6AC5B7)]
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
