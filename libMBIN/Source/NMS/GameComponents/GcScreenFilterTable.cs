using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3860, GUID = 0x4F7EFF6A2047FBFD, NameHash = 0xDDA2C2271A6ACA0B)]
    public class GcScreenFilterTable : NMSTemplate
    {
        [NMS(Size = 0x52, EnumType = typeof(GcScreenFilters.ScreenFilterEnum))]
        public GcScreenFilterData[] Filters;
    }
}
