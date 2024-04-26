namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x64F01908C5305F87, NameHash = 0xE8931C5D607657DE)]
    public class GcDay : NMSTemplate
    {
        // size: 0x7
        public enum DayEnum : uint {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DayEnum Day;
    }
}
