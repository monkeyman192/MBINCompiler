using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x81C7026487638117, NameHash = 0x53C414A21BE5AF34)]
    public class GcNPCWordReactionList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCProbabilityWordReactionData> Reactions;
    }
}
