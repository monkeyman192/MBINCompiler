using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x48, GUID = 0x29A31A73E09B7498, NameHash = 0x3FF01CECDEAECD1D)]
    public class GcRewardMultiSpecificProductRecipes : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ProductIds;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string DisplayProductId;
        [NMS(Size = 0x20)]
        /* 0x20 */ public string SetName;
        /* 0x40 */ public bool Silent;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x41 */ public byte[] EndPadding;
    }
}