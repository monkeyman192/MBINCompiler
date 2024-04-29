using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDAE953CE28EEDA67, NameHash = 0x6A1494CD3EC019B6)]
    public class TkAxisImageLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAxisPathMapping> Lookup;
    }
}
