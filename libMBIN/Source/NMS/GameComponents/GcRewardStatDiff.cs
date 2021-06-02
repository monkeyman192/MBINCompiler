using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x89A4A807075326E0, NameHash = 0x9F1240710CA7E631)]
    public class GcRewardStatDiff : NMSTemplate
    {
        public NMSString0x10 CoreStat;
        public NMSString0x10 CompareAndSetStat;
        public NMSString0x10 SubstanceID;
		public GcCurrency RewardCurrency;
        public int AmountPerStat;
        public int StatRewardCap;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
