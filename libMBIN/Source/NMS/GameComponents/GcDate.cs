using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADA440911976CE1D, NameHash = 0x806D452BB139AB67)]
    public class GcDate : NMSTemplate
    {
        /* 0x00 */ public int Day;
        /* 0x04 */ public int Hour;
        /* 0x08 */ public int Minute;
        /* 0x0C */ public GcMonth Month;
        /* 0x10 */ public int Year;
    }
}
