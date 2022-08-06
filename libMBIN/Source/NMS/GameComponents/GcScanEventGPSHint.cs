using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B109224F6A17ADB, NameHash = 0x5582642D1376644E)]
    public class GcScanEventGPSHint : NMSTemplate
    {
        public enum ScanEventGPSHintEnum { None, Accurate, OffsetNarrow, OffsetMid, OffsetWide, Obfuscated, PartObfuscated}
        public ScanEventGPSHintEnum ScanEventGPSHint;
    }
}
