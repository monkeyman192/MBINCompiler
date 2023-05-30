using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRewardTableItem : NMSTemplate
    {
        public float PercentageChance;
        public NMSTemplate Reward; // Generic
        public NMSString0x40 LabelID;
    }
}
