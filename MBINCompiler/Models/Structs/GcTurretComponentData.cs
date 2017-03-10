namespace MBINCompiler.Models.Structs
{
    public class GcTurretComponentData : NMSTemplate
    {
        public int GunType;
        public string[] GunTypeValues()
        {
            return new[] { "Laser", "Projectile", "Missile" };
        }
    }
}
