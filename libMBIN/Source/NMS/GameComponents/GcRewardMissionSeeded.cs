using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x3F1C3B8071A30A5D, NameHash = 0x71B9EA7C3B789C6B)]
    public class GcRewardMissionSeeded : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Mission;
        [NMS(Size = 0x10)]
        public string MissionCreative;
    }
}
