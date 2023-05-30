using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRewardTableItemList : NMSTemplate
    {
        public bool EntitlementLinked;
        public NMSString0x20 EntitlementId;
        public int RewardChoice;
        public string[] RewardChoiceValues()
        {
            return new[] { "GiveAll", "Select", "TryEach" };
        }

        public List<GcRewardTableItem> List;
    }
}
