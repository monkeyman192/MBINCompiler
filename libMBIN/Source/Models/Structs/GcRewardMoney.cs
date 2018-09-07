namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xC)]
    public class GcRewardMoney : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
		public enum CurrencyEnum { Units, Nanites, Specials }
		public CurrencyEnum Currency;
    }
}
