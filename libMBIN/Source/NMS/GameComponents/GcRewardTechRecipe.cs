using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD617C05A47C50112, NameHash = 0xAD73013CE22251D2)]
    public class GcRewardTechRecipe : NMSTemplate
    {
        public GcTechnologyCategory Category;
        public NMSString0x10 RewardGroup;
    }
}
