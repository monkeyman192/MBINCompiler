using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18D966A6F9263931, NameHash = 0xBED9F76732629FA0)]
    public class GcMissionConditionHasItemFromListOfValue : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ItemList;
        /* 0x10 */ public int UnitValue;
        /* 0x14 */ public bool UseDefaultAmount;
    }
}
