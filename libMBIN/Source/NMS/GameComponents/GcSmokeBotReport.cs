using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B44AFEA396F9ADE, NameHash = 0xDB29C43F)]
    public class GcSmokeBotReport : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcSmokeBotSystemReport> Systems;
        [NMS(Index = 0)]
        /* 0x10 */ public ulong StartingUA;
    }
}
