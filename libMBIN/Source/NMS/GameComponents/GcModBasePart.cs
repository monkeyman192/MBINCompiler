using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x6D0, GUID = 0x9B8C9E9BA872E554, NameHash = 0x6A104C45E1F1638D)]
    public class GcModBasePart : NMSTemplate
    {
        /* 0x000 */ public NMSString0x40 ID;
        /* 0x040 */ public GcProductData ProductData;
        /* 0x450 */ public GcBaseBuildingEntry PartData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x6C8 */ public byte[] EndPadding;
    }
}
