using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFEC2385BD37C76F6, NameHash = 0xCFC064FBFD501A40)]
    public class GcRewardMissionOverride : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Mission;
        [NMS(Size = 0x10)]
        public string Reward;
    }
}
