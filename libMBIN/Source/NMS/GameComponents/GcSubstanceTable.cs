using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD26166A021B8DA0A, NameHash = 0x390E6B7795024BAB)]
    public class GcSubstanceTable : NMSTemplate
    {
        public List<GcRealitySubstanceData> Table;
        public List<GcRealityCraftingRecipeData> Crafting;
    }
}
