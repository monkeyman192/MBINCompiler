using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x402E80CD94CD3E67, NameHash = 0xB4EEBEE8)]
    public class GcStats : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStatsGroup> Stats;
    }
}
