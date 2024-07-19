using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x898373AF4A1FAB4D, NameHash = 0x64882C9C)]
    public class GcAreaDamageDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcAreaDamageData> Table;
    }
}
