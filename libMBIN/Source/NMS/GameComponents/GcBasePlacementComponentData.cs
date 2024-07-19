using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B2B875EB4BD742E, NameHash = 0x3203CA31)]
    public class GcBasePlacementComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBasePlacementRule> Rules;
    }
}
