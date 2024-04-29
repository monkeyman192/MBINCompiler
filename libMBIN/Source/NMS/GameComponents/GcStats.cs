using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCD610D5B1F6F64DB, NameHash = 0x9C20970E839B65D9)]
    public class GcStats : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStatsGroup> Stats;
    }
}
