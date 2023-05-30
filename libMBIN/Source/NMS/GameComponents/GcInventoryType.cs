using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcInventoryType : NMSTemplate
    {
        public int InventoryType; // Substance / Technology / Product

        public string[] InventoryTypeValues()
        {
            return new[] { "Substance", "Technology", "Product" };
        }
    }
}
