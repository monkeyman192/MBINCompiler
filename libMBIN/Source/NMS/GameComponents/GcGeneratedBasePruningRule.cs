using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6AEF90D0864A8522, NameHash = 0x22A0CBE)]
    public class GcGeneratedBasePruningRule : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 NodeName;
        [NMS(Index = 4)]
        /* 0x10 */ public List<NMSString0x10> RoomFilters;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 RuleId;
        [NMS(Index = 3)]
        /* 0x30 */ public int MaxPerDungeon;
        [NMS(Index = 2)]
        /* 0x34 */ public int MaxPerRoom;
    }
}
