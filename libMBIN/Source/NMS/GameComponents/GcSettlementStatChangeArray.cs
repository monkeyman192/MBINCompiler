using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37B2833FD19F2561, NameHash = 0x7A414D59)]
    public class GcSettlementStatChangeArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSettlementStatChange> Stats;
    }
}
