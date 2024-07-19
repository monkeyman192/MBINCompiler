namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97CA318EDCC4FB02, NameHash = 0xAD1B48A9)]
    public class GcDamageType : NMSTemplate
    {
        // size: 0x19
        public enum DamageTypeEnum : uint {
            Gun,
            Laser,
            Shotgun,
            Burst,
            Rail,
            Cannon,
            Explosion,
            Melee,
            ShipGun,
            ShipLaser,
            ShipShotgun,
            ShipMinigun,
            ShipRockets,
            ShipPlasma,
            VehicleGun,
            VehicleLaser,
            SentinelLaser,
            PlayerDamage,
            PlayerWeapons,
            ShipWeapons,
            VehicleWeapons,
            CombatEffects,
            Fiend,
            FreighterLaser,
            FreighterTorpedo,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DamageTypeEnum DamageType;
    }
}
