using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x25E17614ACBCC11C, NameHash = 0xE1C7E19E0F5C0C48)]
    public class GcStoryUtilityOverride : NMSTemplate
    {
        public NMSString0x20A Name;
        public NMSString0x10 Reward;
        public List<GcRewardMissionOverride> SpecificRewardOverrideTable;
    }
}
