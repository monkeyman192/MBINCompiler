using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x28C219DA72012107, NameHash = 0x2219C319)]
    public class GcStatGroupTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStatGroupData> StatGroupTable;
    }
}
