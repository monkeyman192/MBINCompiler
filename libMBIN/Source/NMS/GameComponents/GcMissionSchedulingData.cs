using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB92108D02CE8D5C, NameHash = 0x4AD14EFF)]
    public class GcMissionSchedulingData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public List<NMSString0x10> MissionIDs;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSTemplate RecurrenceType;
        [NMS(Index = 5)]
        /* 0x20 */ public ulong EarlyEndOffset;
        [NMS(Index = 2)]
        /* 0x28 */ public GcDate EndDate;
        [NMS(Index = 1)]
        /* 0x3C */ public GcDate StartDate;
        [NMS(Index = 4)]
        /* 0x50 */ public bool HasEndDate;
        [NMS(Index = 3)]
        /* 0x51 */ public bool IndependentStart;
    }
}
