namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x792F15FD68FA96F3, NameHash = 0x36320600C6ADE7CA)]
    public class GcSpawnDensity : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        // size: 0x3
        public enum CoverageTypeEnum : uint {
            Total,
            SmoothPatch,
            GridPatch,
        }
        /* 0x10 */ public CoverageTypeEnum CoverageType;
        /* 0x14 */ public float PatchSize;
        /* 0x18 */ public float RegionScale;
        /* 0x1C */ public bool Active;
    }
}
