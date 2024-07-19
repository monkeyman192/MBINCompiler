namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E15A0D44CA10D09, NameHash = 0x8CE5B254)]
    public class GcMissionSequenceWaitForMessage : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 SetIconWithID;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 WaitMessageID;
        [NMS(Index = 3)]
        /* 0x40 */ public NMSString0x20 FormatMessageWithSeasonData;
    }
}
