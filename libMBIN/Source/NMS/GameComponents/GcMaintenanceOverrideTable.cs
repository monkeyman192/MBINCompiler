using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2FFD8263B74F5A2C, NameHash = 0x2BBB9DEDEECBFF1A)]
    public class GcMaintenanceOverrideTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcMaintenanceOverride> Table;
    }
}
