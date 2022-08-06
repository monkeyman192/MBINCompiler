using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA111493A3BF14CC7, NameHash = 0x42869E79D40A84C1)]
    public class GcCreatureNearbyEvent : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureAlertData> AlertTable;
        /* 0x10 */ public bool Inverse;
    }
}
