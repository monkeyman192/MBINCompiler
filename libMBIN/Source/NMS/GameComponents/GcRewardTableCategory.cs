using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE71AE7672337254C, NameHash = 0xCF538100E4D1C218)]
    public class GcRewardTableCategory : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcSizeIndicator.SizeIndicatorEnum))]
        public GcRewardTableItemList[] Sizes;
    }
}
