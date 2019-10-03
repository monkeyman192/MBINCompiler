using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBCC12AC4DCFC035C, NameHash = 0xABEDBCE191703616)]
    public class GcTradeCategory : NMSTemplate
    {
		public enum TradingClassEnum { Mineral, Tech, Commodity, Component, Alloy, Exotic, Energy, None }
		public TradingClassEnum TradingClass;
    }
}
