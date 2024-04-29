namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE5902E99DCD4975, NameHash = 0x36320600C6ADE7CA)]
    public class GcSpawnDensity : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        // size: 0x3
        public enum CoverageTypeEnum : uint {
            Total,
            SmoothPatch,
            GridPatch,
        }
        [NMS(Index = 2)]
        /* 0x10 */ public CoverageTypeEnum CoverageType;
        [NMS(Index = 3)]
        /* 0x14 */ public float PatchSize;
        [NMS(Index = 4)]
        /* 0x18 */ public float RegionScale;
        [NMS(Index = 1)]
        /* 0x1C */ public bool Active;
    }
}
