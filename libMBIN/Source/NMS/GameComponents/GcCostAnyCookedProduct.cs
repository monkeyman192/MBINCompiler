using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x0E2B41CC84FE8F8F, NameHash = 0xF9892B1499AD055A)]
    public class GcCostAnyCookedProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A CostString;
        /* 0x20 */ public NMSString0x20A CostStringCantAfford;
        /* 0x40 */ public int Index;
    }
}
