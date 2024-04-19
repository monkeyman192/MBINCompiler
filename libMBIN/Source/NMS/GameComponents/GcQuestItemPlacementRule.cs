using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x753A9EED32FC4309, NameHash = 0xBA1C4B136F163FC8)]
    public class GcQuestItemPlacementRule : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MustBeAfterQuestItem;
        /* 0x10 */ public NMSString0x10 MustBeBeforeQuestItem;
        /* 0x20 */ public NMSString0x10 QuestItemID;
        /* 0x30 */ public List<NMSString0x10> ValidRoomIDs;
        /* 0x40 */ public int MaxRoomIndex;
        /* 0x44 */ public int MinRoomIndex;
    }
}
