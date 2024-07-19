using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3ED4679ABB559693, NameHash = 0xCB317452)]
    public class GcStoryUtilityOverride : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Name;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 Reward;
        [NMS(Index = 2)]
        /* 0x30 */ public List<GcRewardMissionOverride> SpecificRewardOverrideTable;
    }
}
