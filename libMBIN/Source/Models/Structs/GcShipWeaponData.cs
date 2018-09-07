namespace libMBIN.Models.Structs
{
    public class GcShipWeaponData : NMSTemplate
    {
		public enum ShipWeaponEnum { Laser, Projectile, Shotgun, Minigun, Plasma, Missile, Rocket }
		public ShipWeaponEnum ShipWeapon;
    }
}
