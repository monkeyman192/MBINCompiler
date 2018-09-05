namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8C)]
    public class GcMonthlyRecurrence : NMSTemplate
    {
        public int RecurrenceMinute;
        public int RecurrenceHour;
        public int RecurrenceDay;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
