namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B465A5702D8A3AF, NameHash = 0x768DA5D2543840C5)]
    public class GcMissionSequenceWaitForMessage : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 SetIconWithID;
        /* 0x010 */ public NMSString0x10 WaitMessageID;
        /* 0x020 */ public NMSString0x80 DebugText;
        /* 0x0A0 */ public NMSString0x80 Message;
        /* 0x120 */ public NMSString0x20 FormatMessageWithSeasonData;
    }
}
