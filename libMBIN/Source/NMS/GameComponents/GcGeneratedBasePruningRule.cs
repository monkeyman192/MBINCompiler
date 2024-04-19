using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x360C266CF8B4160B, NameHash = 0x37476C35069E0A8F)]
    public class GcGeneratedBasePruningRule : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 NodeName;
        /* 0x10 */ public List<NMSString0x10> RoomFilters;
        /* 0x20 */ public NMSString0x10 RuleId;
        /* 0x30 */ public int MaxPerDungeon;
        /* 0x34 */ public int MaxPerRoom;
    }
}
