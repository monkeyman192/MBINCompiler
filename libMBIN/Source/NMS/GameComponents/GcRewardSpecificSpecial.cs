using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0xA4AFBFF9DFE44876, NameHash = 0xCF9FC45A7B70BB85)]
    public class GcRewardSpecificSpecial : NMSTemplate
    {
        public NMSString0x10 ID;
        public NMSString0x20A Message;
        public bool UseSpecialFormatting;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}