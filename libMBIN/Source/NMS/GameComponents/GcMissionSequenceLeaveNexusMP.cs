namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D3A4695659CC613, NameHash = 0x210E5E8D593FFE)]
    public class GcMissionSequenceLeaveNexusMP : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public ulong Timeout;
        [NMS(Index = 3)]
        /* 0x008 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x088 */ public NMSString0x80 Message;
        [NMS(Index = 1)]
        /* 0x108 */ public NMSString0x80 MessageNoWarp;
    }
}
