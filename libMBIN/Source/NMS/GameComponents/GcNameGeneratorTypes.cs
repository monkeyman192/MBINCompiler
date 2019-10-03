using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB7817719FAB35115, NameHash = 0xC9FA06A9CF2CE65D)]
    public class GcNameGeneratorTypes : NMSTemplate
    {
		public enum MarkovSelectorEnum { Generic, Mineral, Region_NO, Region_RU, Region_CH, Region_JP, Region_LT, Region_FL }
		public MarkovSelectorEnum MarkovSelector;
    }
}
