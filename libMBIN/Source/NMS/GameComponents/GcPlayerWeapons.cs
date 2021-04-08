using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x0, NameHash = 0x8A17532BB2410967)]
    public class GcPlayerWeapons : NMSTemplate
    {
        // 0xF entries
        public enum WeaponModeEnum {
            Bolt, Shotgun, Burst, Laser, Rail, Grenade, MineGrenade, Scope, FrontShield,
            TerrainEdit, SunLaser, Spawner, SpawnerAlt, SoulLaser, Flamethrower
        }
        public WeaponModeEnum WeaponMode;
    }
}