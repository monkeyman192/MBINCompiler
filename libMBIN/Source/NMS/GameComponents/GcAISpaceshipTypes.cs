using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAISpaceshipTypes : NMSTemplate
    {
        public int ShipType;
        public string[] ShipTypeValues()
        {
            return new[] { "None", "Pirate", "Police", "Trader", "Freighter" };
        }
    }
}
