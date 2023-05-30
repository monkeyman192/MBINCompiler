using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCostInstalledTech : NMSTemplate
    {
        public NMSString0x10 Id;
		
        public int InvetoryToCheck;
        public string[] InventoryToCheckValues()
        {
            return new[] { "All", "Suit", "Ship", "Weapon", "Freighter", "Buggy" };
        }
    }
}
