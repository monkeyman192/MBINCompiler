namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34F3912D22FD83AB, NameHash = 0x1E73CF8A2A7FA65D)]
    public class GcScannerIconHighlightTypes : NMSTemplate
    {
        // size: 0x5
        public enum ScannerIconHighlightTypeEnum : uint {
            Diamond,
            Hexagon,
            Tag,
            Octagon,
            Circle,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ScannerIconHighlightTypeEnum ScannerIconHighlightType;
    }
}
