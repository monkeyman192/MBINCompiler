namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x82D9D45B58591222, NameHash = 0x5582642D1376644E)]
    public class GcScanEventGPSHint : NMSTemplate
    {
        // size: 0x7
        public enum ScanEventGPSHintEnum : uint {
            None,
            Accurate,
            OffsetNarrow,
            OffsetMid,
            OffsetWide,
            Obfuscated,
            PartObfuscated,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ScanEventGPSHintEnum ScanEventGPSHint;
    }
}
