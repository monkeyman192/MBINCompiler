using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x8CD413343C0454A9, NameHash = 0xE8FE27493120750F)]
    public class GcBiomeSubType : NMSTemplate
    {
        // size: 0x1B
        public enum BiomeSubTypeEnum {
            None, Standard, HighQuality, Structure, Beam, Hexagon, FractCube, Bubble, Shards, Contour, Shell, BoneSpire, WireCell,
            HydroGarden, HugePlant, HugeLush, HugeRing, HugeRock, HugeScorch, HugeToxic, Variant_A, Variant_B, Variant_C, Variant_D,
            Infested, Swamp, Lava
        }
        public BiomeSubTypeEnum BiomeSubType;
    }
}
