using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x433FC9C449BFBA3D, NameHash = 0x964C076B6506C0B0)]
    public class GcItemFilterStageDataMatchID : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A DisabledMessage;
        [NMS(Index = 2)]
        /* 0x20 */ public List<NMSString0x10> ValidIds;
        [NMS(Index = 1)]
        /* 0x30 */ public GcItemFilterMatchIDType MatchType;
    }
}
