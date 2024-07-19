namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6AD20DC73DE9F5B, NameHash = 0x59A37A62)]
    public class GcBiomeSubType : NMSTemplate
    {
        // size: 0x1C
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
            Worlds,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BiomeSubTypeEnum BiomeSubType;
    }
}
