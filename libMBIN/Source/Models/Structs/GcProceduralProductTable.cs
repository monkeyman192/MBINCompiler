using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x10)]
    public class GcProceduralProductTable : NMSTemplate
    {
        public List<GcProceduralProductData> Table;
    }
}
