using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC210, GUID = 0x8DA992F13A2F604A, NameHash = 0x9A0073340429C464)]
    public class GcProceduralProductTable : NMSTemplate
    {
        [NMS(Size = 0x17, EnumType = typeof(GcProceduralProductCategory.ProceduralProductCategoryEnum))]
        public GcProceduralProductData[] Table;
    }
}
