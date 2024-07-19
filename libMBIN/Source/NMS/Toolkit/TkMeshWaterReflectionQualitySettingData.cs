namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2F1F6AFF4F2E47B7, NameHash = 0xC3087351)]
    public class TkMeshWaterReflectionQualitySettingData : NMSTemplate
    {
        // size: 0x3
        public enum PlanarReflectionsEnum : uint {
            Off,
            TerrainOnly,
            TerrainAndScreenspace,
        }
        [NMS(Index = 1)]
        /* 0x0 */ public PlanarReflectionsEnum PlanarReflections;
        // size: 0x2
        public enum ScreenSpaceReflectionsEnum : uint {
            Off,
            On,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public ScreenSpaceReflectionsEnum ScreenSpaceReflections;
    }
}
