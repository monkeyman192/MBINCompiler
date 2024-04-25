using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F71AA2B77D5938C, NameHash = 0x79E2609CF7F155CE)]
    public class GcCreatureGenerationDomainEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcCreatureGenerationDensity DensityModifier;
        [NMS(Index = 1)]
        /* 0x4 */ public NMSString0x80 File;
    }
}
