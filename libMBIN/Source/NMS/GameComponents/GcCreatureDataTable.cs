using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C489CD31B9BEB56, NameHash = 0x58F2CAEC)]
    public class GcCreatureDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureData> Table;
    }
}
