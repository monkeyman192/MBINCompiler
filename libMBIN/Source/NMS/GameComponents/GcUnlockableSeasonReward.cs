using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDAF010C15889DC1D, NameHash = 0xC06F148BB67FE0E2)]
    public class GcUnlockableSeasonReward : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x20A SpecificMilestoneLoc;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ID;
        [NMS(Index = 4)]
        /* 0x30 */ public List<int> SeasonIds;
        [NMS(Index = 5)]
        /* 0x40 */ public List<int> StageIds;
        [NMS(Index = 1)]
        /* 0x50 */ public bool MustBeUnlocked;
        [NMS(Index = 3)]
        /* 0x51 */ public bool SwitchExclusive;
        [NMS(Index = 2)]
        /* 0x52 */ public bool UniqueInventoryItem;
    }
}
