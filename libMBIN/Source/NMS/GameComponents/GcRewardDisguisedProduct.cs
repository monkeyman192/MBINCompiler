using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDE62A068FABD286A, NameHash = 0xDBFECF3462D8A0FB)]
    public class GcRewardDisguisedProduct : NMSTemplate
    {
        public GcDefaultMissionProductEnum Default;
        public NMSString0x10 ID;
        public NMSString0x10 DisplayAs;
        public NMSString0x10 AwardDisplayIDDuringMission;
        public int AmountMin;
        public int AmountMax;
    }
}
