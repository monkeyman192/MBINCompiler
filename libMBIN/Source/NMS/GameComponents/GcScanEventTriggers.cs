using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB3BC8EED33D24F5, NameHash = 0xAFA73B31)]
    public class GcScanEventTriggers : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> Triggers;
        [NMS(Index = 0)]
        /* 0x10 */ public float Range;
        [NMS(Index = 2)]
        /* 0x14 */ public bool AllowRetrigger;
    }
}
