using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA0814A4C94B662F6, NameHash = 0x6F214CFBE5603A0)]
    public class GcScanEventTriggers : NMSTemplate
    {
        /* 0x00 */ public float Range;
        /* 0x08 */ public List<NMSString0x10> Triggers;
        /* 0x18 */ public bool AllowRetrigger;
    }
}
