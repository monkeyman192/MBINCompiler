namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDADE724C336C1487, NameHash = 0xDE54022A)]
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
