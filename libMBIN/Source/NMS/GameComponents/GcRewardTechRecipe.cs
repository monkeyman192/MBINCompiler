using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xD617C05A47C50112, NameHash = 0xAD73013CE22251D2)]
    public class GcRewardTechRecipe : NMSTemplate
    {
        public GcTechnologyCategory Category;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public NMSString0x10 RewardGroup;
    }
}
