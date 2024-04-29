using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6D7F4F21E2E0DD5, NameHash = 0x48D0EA546ABC7EE6)]
    public class GcProductDescriptionOverrideTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcProductDescriptionOverride> Table;
    }
}
