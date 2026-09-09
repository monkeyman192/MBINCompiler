using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8191D46513910560, NameHash = 0xD57228C8)]
    public class GcAtlasMyAlliances : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcAtlasAlliance> Alliances;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x40 FoundedAllianceId;
        [NMS(Index = 2)]
        /* 0x50 */ public NMSString0x40 PrimaryAllianceId;
    }
}
