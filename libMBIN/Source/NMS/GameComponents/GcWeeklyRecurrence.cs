using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA57E8D6B89E55536, NameHash = 0xB686CC9F04962DFA)]
    public class GcWeeklyRecurrence : NMSTemplate
    {
        /* 0x0 */ public GcDay RecurrenceDay;
        /* 0x4 */ public int RecurrenceHour;
        /* 0x8 */ public int RecurrenceMinute;
        /* 0xC */ public NMSString0x80 DebugText;
    }
}
