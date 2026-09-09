using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF1DCD4559E5AC74, NameHash = 0x9F14A395)]
    public class GcSalvageEventTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSalvageEventData> Table;
    }
}
