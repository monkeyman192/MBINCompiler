using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA8625B017954A5A, NameHash = 0x72F6D505CBF23F96)]
    public class GcSeasonalObjectiveOverrides : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A OverrideObjective;
        /* 0x20 */ public NMSString0x20A OverrideObjectiveTip;
        /* 0x40 */ public List<int> ApplicableSeasonNumbers;
    }
}
