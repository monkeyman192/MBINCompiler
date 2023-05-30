using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRewardTableEntry : NMSTemplate
    {
        public NMSString0x10 Id;
        public GcRewardTableCategory Common; // This actually is a GcRewardTableCategory[3], values are GcRarity
        public GcRewardTableCategory Uncommon;
        public GcRewardTableCategory Rare;
    }
}
