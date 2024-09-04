using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87F024A8CA6FD495, NameHash = 0xB4EEBEE8)]
    public class GcStats : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStatsGroup> Stats;
    }
}
