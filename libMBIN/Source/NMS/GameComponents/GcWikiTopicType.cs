using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x28CFBF6BD64E94F5, NameHash = 0x72439AF10F4C849F)]
    public class GcWikiTopicType : NMSTemplate
    {
        // size: 0xF
        public enum WikiTopicTypeEnum { Substances, CustomSubstanceList, Products, CustomProductList, Technologies,
            CustomTechnologyList, BuildableTech, Construction, TradeCommodities,
            Curiosities, Cooking, StoneRunes, Recipes, Guide, Stories
        }
        /* 0x0 */ public WikiTopicTypeEnum WikiTopicType;
    }
}
