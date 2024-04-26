using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15EF2DAC54CE228C, NameHash = 0xCD3CFB61BDAFF633)]
    public class GcPurchaseableSpecials : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPurchaseableSpecial> Table;
    }
}
