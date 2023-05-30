using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcTechnologyRarity : NMSTemplate
    {
        public int TechnologyRarity;

        public string[] TechnologyRarityValues()
        {
            return new[] { "Normal", "VeryCommon", "Common", "Rare", "VeryRare", "Impossible", "Always" };
        }
    }
}
