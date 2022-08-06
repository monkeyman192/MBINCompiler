using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB7C46DCB90948783, NameHash = 0xEAB35A5B84B3A47C)]
    public class GcBiomeList : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        public float[] BiomeProbability;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        public float[] PrimeBiomeProbability;
    }
}
