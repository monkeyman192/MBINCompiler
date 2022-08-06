using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA45C8D02FAACDDE6, NameHash = 0x778378F86BB2392C)]
    public class GcSmokeBotPlanetReport : NMSTemplate
    {
        /* 0x00 */ public ulong UA;
        /* 0x10 */ public GcSmokeBotStats PlanetStats;
    }
}
