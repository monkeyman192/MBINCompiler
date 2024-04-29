using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4EAB9F0A4F4C9310, NameHash = 0x3FBCD98A534164CD)]
    public class GcSettlementPerksTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSettlementPerkData> Table;
    }
}
