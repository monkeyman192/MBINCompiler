namespace libMBIN.Models.Structs
{
    public class GcPlayerWeapons : NMSTemplate
    {
        public int WeaponMode;
        public string[] WeaponModeValues()
        {
            return new[] { "Bolt", "Shotgun", "Burst", "Laser", "Rail", "Grenade", "MineGrenade", "Scope", "FrontShield", "TerrainEdit" };
        }
    }
}
