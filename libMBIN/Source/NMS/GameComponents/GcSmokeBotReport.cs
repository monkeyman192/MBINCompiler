using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6FE3F6B4407FAE6A, NameHash = 0x16AC643981D10CC9)]
    public class GcSmokeBotReport : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcSmokeBotSystemReport> Systems;
        [NMS(Index = 0)]
        /* 0x10 */ public ulong StartingUA;
    }
}
