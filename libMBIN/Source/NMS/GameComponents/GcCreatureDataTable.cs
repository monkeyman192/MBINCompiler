using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x334AE6F1383C0C4A, NameHash = 0x58F2CAEC)]
    public class GcCreatureDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureData> Table;
    }
}
