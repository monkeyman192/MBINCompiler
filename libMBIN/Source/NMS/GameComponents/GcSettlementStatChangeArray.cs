using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x30C61B9E22C99CF7, NameHash = 0x661EFBF46F4B3D78)]
    public class GcSettlementStatChangeArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSettlementStatChange> Stats;
    }
}
