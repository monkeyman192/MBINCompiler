namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x40)]
    public class GcRewardStatDiff : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string CoreStat;
        [NMS(Size = 0x10)]
        public string CompareAndSetStat;
        [NMS(Size = 0x10)]
        public string SubstanceID;
		public enum RewardCurrencyEnum { None, Units, Nanites, Specials }
		public RewardCurrencyEnum RewardCurrency;
        public int AmountPerStat;
        public int StatRewardCap;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
