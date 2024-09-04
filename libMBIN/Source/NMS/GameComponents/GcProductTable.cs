using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x719D7D7FB5D3B570, NameHash = 0x6EDC332)]
    public class GcProductTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcProductData> Table;
    }
}
