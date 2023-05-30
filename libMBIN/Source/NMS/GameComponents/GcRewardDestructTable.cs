using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRewardDestructTable : NMSTemplate
    {
        [NMS(Size = 5)]
        public GcRewardDestructRarities[] Categories;
    }
}
