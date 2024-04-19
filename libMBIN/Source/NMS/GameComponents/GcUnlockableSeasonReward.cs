using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDAF010C15889DC1D, NameHash = 0xC06F148BB67FE0E2)]
    public class GcUnlockableSeasonReward : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A SpecificMilestoneLoc;
        /* 0x20 */ public NMSString0x10 ID;
        /* 0x30 */ public List<int> SeasonIds;
        /* 0x40 */ public List<int> StageIds;
        /* 0x50 */ public bool MustBeUnlocked;
        /* 0x51 */ public bool SwitchExclusive;
        /* 0x52 */ public bool UniqueInventoryItem;
    }
}
