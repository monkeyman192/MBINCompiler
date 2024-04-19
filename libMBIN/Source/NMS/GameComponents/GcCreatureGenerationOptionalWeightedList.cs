using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5C0A19A1E4CC50C, NameHash = 0x3FE2B5A3043E562F)]
    public class GcCreatureGenerationOptionalWeightedList : NMSTemplate
    {
        /* 0x00 */ public GcCreatureGenerationWeightedList Archetypes;
        /* 0x40 */ public float Probability;
        /* 0x44 */ public bool OverrideAllDomains;
    }
}
