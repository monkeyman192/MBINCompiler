using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9C0682DB63DCCEDE, NameHash = 0xA4B99A409C0C214B)]
    public class GcDailyRecurrence : NMSTemplate
    {
        public int RecurrenceMinute;
        public int RecurrenceHour;
        public NMSString0x80 DebugText;
    }
}
