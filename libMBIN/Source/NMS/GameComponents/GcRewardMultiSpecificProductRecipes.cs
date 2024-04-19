using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA55F427D92D5310B, NameHash = 0x3FF01CECDEAECD1D)]
    public class GcRewardMultiSpecificProductRecipes : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A SetName;
        /* 0x20 */ public NMSString0x10 DisplayProductId;
        /* 0x30 */ public List<NMSString0x10> ProductIds;
        /* 0x40 */ public bool Silent;
    }
}
