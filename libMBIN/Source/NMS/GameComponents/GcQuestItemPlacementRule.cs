using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0xD3753EC3463891, NameHash = 0xBA1C4B136F163FC8)]
    public class GcQuestItemPlacementRule : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string QuestItemID;
        /* 0x10 */ public int MinRoomIndex;
        /* 0x14 */ public int MaxRoomIndex;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string MustBeBeforeQuestItem;
        [NMS(Size = 0x10)]
        /* 0x28 */ public string MustBeAfterQuestItem;
        /* 0x38 */ public List<NMSString0x10> ValidRoomsIDs;
    }
}
