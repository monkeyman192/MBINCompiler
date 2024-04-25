namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61A5E5D940B7FB0C, NameHash = 0xB3C5F69D62F6CA73)]
    public class GcMissionSequenceGetToExpedition : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public NMSString0x20A Event;
        [NMS(Index = 3)]
        /* 0x020 */ public float CompletionDistance;
        [NMS(Index = 4)]
        /* 0x024 */ public float Timeout;
        [NMS(Index = 6)]
        /* 0x028 */ public NMSString0x80 DebugText;
        [NMS(Index = 1)]
        /* 0x0A8 */ public NMSString0x80 GalaxyMapMessage;
        [NMS(Index = 0)]
        /* 0x128 */ public NMSString0x80 Message;
        [NMS(Index = 5)]
        /* 0x1A8 */ public NMSString0x80 TimeoutOSD;
    }
}
