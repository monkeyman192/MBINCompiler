using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2A4CED29CC453DF1, NameHash = 0xC06F148BB67FE0E2)]
    public class GcUnlockableSeasonReward : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public bool MustBeUnlocked;
        /* 0x11 */ public bool UniqueInventoryItem;
        /* 0x18 */ public List<int> SeasonIds;
        /* 0x28 */ public List<int> StageIds;
    }
}
