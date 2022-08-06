using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E0C4DD242A5FA5D, NameHash = 0xEBAB39E2F49FE5F)]
    public class GcPlayerStatsGroup : NMSTemplate // 0x28 bytes
    {
        /* 0x00 */ public NMSString0x10 GroupId;
        /* 0x10 */ public ulong Address;
        /* 0x18 */ public List<GcPlayerStat> Stats;
    }
}
