using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x208C750E2351B660, NameHash = 0xABEDBCE191703616)]
    public class GcTradeCategory : NMSTemplate
    {
        // size: 0x9
		public enum TradeCategoryEnum { Mineral, Tech, Commodity, Component, Alloy, Exotic, Energy, None, SpecialShop }
		public TradeCategoryEnum TradeCategory;
    }
}