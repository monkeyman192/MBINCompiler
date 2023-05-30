using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSolarSystemLocatorTypes : NMSTemplate
    {
        public int LocatorType;
        public string[] LocatorTypeValues()
        {
            return new[] { "Generic1", "Generic2", "Generic3", "Generic4" };
        }
    }
}
