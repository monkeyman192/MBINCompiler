namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66824955EE06DA4D, NameHash = 0xBFBC092F)]
    public class GcMissionSequenceLearnWords : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public int Amount;
    }
}
