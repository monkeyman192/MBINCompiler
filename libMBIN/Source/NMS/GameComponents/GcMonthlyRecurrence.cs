using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8C, GUID = 0xD310F208B79E9905, NameHash = 0x5CB869EED69B0A9)]
    public class GcMonthlyRecurrence : NMSTemplate
    {
        public int RecurrenceMinute;
        public int RecurrenceHour;
        public int RecurrenceDay;
        public NMSString0x80 DebugText;
    }
}
