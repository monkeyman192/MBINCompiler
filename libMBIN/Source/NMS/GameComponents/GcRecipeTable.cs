using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC1AB7E7C81D23326, NameHash = 0xB05B3758665D56DE)]
    public class GcRecipeTable : NMSTemplate
    {
        public List<GcRefinerRecipe> Table;
    }
}
