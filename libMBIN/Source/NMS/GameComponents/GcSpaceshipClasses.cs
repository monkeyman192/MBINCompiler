using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSpaceshipClasses : NMSTemplate
    {
        public int ShipClass;
        public string[] ShipClassValues()
        {
            return new[] { "Freighter", "Dropship", "Fighter", "Scientific", "Shuttle" };
        }
    }
}
