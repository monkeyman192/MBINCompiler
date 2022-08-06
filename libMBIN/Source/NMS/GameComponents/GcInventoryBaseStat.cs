using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE23C7AA8E230A26A, NameHash = 0x88CEC164B6BD4ACC)]
    public class GcInventoryBaseStat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BaseStatID;
        /* 0x10 */ public NMSString0x10 LocID;
        /* 0x20 */ public List<GcInventoryBaseStatBonus> StatBonus;
    }
}
