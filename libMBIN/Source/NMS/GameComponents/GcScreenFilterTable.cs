using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x17A0, GUID = 0x57B37B2F30CA8EBA, NameHash = 0xDDA2C2271A6ACA0B)]
    public class GcScreenFilterTable : NMSTemplate
    {
        [NMS(Size = 0x24, EnumType = typeof(GcScreenFilters.ScreenFiltersEnum))]
        public GcScreenFilterData[] Filters;
    }
}
