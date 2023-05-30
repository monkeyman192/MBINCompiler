using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcTechnologyCategory : NMSTemplate
    {
        public int TechnologyCategory;

        public string[] TechnologyCategoryValues()
        {
            return new[] { "Ship", "Weapon", "Suit", "Personal", "All", "None", "Freighter", "Buggy"};
        }
    }
}
