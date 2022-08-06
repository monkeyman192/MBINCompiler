using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA31DEBC1D1174795, NameHash = 0xE0CD9FCE9BCD8413)]
    public class GcCostPoliceCargoBribe : NMSTemplate
    {
        /* 0x0 */ public bool IncludeNipNip;
        /* 0x1 */ public bool OnlyCargoProbeInventories;
        /* 0x4 */ public int Amount;
    }
}
