namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8C)]
    public class GcWeeklyRecurrence : NMSTemplate
    {
        public int RecurrenceMinute;
        public int RecurrenceHour;
        public GcDay RecurrenceDay;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
