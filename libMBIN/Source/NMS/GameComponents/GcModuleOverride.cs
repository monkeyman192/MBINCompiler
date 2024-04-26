using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x426EFE251C152DC5, NameHash = 0x2ABA38292ED14515)]
    public class GcModuleOverride : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Module;
        [NMS(Index = 3)]
        /* 0x10 */ public List<GcWeightedResource> Scenes;
        [NMS(Index = 2)]
        /* 0x20 */ public float OriginalSceneProbability;
        [NMS(Index = 1)]
        /* 0x24 */ public float ProbabilityMultiplier;
    }
}
