using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRewardTechRecipe : NMSTemplate
    {
        public GcTechnologyCategory Category;
        public NMSString0x10 RewardGroup;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
