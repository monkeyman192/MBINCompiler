using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x3F56788CE10D174, NameHash = 0x5CEE315FE3457560)]
    public class GcBiomeType : NMSTemplate
    {
        // size: 0x10
		public enum BiomeEnum { Lush, Toxic, Scorched, Radioactive, Frozen, Barren, Dead, Weird, Red, Green, Blue, Test, Swamp, Lava, Waterworld, All }
		public BiomeEnum Biome;
    }
}