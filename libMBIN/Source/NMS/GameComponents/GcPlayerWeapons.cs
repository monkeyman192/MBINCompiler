using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xFFC81FAD5460B2C8, NameHash = 0x8A17532BB2410967)]
    public class GcPlayerWeapons : NMSTemplate
    {
        // 0xD entries
		public enum WeaponModeEnum { Bolt, Shotgun, Burst, Laser, Rail, Grenade, MineGrenade, Scope, FrontShield, TerrainEdit, SunLaser, SoulLaser, Flamethrower }
		public WeaponModeEnum WeaponMode;
    }
}