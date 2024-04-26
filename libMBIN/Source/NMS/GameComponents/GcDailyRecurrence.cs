namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97FB1C988472469D, NameHash = 0xA4B99A409C0C214B)]
    public class GcDailyRecurrence : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int RecurrenceHour;
        [NMS(Index = 0)]
        /* 0x4 */ public int RecurrenceMinute;
        [NMS(Index = 2)]
        /* 0x8 */ public NMSString0x80 DebugText;
    }
}
