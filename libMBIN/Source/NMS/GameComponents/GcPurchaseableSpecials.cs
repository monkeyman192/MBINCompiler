using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x245F10963F2A1BE7, NameHash = 0x6A87CACD)]
    public class GcPurchaseableSpecials : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPurchaseableSpecial> Table;
    }
}
