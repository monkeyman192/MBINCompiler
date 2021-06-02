using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, Alignment = 0x8, GUID = 0x9724C1F33A4A3060, NameHash = 0xF4416360D2B155D6)]
    public class GcExpeditionPaymentToken : NMSTemplate
    {
        public NMSString0x10 TokenName;
        public int TokenValue;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}