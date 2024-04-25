using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18D966A6F9263931, NameHash = 0xBED9F76732629FA0)]
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
