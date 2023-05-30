using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcScannableComponentData : NMSTemplate
    {
        public float ScanRange;
        public NMSString0x20 ScanName;
        public float ScanTime;

        public GcScannerIconTypes IconType;
        public bool PermanentIcon;
        public float PermanentIconRadius;
    }
}
