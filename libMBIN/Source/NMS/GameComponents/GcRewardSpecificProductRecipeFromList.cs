using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D54EB39113A7C20, NameHash = 0xCD501C8D037C74A5)]
    public class GcRewardSpecificProductRecipeFromList : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ProductList;
        // size: 0x4
        public enum ProductListRewardOrderEnum { OneRandom, InOrder, TryAllRandom, TryUnknownRandom }
        /* 0x10 */ public ProductListRewardOrderEnum ProductListRewardOrder;
    }
}
