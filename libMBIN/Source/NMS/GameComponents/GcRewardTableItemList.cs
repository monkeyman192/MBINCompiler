using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B21604483DD7434, NameHash = 0xF97DB1C704357E47)]
    public class GcRewardTableItemList : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 IncrementStat;
        [NMS(Index = 4)]
        /* 0x10 */ public List<GcRewardTableItem> List;
        // size: 0xB
        public enum RewardChoiceEnum : uint {
            GiveAll,
            Select,
            SelectAlways,
            TryEach,
            SelectSilent,
            GiveAllSilent,
            TryFirst_ThenSelectAlways,
            GiveFirst_ThenAlsoSelectAlwaysFromRest,
            SelectFromSuccess,
            SelectAlwaysSilent,
            SelectFromSuccessSilent,
        }
        [NMS(Index = 0)]
        /* 0x20 */ public RewardChoiceEnum RewardChoice;
        [NMS(Index = 1)]
        /* 0x24 */ public bool OverrideZeroSeed;
        [NMS(Index = 2)]
        /* 0x25 */ public bool UseInventoryChoiceOverride;
    }
}
