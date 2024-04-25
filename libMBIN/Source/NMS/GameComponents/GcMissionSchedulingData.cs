using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x28AEB8E606F98613, NameHash = 0xC7D1E140B3A1C6B2)]
    public class GcMissionSchedulingData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSTemplate RecurrenceType;
        [NMS(Index = 6)]
        /* 0x50 */ public List<NMSString0x10> MissionIDs;
        [NMS(Index = 5)]
        /* 0x60 */ public ulong EarlyEndOffset;
        [NMS(Index = 2)]
        /* 0x68 */ public GcDate EndDate;
        [NMS(Index = 1)]
        /* 0x7C */ public GcDate StartDate;
        [NMS(Index = 4)]
        /* 0x90 */ public bool HasEndDate;
        [NMS(Index = 3)]
        /* 0x91 */ public bool IndependentStart;
    }
}
