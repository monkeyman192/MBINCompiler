using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8835D3749100EB89, NameHash = 0x5EB1FACFC9C7B474)]
    public class TkReplacementResourceTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkReplacementResource> Data;
    }
}
