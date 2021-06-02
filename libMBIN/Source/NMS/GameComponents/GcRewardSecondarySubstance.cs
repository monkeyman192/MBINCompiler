using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xC23149018DEB60, NameHash = 0x793796BDCC72805)]
    public class GcRewardSecondarySubstance : NMSTemplate
    {
        public NMSString0x10 ID;
        public float Amountfactor;
        public bool RewardAsBlobs;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}