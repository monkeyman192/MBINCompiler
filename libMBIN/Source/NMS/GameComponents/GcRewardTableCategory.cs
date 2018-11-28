using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x7AFC0217BE7184F9)]
    public class GcRewardTableCategory : NMSTemplate
    {
        [NMS( EnumType = typeof( GcSizeIndicator.SizeIndicatorEnum ) )] // not sure if this enum is correct but it works for now
        public GcRewardTableItemList[] Sizes;
    }
}
