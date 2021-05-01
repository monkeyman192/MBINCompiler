using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x013650E578344063, NameHash = 0xF97DB1C704357E47)]
    public class GcRewardTableItemList : NMSTemplate
    {
        // 0x8 entries
        public enum RewardChoiceEnum { GiveAll, Select, SelectAlways, TryEach, SelectSilent, GiveAllSilent,
            TryFirst_ThenSelectAlways, SelectFromSuccess
        }
        public RewardChoiceEnum RewardChoice;
        public bool OverrideZeroSeed;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding5;
        public List<GcRewardTableItem> List;
    }
}
