using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x02617A29D7ACB2B3, NameHash = 0x0EC60D3F951991D7)]
    public class GcRewardRequirementsForRecipe : NMSTemplate
    {
        public NMSString0x10 RecipeID;
        public bool RewardInCreative;
    }
}
