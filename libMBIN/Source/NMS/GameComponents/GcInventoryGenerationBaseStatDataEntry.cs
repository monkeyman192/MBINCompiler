using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x4A53B69223F74C8F, NameHash = 0xBE33B4E320477672)]
    public class GcInventoryGenerationBaseStatDataEntry : NMSTemplate     // size: 0x20
    {
        /* 0x00 */ public NMSString0x10 BaseStatID;
        /* 0x10 */ public float Min;
        /* 0x14 */ public float Max;
        /* 0x18 */ public float MinFixedAdd;
        /* 0x1C */ public float MaxFixedAdd;
    }
}