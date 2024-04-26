using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x753A9EED32FC4309, NameHash = 0xBA1C4B136F163FC8)]
    public class GcQuestItemPlacementRule : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x10 MustBeAfterQuestItem;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 MustBeBeforeQuestItem;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 QuestItemID;
        [NMS(Index = 5)]
        /* 0x30 */ public List<NMSString0x10> ValidRoomIDs;
        [NMS(Index = 2)]
        /* 0x40 */ public int MaxRoomIndex;
        [NMS(Index = 1)]
        /* 0x44 */ public int MinRoomIndex;
    }
}
