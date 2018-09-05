using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x88)]
    public class GcMissionSchedulingData : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate RecurrenceType;
        /* 0x48 */ public GcDate StartDate;
        /* 0x5C */ public GcDate EndDate;
        /* 0x70 */ public bool IndependentStart;
        /* 0x71 */ public bool HasEndDate;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x72 */ public byte[] Padding72;
        /* 0x78 */ public List<NMSString0x10> MissionIDs;
    }
}
