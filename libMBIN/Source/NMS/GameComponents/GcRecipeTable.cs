using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD25065EE6572F147, NameHash = 0xEDC78ED)]
    public class GcRecipeTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcRefinerRecipe> Table;
    }
}
