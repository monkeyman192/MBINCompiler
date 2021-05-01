using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xC23149018DEB60, NameHash = 0x793796BDCC72805)]
    public class GcRewardSecondarySubstance : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        public float AmountFactor;
        public bool RewardAsBlobs;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}