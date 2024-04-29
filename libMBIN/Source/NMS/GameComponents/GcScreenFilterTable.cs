using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1036E7A96830A4D9, NameHash = 0xDDA2C2271A6ACA0B)]
    public class GcScreenFilterTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x53, EnumType = typeof(GcScreenFilters.ScreenFilterEnum))]
        /* 0x0 */ public GcScreenFilterData[] Filters;
    }
}
