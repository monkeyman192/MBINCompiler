using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42D07F5EA314B2B0, NameHash = 0x3C3448051BA466FE)]
    public class GcAtlasRecvActiveFeaturedBasesQuery : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public List<GcAtlasActiveFeaturedBaseHeader> BasesHeaders;
    }
}
