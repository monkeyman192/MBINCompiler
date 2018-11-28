using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS( Size = 0x4, GUID = 0x907C3AD8EF881E53 )]
    public class GcTradingClass : NMSTemplate
    {
		public enum TradingClassEnum { Mining, HighTech, Trading, Manufacturing, Fusion, Scientific, PowerGeneration }
		public TradingClassEnum TradingClass;
    }
}
