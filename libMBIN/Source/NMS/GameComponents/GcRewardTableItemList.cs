using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xC184DE33DF65F7B3, NameHash = 0xF97DB1C704357E47)]
    public class GcRewardTableItemList : NMSTemplate
    {
		public enum RewardChoiceEnum { GiveAll, Select, SelectAlways, TryEach, SelectSilent, TryFirst_ThenSelectAlways, SelectFromSuccess }
		public RewardChoiceEnum RewardChoice;
        public bool OverrideZeroSeed;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding5;

        public List<GcRewardTableItem> List;
    }
}
