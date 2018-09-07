namespace libMBIN.Models.Structs
{
    public class GcPlayerWeapons : NMSTemplate
    {
		public enum WeaponModeEnum { Bolt, Shotgun, Burst, Laser, Rail, Grenade, MineGrenade, Scope, FrontShield, TerrainEdit }
		public WeaponModeEnum WeaponMode;
    }
}
