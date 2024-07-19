namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25EF5B34653E792A, NameHash = 0x8595D52D)]
    public class GcExpeditionPaymentToken : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 TokenName;
        [NMS(Index = 1)]
        /* 0x10 */ public int TokenValue;
    }
}
