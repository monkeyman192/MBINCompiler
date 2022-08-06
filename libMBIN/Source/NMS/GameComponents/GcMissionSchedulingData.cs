using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7EEFA78A53AECF66, NameHash = 0xC7D1E140B3A1C6B2)]
    public class GcMissionSchedulingData : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate RecurrenceType;
        /* 0x50 */ public GcDate StartDate;
        /* 0x64 */ public GcDate EndDate;
        /* 0x78 */ public bool IndependentStart;
        /* 0x79 */ public bool HasEndDate;
        /* 0x80 */ public ulong EarlyEndOffset;
        /* 0x88 */ public List<NMSString0x10> MissionIDs;
    }
}
