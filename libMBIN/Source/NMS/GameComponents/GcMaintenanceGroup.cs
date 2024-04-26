using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE843A80F4E132409, NameHash = 0x989F3C45C63EA6B8)]
    public class GcMaintenanceGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcMaintenanceGroupEntry> Table;
    }
}
