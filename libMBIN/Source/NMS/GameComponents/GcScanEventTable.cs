using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xACD58F673D9A2D82, NameHash = 0x0D550A58E83EA253)]
    public class GcScanEventTable : NMSTemplate
    {
        /* 0x0 */ public List<GcScanEventData> Events;
    }
}
