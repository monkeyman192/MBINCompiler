using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4EC0F43200D5194, NameHash = 0xF365586B)]
    public class GcBiomeList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x00 */ public float[] BiomeProbability;
        [NMS(Index = 1, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x40 */ public float[] PrimeBiomeProbability;
    }
}
