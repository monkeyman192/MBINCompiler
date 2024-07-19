using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFAB665B2F13F848, NameHash = 0x70AD46A6)]
    public class GcNPCWordReactionList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCProbabilityWordReactionData> Reactions;
    }
}
