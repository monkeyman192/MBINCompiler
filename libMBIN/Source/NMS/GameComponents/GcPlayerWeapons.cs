namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE69B1FFFEBFE9FD, NameHash = 0x8A17532BB2410967)]
    public class GcPlayerWeapons : NMSTemplate
    {
        // size: 0x13
        public enum WeaponModeEnum : uint {
            Bolt,
            Shotgun,
            Burst,
            Rail,
            Cannon,
            Laser,
            Grenade,
            MineGrenade,
            Scope,
            FrontShield,
            Melee,
            TerrainEdit,
            SunLaser,
            Spawner,
            SpawnerAlt,
            SoulLaser,
            Flamethrower,
            StunGrenade,
            Stealth,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WeaponModeEnum WeaponMode;
    }
}
