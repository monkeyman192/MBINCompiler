namespace libMBIN.Models.Structs
{
    public class GcTradeCategory : NMSTemplate
    {
		public enum TradingClassEnum { Mineral, Tech, Commodity, Component, Alloy, Exotic, Energy, None }
		public TradingClassEnum TradingClass;
    }
}
