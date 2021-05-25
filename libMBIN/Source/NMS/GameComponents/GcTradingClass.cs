using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x907C3AD8EF881E53, NameHash = 0x9E3AE80CF84700A6)]
    public class GcTradingClass : NMSTemplate
    {
        // size: 0x7
		public enum TradingClassEnum { Mining, HighTech, Trading, Manufacturing, Fusion, Scientific, PowerGeneration }
		public TradingClassEnum TradingClass;
    }
}