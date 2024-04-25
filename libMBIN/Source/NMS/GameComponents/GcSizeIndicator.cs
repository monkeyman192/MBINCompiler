namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDADE724C336C1487, NameHash = 0x22715A99B359A960)]
    public class GcSizeIndicator : NMSTemplate
    {
        // size: 0x3
        public enum SizeIndicatorEnum : uint {
            Small,
            Medium,
            Large,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SizeIndicatorEnum SizeIndicator;
    }
}
