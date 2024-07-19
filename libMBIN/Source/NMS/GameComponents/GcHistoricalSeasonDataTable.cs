using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA34AF3ADB45D936, NameHash = 0xDF99D762)]
    public class GcHistoricalSeasonDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcHistoricalSeasonData> Table;
    }
}
