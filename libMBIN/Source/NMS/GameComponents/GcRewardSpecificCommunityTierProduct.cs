using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5FC766F25762CDF, NameHash = 0xD7F785F1)]
    public class GcRewardSpecificCommunityTierProduct : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x10> ProductList;
        [NMS(Index = 4)]
        /* 0x10 */ public NMSString0x10 RequiresTech;
        [NMS(Index = 2)]
        /* 0x20 */ public int AmountMax;
        [NMS(Index = 1)]
        /* 0x24 */ public int AmountMin;
        [NMS(Index = 3)]
        /* 0x28 */ public bool ForceSpecialMessage;
    }
}
