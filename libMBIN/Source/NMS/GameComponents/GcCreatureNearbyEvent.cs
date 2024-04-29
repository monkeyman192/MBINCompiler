using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA938029B5AA739C6, NameHash = 0x42869E79D40A84C1)]
    public class GcCreatureNearbyEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcCreatureAlertData> AlertTable;
        [NMS(Index = 1)]
        /* 0x10 */ public bool Inverse;
    }
}
