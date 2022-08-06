using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x11938FA6E637EEF4, NameHash = 0x3FF01CECDEAECD1D)]
    public class GcRewardMultiSpecificProductRecipes : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ProductIds;
        /* 0x10 */ public NMSString0x10 DisplayProductId;
        /* 0x20 */ public NMSString0x20A SetName;
        /* 0x40 */ public bool Silent;
    }
}
