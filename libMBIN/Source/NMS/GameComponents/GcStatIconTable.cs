using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3700, GUID = 0x1E0206B2601F3050, NameHash = 0x266F5269ED2C5661)]
    public class GcStatIconTable : NMSTemplate
    {
        // near match to GcStatsTypes.StatsTypeEnum
        [NMS(Size = 0x6E, EnumValue = new[] { "Unspecified", "Weapon_Laser", "Weapon_Laser_Damage", "Weapon_Laser_Mining_Speed", "Weapon_Laser_HeatTime",
                "Weapon_Laser_Bounce", "Weapon_Laser_ReloadTime", "Weapon_Laser_Recoil", "Weapon_Laser_Drain", "Weapon_Laser_StrongLaser",
                "Weapon_Laser_ChargeTime", "Weapon_Projectile", "Weapon_Projectile_Damage", "Weapon_Projectile_Range", "Weapon_Projectile_Rate",
                "Weapon_Projectile_ClipSize", "Weapon_Projectile_ReloadTime", "Weapon_Projectile_Recoil", "Weapon_Projectile_Bounce",
                "Weapon_Projectile_Homing", "Weapon_Projectile_Dispersion", "Weapon_Projectile_BulletsPerShot", "Weapon_Projectile_MaximumCharge",
                "Weapon_Rail", "Weapon_Shotgun", "Weapon_Burst", "Weapon_Grenade", "Weapon_Grenade_Damage", "Weapon_Grenade_Radius",
                "Weapon_Grenade_Speed", "Weapon_Grenade_Bounce", "Weapon_Grenade_Homing", "Weapon_Grenade_Clusterbomb", "Weapon_TerrainEdit",
                "Weapon_MineGrenade", "Weapon_FrontShield", "Weapon_Scope", "Weapon_Scan", "Weapon_Scan_Radius", "Weapon_Scan_Recharge_Time",
                "Weapon_Scan_Types", "Weapon_Scan_Binoculars", "Weapon_Scan_Discovery_Creature", "Weapon_Scan_Discovery_Flora",
                "Weapon_Scan_Secondary", "Weapon_Scan_Terrain_Resource", "Suit_Armour_Health", "Suit_Armour_Shield", "Suit_Armour_Shield_Strength",
                "Suit_Energy", "Suit_Energy_Regen", "Suit_Protection", "Suit_Protection_Cold", "Suit_Protection_Heat", "Suit_Protection_Toxic",
                "Suit_Protection_Radiation", "Suit_Underwater", "Suit_DamageReduce_Cold", "Suit_DamageReduce_Heat", "Suit_DamageReduce_Toxic",
                "Suit_DamageReduce_Radiation", "Suit_Stamina_Strength", "Suit_Stamina_Speed", "Suit_Jetpack", "Suit_Jetpack_Tank",
                "Suit_Jetpack_Drain", "Suit_Jetpack_Ignition", "Suit_Jetpack_DoubleJump", "Suit_Utility", "Ship_Weapons_Guns",
                "Ship_Weapons_Guns_Damage", "Ship_Weapons_Guns_Rate", "Ship_Weapons_Guns_HeatTime", "Ship_Weapons_Guns_CoolTime",
                "Ship_Weapons_Guns_Scale", "Ship_Weapons_Guns_BulletsPerShot", "Ship_Weapons_Guns_Dispersion", "Ship_Weapons_Guns_Range",
                "Ship_Weapons_Guns_Damage_Radius", "Ship_Weapons_Lasers", "Ship_Weapons_Lasers_Damage", "Ship_Weapons_Lasers_HeatTime",
                "Ship_Weapons_Missiles", "Ship_Weapons_Missiles_NumPerShot", "Ship_Weapons_Missiles_Speed", "Ship_Weapons_Missiles_Damage",
                "Ship_Weapons_Missiles_Size", "Ship_Weapons_Shotgun", "Ship_Weapons_MiniGun", "Ship_Weapons_Plasma", "Ship_Weapons_Rockets",
                "Ship_Armour_Shield", "Ship_Armour_Shield_Strength", "Ship_Armour_Health", "Ship_Scan", "Ship_Scan_EconomyFilter",
                "Ship_Scan_ConflictFilter", "Ship_Hyperdrive", "Ship_Hyperdrive_JumpDistance", "Ship_Hyperdrive_JumpsPerCell", "Ship_Launcher",
                "Ship_Launcher_TakeOffCost", "Ship_PulseDrive", "Ship_PulseDrive_MiniJumpFuelSpending", "Ship_Boost", "Ship_Maneuverability",
                "Ship_BoostManeuverability", "Ship_Teleport", "Freighter_Hyperdrive", "Freighter_Hyperdrive_JumpDistance" })]
        public NMSString0x80[] StatIcons;
    }
}
