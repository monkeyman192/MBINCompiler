namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8355A64043DE7A7F, NameHash = 0x182075982F91C5F8)]
    public class GcJourneyCategoryType : NMSTemplate
    {
        // size: 0x4
        public enum CategoryTypeEnum : uint {
            Journey,
            SeasonHistory,
            Race,
            Guild,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CategoryTypeEnum CategoryType;
    }
}
