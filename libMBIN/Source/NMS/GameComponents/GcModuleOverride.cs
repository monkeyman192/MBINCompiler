using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x426EFE251C152DC5, NameHash = 0x2ABA38292ED14515)]
    public class GcModuleOverride : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Module;
        /* 0x10 */ public List<GcWeightedResource> Scenes;
        /* 0x20 */ public float OriginalSceneProbability;
        /* 0x24 */ public float ProbabilityMultiplier;
    }
}
