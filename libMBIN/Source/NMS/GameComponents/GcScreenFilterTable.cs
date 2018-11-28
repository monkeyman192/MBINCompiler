using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1650, GUID = 0x57B37B2F30CA8EBA)]
    public class GcScreenFilterTable : NMSTemplate
    {
        [NMS( EnumType = typeof( GcScreenFilters.ScreenFiltersEnum ) )]
        public GcScreenFilterData[] Filters;
    }
}
