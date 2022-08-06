using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F6B480612148B69, NameHash = 0xB05B3758665D56DE)]
    public class GcRecipeTable : NMSTemplate
    {
        /* 0x0 */ public List<GcRefinerRecipe> Table;
    }
}
