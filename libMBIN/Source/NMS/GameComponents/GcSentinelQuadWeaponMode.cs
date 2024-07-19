namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEDC79F40DC21B1A3, NameHash = 0x34C84B37)]
    public class GcSentinelQuadWeaponMode : NMSTemplate
    {
        // size: 0x4
        public enum SentinelQuadWeaponModeEnum : uint {
            Laser,
            MiniCannon,
            Grenades,
            Flamethrower,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SentinelQuadWeaponModeEnum SentinelQuadWeaponMode;
    }
}
