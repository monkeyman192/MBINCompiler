using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, Alignment = 0x8, GUID = 0x238BE3BAF7E6379B, NameHash = 0xB457288101712FB5)]
    public class GcGenericRewardTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcRewardTableItemList List;
    }
}