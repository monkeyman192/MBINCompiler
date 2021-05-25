using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x38, GUID = 0x2A4CED29CC453DF1, NameHash = 0xC06F148BB67FE0E2)]
    public class GcUnlockableSeasonReward : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        /* 0x10 */ public bool MustBeUnlocked;
        /* 0x11 */ public bool UniqueInventoryItem;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x12 */ public byte[] Padding12;
        /* 0x18 */ public List<int> SeasonIds;
        /* 0x28 */ public List<int> StageIds;
    }
}
