using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3538278A8E16FB3B, NameHash = 0xEE47CB18)]
    public class GcScanEventTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcScanEventData> Events;
    }
}
