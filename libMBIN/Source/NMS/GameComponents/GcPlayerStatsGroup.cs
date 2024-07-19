using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6CBFB352138AFFEA, NameHash = 0x74581FC9)]
    public class GcPlayerStatsGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 GroupId;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcPlayerStat> Stats;
        [NMS(Index = 1)]
        /* 0x20 */ public ulong Address;
    }
}
