using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD441BF304DE93DAB, NameHash = 0xDE41746A)]
    public class GcProductDescriptionOverrideTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcProductDescriptionOverride> Table;
    }
}
