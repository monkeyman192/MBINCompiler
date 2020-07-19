using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1B80, GUID = 0x4F7EFF6A2047FBFD, NameHash = 0xDDA2C2271A6ACA0B)]
    public class GcScreenFilterTable : NMSTemplate
    {
        [NMS(Size = 0x28, EnumType = typeof(GcScreenFilters.ScreenFiltersEnum))]
        public GcScreenFilterData[] Filters;
    }
}
