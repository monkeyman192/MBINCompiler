namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6B6A3ADD0AD9CD5, NameHash = 0xA35414E2)]
    public class GcMissionSequenceGetUnits : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public int Amount;
    }
}
