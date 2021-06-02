using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0x54366264A902610C, NameHash = 0x748EDC86AFA4F5A3)]
    public class GcEntitlementRewardData : NMSTemplate
    {
        public NMSString0x10 EntitlementId;

        public NMSString0x10 RewardId;

        public NMSString0x20A Name;

        public NMSString0x20A Error;
    }
}