using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB95FE2F199DE866A, NameHash = 0xDB5E6190)]
    public class TkAnimMaskTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAnimMask> Table;
    }
}
