using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD68A203BCCFB141F, NameHash = 0xBA4C53DBACF34B41)]
    public class GcBasePlacementComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBasePlacementRule> Rules;
    }
}
