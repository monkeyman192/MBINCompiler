using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEE169220F599D3, NameHash = 0x989F3C45C63EA6B8)]
    public class GcMaintenanceGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcMaintenanceGroupEntry> Table;
    }
}
