using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFFDDB1E3BEFE213, NameHash = 0xF3C887AE)]
    public class GcMissionConditionHasItemFromListOfValue : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<NMSString0x10> ItemList;
        [NMS(Index = 0)]
        /* 0x10 */ public int UnitValue;
        [NMS(Index = 1)]
        /* 0x14 */ public bool UseDefaultAmount;
    }
}
