namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD897379FCAFA16C1, NameHash = 0x768DA5D2543840C5)]
    public class GcMissionSequenceWaitForMessage : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public NMSString0x10 SetIconWithID;
        [NMS(Index = 1)]
        /* 0x010 */ public NMSString0x10 WaitMessageID;
        [NMS(Index = 4)]
        /* 0x020 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0A0 */ public NMSString0x80 Message;
        [NMS(Index = 3)]
        /* 0x120 */ public NMSString0x20 FormatMessageWithSeasonData;
    }
}
