using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8C, GUID = 0xE475AF3D8A81BB1F, NameHash = 0xB686CC9F04962DFA)]
    public class GcWeeklyRecurrence : NMSTemplate
    {
        public int RecurrenceMinute;
        public int RecurrenceHour;
        public GcDay RecurrenceDay;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
