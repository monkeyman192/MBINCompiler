namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F5CC8BA811F301D, NameHash = 0x5CEE315FE3457560)]
    public class GcBiomeType : NMSTemplate
    {
        // size: 0x10
        public enum BiomeEnum : uint {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            All,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BiomeEnum Biome;
    }
}
