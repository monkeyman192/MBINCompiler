using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCEF281A467E57BEF, NameHash = 0x6F214CFBE5603A0)]
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
