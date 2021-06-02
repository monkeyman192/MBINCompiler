using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0x83D2C4892CEFB3A3, NameHash = 0x252EDF07EC993BBF)]
    public class GcYearlyRecurrence : NMSTemplate
    {
        public int RecurrenceMinute;
        public int RecurrenceHour;
        public int RecurrenceDay;
        public GcMonth RecurrenceMonth;
        public NMSString0x80 DebugText;
    }
}
