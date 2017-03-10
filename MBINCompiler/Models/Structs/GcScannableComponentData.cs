namespace MBINCompiler.Models.Structs
{
    public class GcScannableComponentData : NMSTemplate
    {
        public float ScanRange;
        [NMS(Size = 0x20)]
        public string ScanName;
        public float ScanTime;

        public GcScannerIconTypes IconType;
        public bool PermanentIcon;
        public float PermanentIconRadius;

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding;
    }
}
