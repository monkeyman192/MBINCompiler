using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC987C90FB64439B0, NameHash = 0x52470205AC7B36D3)]
    public class GcHistoricalSeasonDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcHistoricalSeasonData> Table;
    }
}
