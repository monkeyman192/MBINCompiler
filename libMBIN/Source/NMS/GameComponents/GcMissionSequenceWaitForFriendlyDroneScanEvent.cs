namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7BDD2A2532E47943, NameHash = 0xD5B668729A28BD2C)]
    public class GcMissionSequenceWaitForFriendlyDroneScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Event;
        /* 0x020 */ public NMSString0x80 DebugText;
        /* 0x0A0 */ public NMSString0x80 MessageCantSummon;
        /* 0x120 */ public NMSString0x80 MessageNotAvailable;
        /* 0x1A0 */ public NMSString0x80 MessageSummoned;
        /* 0x220 */ public NMSString0x80 MessageUnsummoned;
    }
}
