using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x8D8FF1F63382D33, NameHash = 0xCD0F83EA324443E1)]
    public class GcDamageType : NMSTemplate
    {
        // size: 0x15
        public enum DamageTypeEnum {
            Gun, Laser, Shotgun, Burst, Rail, Explosion, Melee, ShipGun, ShipLaser, ShipShotgun, ShipMinigun, ShipRockets,
            ShipPlasma, VehicleGun, VehicleLaser, SentinelLaser, PlayerDamage, PlayerWeapons, ShipWeapons, VehicleWeapons, 
            Fiend
        }
		public DamageTypeEnum DamageType;
    }
}