using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcProductCategory : NMSTemplate
    {
        public int ProductCategory;

        public string[] ProductCategoryValues()
        {
            return new[] { "Component", "Device", "Consumable", "Curiousity", "Generic", "None" };
        }
    }
}
