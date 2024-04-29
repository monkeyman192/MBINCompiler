using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC90C58DCAD8951FC, NameHash = 0x84DCB310035A7429)]
    public class TkResourceFilterList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkResourceFilterData> Filters;
    }
}
