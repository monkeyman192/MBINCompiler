using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC37D2D6632FB43AB, NameHash = 0x48D0EA546ABC7EE6)]
    public class GcProductDescriptionOverrideTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcProductDescriptionOverride> Table;
    }
}
