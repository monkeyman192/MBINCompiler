namespace libMBIN.Models.Structs
{
    public class GcMissionConditionHasMoney : NMSTemplate
    {
        public int Amount;
        public int TestCurrency;
        public string[] TestCurrencyValues()
        {
            return new[] { "Units", "Nanites", "Specials" };
        }
    }
}
