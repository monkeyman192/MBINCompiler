namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1215A79B78CD644A, NameHash = 0xCD6DAAA6)]
    public class GcScannerIconHighlightTypes : NMSTemplate
    {
        // size: 0x6
        public enum ScannerIconHighlightTypeEnum : uint {
            Diamond,
            Hexagon,
            Tag,
            Octagon,
            Circle,
            Star,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ScannerIconHighlightTypeEnum ScannerIconHighlightType;
    }
}
