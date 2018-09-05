using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcRewardTableItemList : NMSTemplate        // size: 0x18
    {
        public int RewardChoice;
        public string[] RewardChoiceValues()
        {
            return new[] { "GiveAll", "Select", "SelectAlways", "TryEach", "SelectSilent", "TryFirst_ThenSelectAlways" };
        }
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;

        public List<GcRewardTableItem> List;
    }
}
