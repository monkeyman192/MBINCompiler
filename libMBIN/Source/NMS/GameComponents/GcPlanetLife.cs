using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlanetLife : NMSTemplate
    {
        public int LifeSetting;
        public string[] LifeSettingValues()
        {
            return new[] { "Dead", "Low", "Mid", "Full" };
        }
    }
}
