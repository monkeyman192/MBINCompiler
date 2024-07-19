namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5955F8913FD2B3B9, NameHash = 0x4B8CEF05)]
    public class GcMissionSequenceGetToExpedition : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 6)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 1)]
        /* 0x30 */ public VariableSizeString GalaxyMapMessage;
        [NMS(Index = 0)]
        /* 0x40 */ public VariableSizeString Message;
        [NMS(Index = 5)]
        /* 0x50 */ public VariableSizeString TimeoutOSD;
        [NMS(Index = 3)]
        /* 0x60 */ public float CompletionDistance;
        [NMS(Index = 4)]
        /* 0x64 */ public float Timeout;
    }
}
