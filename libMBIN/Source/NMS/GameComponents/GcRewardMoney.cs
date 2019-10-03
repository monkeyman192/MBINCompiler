using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x9DC54E9B68B7648, NameHash = 0x2B59E601DE0BDEF9)]
    public class GcRewardMoney : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
		public GcCurrency Currency;
    }
}
