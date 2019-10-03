using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x21C3E59207C95DEB, NameHash = 0xDBFECF3462D8A0FB)]
    public class GcRewardDisguisedProduct : NMSTemplate
    {
        public GcDefaultMissionProductEnum Default;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public string ID;
        [NMS(Size = 0x10)]
        public string DisplayAs;
        public int AmountMin;
        public int AmountMax;
    }
}
