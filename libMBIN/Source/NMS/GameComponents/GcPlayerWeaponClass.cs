namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA52A0811C2FBB69, NameHash = 0x9B13C1A9)]
    public class GcPlayerWeaponClass : NMSTemplate
    {
        // size: 0xA
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
            Fishing,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WeaponClassEnum WeaponClass;
    }
}
