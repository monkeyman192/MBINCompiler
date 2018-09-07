using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcRewardTableItemList : NMSTemplate        // size: 0x18
    {
		public enum RewardChoiceEnum { GiveAll, Select, SelectAlways, TryEach, SelectSilent, TryFirst_ThenSelectAlways }
		public RewardChoiceEnum RewardChoice;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;

        public List<GcRewardTableItem> List;
    }
}
