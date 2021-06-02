using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x833A881A215D0E67, NameHash = 0x71B9EA7C3B789C6B)]
    public class GcRewardMissionSeeded : NMSTemplate
    {
        public NMSString0x10 Mission;
        public NMSString0x10 MissionCreative;
        public bool InheritActiveMultiplayerMissionSeed;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
