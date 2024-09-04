namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD7DC2C307875B9D6, NameHash = 0x9038B3CD)]
    public class GcMissionConditionMissionMessage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Message;
        [NMS(Index = 1)]
        /* 0x10 */ public VariableSizeString MessageToFormatSeasonalIDInto;
    }
}
