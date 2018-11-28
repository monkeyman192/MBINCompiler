using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x34, GUID = 0xA2066617C00AA47)]
    public class GcBiomeList : NMSTemplate
    {
        [NMS( EnumType = typeof( GcBiomeType.BiomeEnum ) )]
        public float[] BiomeProbability;
    }
}
