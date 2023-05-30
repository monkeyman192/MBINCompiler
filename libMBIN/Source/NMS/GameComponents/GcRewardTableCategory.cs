using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRewardTableCategory : NMSTemplate
    {
        public GcRewardTableItemList Small; // This actually is a GcRewardTableItemList[3], values are GcSizes
        public GcRewardTableItemList Medium;
        public GcRewardTableItemList Large;
    }
}
