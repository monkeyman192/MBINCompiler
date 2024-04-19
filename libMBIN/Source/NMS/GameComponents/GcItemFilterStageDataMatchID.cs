using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44FBA74808F2B4BE, NameHash = 0x964C076B6506C0B0)]
    public class GcItemFilterStageDataMatchID : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A DisabledMessage;
        /* 0x20 */ public List<NMSString0x10> ValidIds;
        /* 0x30 */ public GcItemFilterMatchIDType MatchType;
    }
}
