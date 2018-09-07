namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x108)]
    public class GcMissionSequenceCollectMoney : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        public int Amount;
		public enum CollectCurrencyEnum { Units, Nanites, Specials }
		public CollectCurrencyEnum CollectCurrency;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
