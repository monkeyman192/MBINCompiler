namespace libMBIN.Models.Structs
{
    public class GcCostMoney : NMSTemplate
    {
        public int Cost;
		public enum CostCurrencyEnum { Units, Nanites, Specials }
		public CostCurrencyEnum CostCurrency;
    }
}
