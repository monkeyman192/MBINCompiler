using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71D9F4783A615B33, NameHash = 0x3FE2B5A3043E562F)]
    public class GcCreatureGenerationOptionalWeightedList : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcCreatureGenerationWeightedList Archetypes;
        [NMS(Index = 0)]
        /* 0x40 */ public float Probability;
        [NMS(Index = 1)]
        /* 0x44 */ public bool OverrideAllDomains;
    }
}
