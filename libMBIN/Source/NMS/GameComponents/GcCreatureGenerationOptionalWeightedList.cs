using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5C0A19A1E4CC50C, NameHash = 0x3FE2B5A3043E562F)]
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
