using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9CEE2426F213DFA8, NameHash = 0x390E6B7795024BAB)]
    public class GcSubstanceTable : NMSTemplate
    {
        /* 0x00 */ public List<GcRealityCraftingRecipeData> Crafting;
        /* 0x10 */ public List<GcRealitySubstanceData> Table;
    }
}
