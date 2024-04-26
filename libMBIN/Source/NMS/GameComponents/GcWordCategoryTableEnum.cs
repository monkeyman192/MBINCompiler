namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54D577DD4FC76430, NameHash = 0x4F41C5DCED5937F1)]
    public class GcWordCategoryTableEnum : NMSTemplate
    {
        // size: 0x7
        public enum wordcategorytableEnumEnum : uint {
            MISC,
            DIRECTIONS,
            HELP,
            TRADE,
            LORE,
            TECH,
            THREAT,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public wordcategorytableEnumEnum wordcategorytableEnum;
    }
}
