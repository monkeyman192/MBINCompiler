using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x89A4A807075326E0, NameHash = 0x9F1240710CA7E631)]
    public class GcRewardStatDiff : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string CoreStat;
        [NMS(Size = 0x10)]
        public string CompareAndSetStat;
        [NMS(Size = 0x10)]
        public string SubstanceID;
		public GcCurrency RewardCurrency;
        public int AmountPerStat;
        public int StatRewardCap;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
