using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E2CA784CBE38650, NameHash = 0x55C4631C)]
    public class GcCreatureNearbyEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcCreatureAlertData> AlertTable;
        [NMS(Index = 1)]
        /* 0x10 */ public bool Inverse;
    }
}
