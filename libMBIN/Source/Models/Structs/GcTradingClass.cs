namespace libMBIN.Models.Structs
{
    public class GcTradingClass : NMSTemplate
    {
		public enum TradingClassEnum { Mining, HighTech, Trading, Manufacturing, Fusion, Scientific, PowerGeneration }
		public TradingClassEnum TradingClass;
    }
}
