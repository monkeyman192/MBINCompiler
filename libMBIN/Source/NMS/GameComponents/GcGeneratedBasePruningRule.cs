using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0xBBF029EF1FAF3F10, NameHash = 0x37476C35069E0A8F)]
    public class GcGeneratedBasePruningRule : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RuleId;
        /* 0x10 */ public NMSString0x10 NodeName;
        /* 0x20 */ public int MaxPerRoom;
        /* 0x24 */ public int MaxPerDungeon;
        /* 0x28 */ public List<NMSString0x10> RoomFilters;
    }
}
