namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E3985DA4CC97B9, NameHash = 0x5CB869EED69B0A9)]
    public class GcMonthlyRecurrence : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public int RecurrenceDay;
        [NMS(Index = 1)]
        /* 0x4 */ public int RecurrenceHour;
        [NMS(Index = 0)]
        /* 0x8 */ public int RecurrenceMinute;
        [NMS(Index = 3)]
        /* 0xC */ public NMSString0x80 DebugText;
    }
}
