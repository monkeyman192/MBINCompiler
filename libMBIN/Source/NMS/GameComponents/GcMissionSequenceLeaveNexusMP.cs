namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D3A4695659CC613, NameHash = 0x210E5E8D593FFE)]
    public class GcMissionSequenceLeaveNexusMP : NMSTemplate
    {
        /* 0x000 */ public ulong Timeout;
        /* 0x008 */ public NMSString0x80 DebugText;
        /* 0x088 */ public NMSString0x80 Message;
        /* 0x108 */ public NMSString0x80 MessageNoWarp;
    }
}
