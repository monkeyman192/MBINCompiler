using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5A10, GUID = 0xA445AFD8463EAB2)]
    public class GcProceduralProductTable : NMSTemplate
    {
        [NMS( EnumType = typeof( GcProceduralProductCategory.ProceduralProductCategoryEnum ) )]
        public GcProceduralProductData[] Table;
    }
}
