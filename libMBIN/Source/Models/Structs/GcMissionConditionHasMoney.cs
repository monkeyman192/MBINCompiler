namespace libMBIN.Models.Structs
{
    public class GcMissionConditionHasMoney : NMSTemplate
    {
        public int Amount;
		public enum TestCurrencyEnum { Units, Nanites, Specials }
		public TestCurrencyEnum TestCurrency;
    }
}
