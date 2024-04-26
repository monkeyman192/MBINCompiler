using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1BFD2D5D17CC0630, NameHash = 0xFD1B428DC8369A72)]
    public class GcRewardForgetSpecificProductRecipe : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> ProductList;
    }
}
