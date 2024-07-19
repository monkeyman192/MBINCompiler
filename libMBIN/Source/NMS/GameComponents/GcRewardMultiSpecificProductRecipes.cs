using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA933B047D8E6755, NameHash = 0xA346022)]
    public class GcRewardMultiSpecificProductRecipes : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A SetName;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 DisplayProductId;
        [NMS(Index = 0)]
        /* 0x30 */ public List<NMSString0x10> ProductIds;
        [NMS(Index = 3)]
        /* 0x40 */ public bool Silent;
    }
}
