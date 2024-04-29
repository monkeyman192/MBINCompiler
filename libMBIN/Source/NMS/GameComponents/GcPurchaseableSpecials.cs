using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2E31FDB68AA2F5B3, NameHash = 0xCD3CFB61BDAFF633)]
    public class GcPurchaseableSpecials : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPurchaseableSpecial> Table;
    }
}
