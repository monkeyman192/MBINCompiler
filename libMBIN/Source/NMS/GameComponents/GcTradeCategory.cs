using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS( Size = 0x4, GUID = 0xBCC12AC4DCFC035C )]
    public class GcTradeCategory : NMSTemplate
    {
		public enum TradingClassEnum { Mineral, Tech, Commodity, Component, Alloy, Exotic, Energy, None }
		public TradingClassEnum TradingClass;
    }
}
