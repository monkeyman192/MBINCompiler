using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5AC0, GUID = 0xE9219C44019EB159, NameHash = 0x9A0073340429C464)]
    public class GcProceduralProductTable : NMSTemplate
    {
        [NMS(Size = 0xB, EnumType = typeof(GcProceduralProductCategory.ProceduralProductCategoryEnum))]
        public GcProceduralProductData[] Table;
    }
}
