using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0xD3753EC3463891, NameHash = 0xBA1C4B136F163FC8)]
    public class GcQuestItemPlacementRule : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 QuestItemID;
        /* 0x10 */ public int MinRoomIndex;
        /* 0x14 */ public int MaxRoomIndex;
        /* 0x18 */ public NMSString0x10 MustBeBeforeQuestItem;
        /* 0x28 */ public NMSString0x10 MustBeAfterQuestItem;
        /* 0x38 */ public List<NMSString0x10> ValidRoomsIDs;
    }
}
