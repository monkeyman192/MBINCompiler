using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD97314D7F0A50A3D, NameHash = 0x7A9FBCC1)]
    public class GcSubstanceTable : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcRealityCraftingRecipeData> Crafting;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcRealitySubstanceData> Table;
    }
}
