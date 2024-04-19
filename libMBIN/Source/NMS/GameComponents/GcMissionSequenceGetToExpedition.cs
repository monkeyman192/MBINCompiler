namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61A5E5D940B7FB0C, NameHash = 0xB3C5F69D62F6CA73)]
    public class GcMissionSequenceGetToExpedition : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Event;
        /* 0x020 */ public float CompletionDistance;
        /* 0x024 */ public float Timeout;
        /* 0x028 */ public NMSString0x80 DebugText;
        /* 0x0A8 */ public NMSString0x80 GalaxyMapMessage;
        /* 0x128 */ public NMSString0x80 Message;
        /* 0x1A8 */ public NMSString0x80 TimeoutOSD;
    }
}
