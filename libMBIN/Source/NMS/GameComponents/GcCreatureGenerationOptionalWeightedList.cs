using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5972CF272DDD8DCA, NameHash = 0x3FE2B5A3043E562F)]
    public class GcCreatureGenerationOptionalWeightedList : NMSTemplate
    {
        /* 0x0 */ public float Probability;
        /* 0x4 */ public bool OverrideAllDomains;
        /* 0x8 */ public GcCreatureGenerationWeightedList Archetypes;
    }
}
