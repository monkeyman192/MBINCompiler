using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24B9F5EACBDAE065, NameHash = 0x7C18FEA6826DCAF8)]
    public class GcCostGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Text;
        /* 0x20 */ public List<NMSTemplate> Costs;
        /* 0x30 */ public int HideOptionIfCantAffordIndex;
        /* 0x34 */ public int TakeTextFromIndex;
        /* 0x38 */ public GcMissionConditionTest Test;
    }
}
