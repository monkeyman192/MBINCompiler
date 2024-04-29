namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35FBEB3CE6BBF0BD, NameHash = 0xD5B668729A28BD2C)]
    public class GcMissionSequenceWaitForFriendlyDroneScanEvent : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public NMSString0x20A Event;
        [NMS(Index = 5)]
        /* 0x020 */ public NMSString0x80 DebugText;
        [NMS(Index = 2)]
        /* 0x0A0 */ public NMSString0x80 MessageCantSummon;
        [NMS(Index = 3)]
        /* 0x120 */ public NMSString0x80 MessageNotAvailable;
        [NMS(Index = 0)]
        /* 0x1A0 */ public NMSString0x80 MessageSummoned;
        [NMS(Index = 1)]
        /* 0x220 */ public NMSString0x80 MessageUnsummoned;
    }
}
