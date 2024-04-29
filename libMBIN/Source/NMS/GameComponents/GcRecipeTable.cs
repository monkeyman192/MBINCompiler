using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21D46E235D13B43D, NameHash = 0xB05B3758665D56DE)]
    public class GcRecipeTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcRefinerRecipe> Table;
    }
}
