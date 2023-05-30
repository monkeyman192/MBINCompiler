using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcBeenShotEvent : NMSTemplate
    {
        public int ShotBy;
        public string[] ShotByValues()
        {
            return new[] { "Player", "Anything" };
        }

        public int DamageThreshold;
        public float HealthThreshold;
    }
}
