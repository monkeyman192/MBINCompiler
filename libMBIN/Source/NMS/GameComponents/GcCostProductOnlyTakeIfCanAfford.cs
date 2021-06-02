using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x3B2DA6D341ADDAFA, NameHash = 0xDEF97AA1BA31BC2A)]
    public class GcCostProductOnlyTakeIfCanAfford : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public int Amount;
        /* 0x18 */ public NMSString0x20A AltCostLocID;
    }
}