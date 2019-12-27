using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xB0, GUID = 0xA45C8D02FAACDDE6, NameHash = 0x778378F86BB2392C, Broken = true)]
    public class GcSmokeBotPlanetReport : NMSTemplate
    {
        /* 0x00 */ public ulong UA;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x08 */ public byte[] Padding8;
        /* 0x10 */ public GcSmokeBotStats PlanetStats;
    }
}
