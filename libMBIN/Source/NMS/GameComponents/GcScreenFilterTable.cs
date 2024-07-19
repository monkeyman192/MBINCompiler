using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF588B2DD01843D1, NameHash = 0x4E8AAD10)]
    public class GcScreenFilterTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x53, EnumType = typeof(GcScreenFilters.ScreenFilterEnum))]
        /* 0x0 */ public GcScreenFilterData[] Filters;
    }
}
