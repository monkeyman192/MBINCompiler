namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61187D71A7849AFA, NameHash = 0x9B13C1A9)]
    public class GcPlayerWeaponClass : NMSTemplate
    {
        // size: 0x9
        public enum WeaponClassEnum : uint {
            None,
            Projectile,
            ChargedProjectile,
            Laser,
            Grenade,
            Utility,
            TerrainEditor,
            Spawner,
            SpawnerAlt,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WeaponClassEnum WeaponClass;
    }
}
