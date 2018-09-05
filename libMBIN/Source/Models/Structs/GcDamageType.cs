namespace libMBIN.Models.Structs
{
    public class GcDamageType : NMSTemplate
    {
        public int DamageType;
        public string[] DamageTypeValues()
        {
            return new[]
            {
                "Gun", "Laser", "Shotgun", "Burst", "Rail", "Explosion", "Melee", "ShipGun",
                "ShipLaser", "ShipShotgun", "ShipMinigun", "ShipRockets", "ShipPlasma", "VehicleGun",
                "VehicleLaser", "SentinelLaser", "PlayerDamage", "PlayerWeapons", "ShipWeapons", "VehicleWeapons"
            };
        }
    }
}
