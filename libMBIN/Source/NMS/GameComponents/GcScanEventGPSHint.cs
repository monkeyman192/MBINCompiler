namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BD80A217D649FCD, NameHash = 0x5582642D1376644E)]
    public class GcScanEventGPSHint : NMSTemplate
    {
        // size: 0x8
        public enum ScanEventGPSHintEnum : uint {
            None,
            Accurate,
            OffsetNarrow,
            OffsetMid,
            OffsetWide,
            Obfuscated,
            PartObfuscated,
            BuilderCorruption,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ScanEventGPSHintEnum ScanEventGPSHint;
    }
}
