using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE91E8C5E9BDFA3ED, NameHash = 0xF0BB5F78)]
    public class GcIDLookupPaths : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcIDLookupPath> Paths;
    }
}
