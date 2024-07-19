namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF9C5E33D19947755, NameHash = 0xC8EE93CF)]
    public class GcAIShipWeapons : NMSTemplate
    {
        // size: 0x3
        public enum AIShipWeaponEnum : uint {
            Projectile,
            Laser,
            MiningLaser,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AIShipWeaponEnum AIShipWeapon;
    }
}
