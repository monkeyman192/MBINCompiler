using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcTurretComponentData : NMSTemplate
    {
        public int GunType;
        public string[] GunTypeValues()
        {
            return new[] { "Laser", "Projectile" };
        }
    }
}
