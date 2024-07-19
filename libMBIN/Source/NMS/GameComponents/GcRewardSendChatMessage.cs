namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1FCC76BA13F0CC4, NameHash = 0xBDDD4819)]
    public class GcRewardSendChatMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A CustomText;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 StatusMessageId;
    }
}
