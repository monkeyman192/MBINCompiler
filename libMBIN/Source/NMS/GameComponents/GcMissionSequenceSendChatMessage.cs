namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x788CFEEA5BD1BAC6, NameHash = 0xA37E0F48)]
    public class GcMissionSequenceSendChatMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A CustomText;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 StatusMessageId;
    }
}
