using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x65B6ABF00DA5E289, NameHash = 0x390E6B7795024BAB)]
    public class GcSubstanceTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcRealityCraftingRecipeData> Crafting;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcRealitySubstanceData> Table;
    }
}
