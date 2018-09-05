namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x90)]
    public class GcYearlyRecurrence : NMSTemplate
    {
        public int RecurrenceMinute;
        public int RecurrenceHour;
        public int RecurrenceDay;
        public GcMonth RecurrenceMonth;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
