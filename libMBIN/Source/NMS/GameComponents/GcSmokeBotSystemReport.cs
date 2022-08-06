using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45A0E050DAB66262, NameHash = 0xFB50309B36475BDE)]
    public class GcSmokeBotSystemReport : NMSTemplate
    {
        /* 0x000 */ public ulong UA;
        /* 0x010 */ public GcSmokeBotStats SystemStats;
        /* 0x0B0 */ public GcSmokeBotStats SpaceStats;
        /* 0x150 */ public List<GcSmokeBotPlanetReport> PlanetReports;
    }
}
