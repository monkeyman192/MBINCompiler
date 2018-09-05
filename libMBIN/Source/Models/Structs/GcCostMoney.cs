namespace libMBIN.Models.Structs
{
    public class GcCostMoney : NMSTemplate
    {
        public int Cost;
        public int CostCurrency;
        public string[] CostCurrencyValues()
        {
            return new[] { "Units", "Nanites", "Specials"};
        }
    }
}
