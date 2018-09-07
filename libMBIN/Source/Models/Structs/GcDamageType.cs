namespace libMBIN.Models.Structs
{
    public class GcDamageType : NMSTemplate
    {
		public enum DamageTypeEnum { Gun, Laser, Shotgun, Burst, Rail, Explosion, Melee, ShipGun, ShipLaser, ShipShotgun, ShipMinigun, ShipRockets,
                                     ShipPlasma, VehicleGun, VehicleLaser, SentinelLaser, PlayerDamage, PlayerWeapons, ShipWeapons, VehicleWeapons }
		public DamageTypeEnum DamageType;
    }
}
