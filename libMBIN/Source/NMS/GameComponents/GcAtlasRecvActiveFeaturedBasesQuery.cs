using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x0CB44EBD725E824C4, NameHash = 0x3C3448051BA466FE)]
    public class GcAtlasRecvActiveFeaturedBasesQuery : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public List<GcAtlasActiveFeaturedBaseHeader> BasesHeaders;
    }
}
