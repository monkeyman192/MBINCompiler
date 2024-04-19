using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD0E298116C7E223F, NameHash = 0xEBAB39E2F49FE5F)]
    public class GcPlayerStatsGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 GroupId;
        /* 0x10 */ public List<GcPlayerStat> Stats;
        /* 0x20 */ public ulong Address;
    }
}
