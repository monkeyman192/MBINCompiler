namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA4AA33B8FCAE03E, NameHash = 0xE8FE27493120750F)]
    public class GcBiomeSubType : NMSTemplate
    {
        // size: 0x1B
        public enum BiomeSubTypeEnum : uint {
            None,
            Standard,
            HighQuality,
            Structure,
            Beam,
            Hexagon,
            FractCube,
            Bubble,
            Shards,
            Contour,
            Shell,
            BoneSpire,
            WireCell,
            HydroGarden,
            HugePlant,
            HugeLush,
            HugeRing,
            HugeRock,
            HugeScorch,
            HugeToxic,
            Variant_A,
            Variant_B,
            Variant_C,
            Variant_D,
            Infested,
            Swamp,
            Lava,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BiomeSubTypeEnum BiomeSubType;
    }
}
