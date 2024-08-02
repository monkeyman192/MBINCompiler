using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3B2ED18095A137A, NameHash = 0xA7C3074A)]
    public class GcMaintenanceOverrideTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcMaintenanceOverride> Table;
    }
}
