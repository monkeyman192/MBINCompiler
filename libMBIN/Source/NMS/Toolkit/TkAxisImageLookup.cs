using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6BCEA155104F952F, NameHash = 0x330ED410)]
    public class TkAxisImageLookup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAxisPathMapping> Lookup;
    }
}
