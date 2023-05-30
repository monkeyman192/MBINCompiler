using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRealitySubstanceCategory : NMSTemplate
    {
        public int SubstanceCategory;

        public string[] SubstanceCategoryValues()
        {
            return new[] { "Commodity", "Technology", "Fuel", "Tradeable", "Special", "None" };
        }
    }
}
