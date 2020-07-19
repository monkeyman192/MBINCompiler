using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x3B2DA6D341ADDAFA, NameHash = 0xDEF97AA1BA31BC2A)]
    public class GcCostProductOnlyTakeIfCanAfford : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public int Amount;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        [NMS(Size = 0x20)]
        /* 0x18 */ public string AltCostLocID;
    }
}