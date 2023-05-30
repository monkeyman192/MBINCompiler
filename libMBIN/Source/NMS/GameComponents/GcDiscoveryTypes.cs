using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcDiscoveryTypes : NMSTemplate
    {
        public int DiscoveryType;
        public string[] DiscoveryTypeValues()
        {
            return new[] { "Unknown", "SolarSystem", "Planet", "Animal", "Flora", "Mineral", "Sector" };
        }
    }
}
