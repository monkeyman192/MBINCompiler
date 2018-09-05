namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xC)]
    public class GcRewardMoney : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
        public int Currency;
        public string[] CurrencyValues()
        {
            return new[] { "Units", "Nanites", "Specials"};
        }
    }
}
