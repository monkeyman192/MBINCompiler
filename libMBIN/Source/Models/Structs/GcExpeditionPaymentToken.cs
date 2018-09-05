namespace libMBIN.Models.Structs
{
    public class GcExpeditionPaymentToken : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TokenName;
        public int TokenValue;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
