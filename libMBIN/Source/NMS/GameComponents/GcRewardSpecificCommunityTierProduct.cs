using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED9C5204B538EF2E, NameHash = 0xA0372351D829A5B0)]
    public class GcRewardSpecificCommunityTierProduct : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ProductList;
        /* 0x10 */ public NMSString0x10 RequiresTech;
        /* 0x20 */ public int AmountMax;
        /* 0x24 */ public int AmountMin;
        /* 0x28 */ public bool ForceSpecialMessage;
    }
}
