using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8245DBA6B592BCD, NameHash = 0xA94C0C48)]
    public class GcDate : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public int Day;
        [NMS(Index = 1)]
        /* 0x04 */ public int Hour;
        [NMS(Index = 0)]
        /* 0x08 */ public int Minute;
        [NMS(Index = 3)]
        /* 0x0C */ public GcMonth Month;
        [NMS(Index = 4)]
        /* 0x10 */ public int Year;
    }
}
