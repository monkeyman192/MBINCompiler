using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4E24122A8CCC28EA, NameHash = 0x9219269B)]
    public class TkButtonImageLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkButtonPathMapping> Lookup;
    }
}
