using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B5665F2048F43D3, NameHash = 0x72F6D505CBF23F96)]
    public class GcSeasonalObjectiveOverrides : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A OverrideObjective;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A OverrideObjectiveTip;
        [NMS(Index = 0)]
        /* 0x40 */ public List<int> ApplicableSeasonNumbers;
    }
}
