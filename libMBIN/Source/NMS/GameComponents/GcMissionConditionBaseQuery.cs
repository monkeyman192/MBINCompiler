using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C151ED0BBB872BA, NameHash = 0xDAD32FDD35922F28)]
    public class GcMissionConditionBaseQuery : NMSTemplate
    {
        /* 0x00 */ public GcBaseSearchFilter BaseSearchFilter;
        /* 0x98 */ public int MinBasesFound;
        /* 0x9C */ public int MaxBasesFound;
        /* 0xA0 */ public float SearchDistanceLimit;
        /* 0xA4 */ public bool TakeSpecificPartIdFromSeasonData;
    }
}
