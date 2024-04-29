using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1AC8796E6CDCBFA1, NameHash = 0x8F2E6E15D53D1C05)]
    public class GcIDLookupPaths : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcIDLookupPath> Paths;
    }
}
