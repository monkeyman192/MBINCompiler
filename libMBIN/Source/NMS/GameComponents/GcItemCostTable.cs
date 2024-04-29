using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x557588C20421F72A, NameHash = 0xF3A6F2D8DFF9DF48)]
    public class GcItemCostTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcItemCostData> Items;
    }
}
