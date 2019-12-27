using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x160, GUID = 0x45A0E050DAB66262, NameHash = 0xFB50309B36475BDE, Broken = true)]
    public class GcSmokeBotSystemReport : NMSTemplate
    {
        /* 0x000 */ public ulong UA;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x08 */ public byte[] Padding8;
        /* 0x010 */ public GcSmokeBotStats SystemStats;
        /* 0x0B0 */ public GcSmokeBotStats SpaceStats;
        /* 0x150 */ public List<GcSmokeBotPlanetReport> PlanetReports;
    }
}
