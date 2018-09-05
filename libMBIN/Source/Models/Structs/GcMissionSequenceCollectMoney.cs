namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x108)]
    public class GcMissionSequenceCollectMoney : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        public int Amount;
        public int CollectCurrency;
        public string[] CollectCurrencyValues()
        {
            return new[] { "Units", "Nanites", "Specials"};
        }
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
