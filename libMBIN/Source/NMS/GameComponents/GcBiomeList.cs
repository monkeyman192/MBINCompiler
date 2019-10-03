using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x34, GUID = 0xA2066617C00AA47, NameHash = 0xEAB35A5B84B3A47C)]
    public class GcBiomeList : NMSTemplate
    {
        [NMS(Size = 0xD, EnumType = typeof(GcBiomeType.BiomeEnum))]
        public float[] BiomeProbability;
    }
}
