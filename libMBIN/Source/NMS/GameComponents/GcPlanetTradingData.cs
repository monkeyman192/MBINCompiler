using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9C7E079488671B73, NameHash = 0x645C709EAB3A1F55)]
    public class GcPlanetTradingData : NMSTemplate
    {
        public GcWealthClass WealthClass;
        public GcTradingClass TradingClass;
    }
}
