using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C30D622FA4FCBBD, NameHash = 0x97E36001)]
    public class GcSmokeBotSystemReport : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcSmokeBotStats SpaceStats;
        [NMS(Index = 1)]
        /* 0x090 */ public GcSmokeBotStats SystemStats;
        [NMS(Index = 3)]
        /* 0x120 */ public List<GcSmokeBotPlanetReport> PlanetReports;
        [NMS(Index = 0)]
        /* 0x130 */ public ulong UA;
    }
}
