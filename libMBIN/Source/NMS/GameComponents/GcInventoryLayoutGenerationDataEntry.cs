using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7184C435E5344095, NameHash = 0x15DCF5F4B3591EDB)]
    public class GcInventoryLayoutGenerationDataEntry : NMSTemplate
    {
        /* 0x00 */ public int MinSlots;
        /* 0x04 */ public int MaxSlots;
        /* 0x08 */ public int MinTechSlots;
        /* 0x0C */ public int MaxTechSlots;
        /* 0x10 */ public int MinCargoSlots;
        /* 0x14 */ public int MaxCargoSlots;
    }
}
