using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xFEC2385BD37C76F6, NameHash = 0xCFC064FBFD501A40)]
    public class GcRewardMissionOverride : NMSTemplate
    {
        public NMSString0x10 Mission;
        public NMSString0x10 Reward;
    }
}