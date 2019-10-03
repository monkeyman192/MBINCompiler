using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x81FFE91EB711F5FD, NameHash = 0x3E6292A999E2A6)]
    public class GcStatsTypes : NMSTemplate
    {
        // size: 0x8B
		public enum StatsTypeEnum { Unspecified, Weapon_Laser, Weapon_Laser_Damage, Weapon_Laser_Mining_Speed, Weapon_Laser_HeatTime, Weapon_Laser_Bounce, Weapon_Laser_ReloadTime,
            Weapon_Laser_Recoil, Weapon_Laser_Drain, Weapon_Laser_StrongLaser, Weapon_Laser_ChargeTime, Weapon_Laser_MiningBonus, Weapon_Projectile, Weapon_Projectile_Damage,
            Weapon_Projectile_Range, Weapon_Projectile_Rate, Weapon_Projectile_ClipSize, Weapon_Projectile_ReloadTime, Weapon_Projectile_Recoil, Weapon_Projectile_Bounce,
            Weapon_Projectile_Homing, Weapon_Projectile_Dispersion, Weapon_Projectile_BulletsPerShot, Weapon_Projectile_MaximumCharge, Weapon_Rail, Weapon_Shotgun, Weapon_Burst,
            Weapon_Grenade, Weapon_Grenade_Damage, Weapon_Grenade_Radius, Weapon_Grenade_Speed, Weapon_Grenade_Bounce, Weapon_Grenade_Homing, Weapon_Grenade_Clusterbomb,
            Weapon_TerrainEdit, Weapon_MineGrenade, Weapon_FrontShield, Weapon_Scope, Weapon_Scan, Weapon_Scan_Radius, Weapon_Scan_Recharge_Time, Weapon_Scan_Types,
            Weapon_Scan_Binoculars, Weapon_Scan_Discovery_Creature, Weapon_Scan_Discovery_Flora, Weapon_Scan_Secondary, Weapon_Scan_Terrain_Resource, Weapon_Scan_Surveying,
            Suit_Armour_Health, Suit_Armour_Shield, Suit_Armour_Shield_Strength, Suit_Energy, Suit_Energy_Regen, Suit_Protection, Suit_Protection_Cold, Suit_Protection_Heat,
            Suit_Protection_Toxic, Suit_Protection_Radiation, Suit_Underwater, Suit_UnderwaterLifeSupport, Suit_DamageReduce_Cold, Suit_DamageReduce_Heat, Suit_DamageReduce_Toxic,
            Suit_DamageReduce_Radiation, Suit_Protection_HeatDrain, Suit_Protection_ColdDrain, Suit_Protection_ToxDrain, Suit_Protection_RadDrain, Suit_Protection_WaterDrain,
            Suit_Stamina_Strength, Suit_Stamina_Speed, Suit_Jetpack, Suit_Jetpack_Tank, Suit_Jetpack_Drain, Suit_Jetpack_Ignition, Suit_Jetpack_DoubleJump, Suit_Jetpack_WaterEfficiency,
            Suit_AutoTranslator, Suit_Utility, Ship_Weapons_Guns, Ship_Weapons_Guns_Damage, Ship_Weapons_Guns_Rate, Ship_Weapons_Guns_HeatTime, Ship_Weapons_Guns_CoolTime,
            Ship_Weapons_Guns_Scale, Ship_Weapons_Guns_BulletsPerShot, Ship_Weapons_Guns_Dispersion, Ship_Weapons_Guns_Range, Ship_Weapons_Guns_Damage_Radius, Ship_Weapons_Lasers,
            Ship_Weapons_Lasers_Damage, Ship_Weapons_Lasers_HeatTime, Ship_Weapons_Missiles, Ship_Weapons_Missiles_NumPerShot, Ship_Weapons_Missiles_Speed, Ship_Weapons_Missiles_Damage,
            Ship_Weapons_Missiles_Size, Ship_Weapons_Shotgun, Ship_Weapons_MiniGun, Ship_Weapons_Plasma, Ship_Weapons_Rockets, Ship_Armour_Shield, Ship_Armour_Shield_Strength,
            Ship_Armour_Health, Ship_Scan, Ship_Scan_EconomyFilter, Ship_Scan_ConflictFilter, Ship_Hyperdrive, Ship_Hyperdrive_JumpDistance, Ship_Hyperdrive_JumpsPerCell,
            Ship_Launcher, Ship_Launcher_TakeOffCost, Ship_Launcher_AutoCharge, Ship_PulseDrive, Ship_PulseDrive_MiniJumpFuelSpending, Ship_Boost, Ship_Maneuverability,
            Ship_BoostManeuverability, Ship_Teleport, Freighter_Hyperdrive, Freighter_Hyperdrive_JumpDistance, Vehicle_Boost, Vehicle_Engine, Vehicle_Scan, Vehicle_EngineFuelUse,
            Vehicle_EngineTopSpeed, Vehicle_BoostSpeed, Vehicle_BoostTanks, Vehicle_Grip, Vehicle_SkidGrip, Vehicle_SubBoostSpeed, Vehicle_Laser, Vehicle_LaserDamage,
            Vehicle_LaserHeatTime, Vehicle_LaserStrongLaser, Vehicle_Gun, Vehicle_GunDamage, Vehicle_GunHeatTime, Vehicle_GunRate }
        public StatsTypeEnum StatsType;
    }
}
