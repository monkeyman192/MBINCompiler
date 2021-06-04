using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x97D7978F3D97450A, NameHash = 0xCF538100E4D1C218)]
    public class GcRewardTableCategory : NMSTemplate
    {
        [NMS(Size = 0x3, EnumType = typeof(GcSizeIndicator.SizeIndicatorEnum))]
        public GcRewardTableItemList[] Sizes;
    }
}
