using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSolarSystemClass : NMSTemplate
    {
        public int SolarSystemClass;
        public string[] SolarSystemClassValues()
        {
            return new[] { "Default", "Initial", "Anomaly", "GameStart" };
        }
    }
}
