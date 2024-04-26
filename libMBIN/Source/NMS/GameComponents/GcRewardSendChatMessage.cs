namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x91B0378F76DEBBB9, NameHash = 0x64C12702D824E202)]
    public class GcRewardSendChatMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A CustomText;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 StatusMessageId;
    }
}
