using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9410A15AC901918E, NameHash = 0xCB317452)]
    public class GcStoryUtilityOverride : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Name;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x10 Reward;
        [NMS(Index = 4)]
        /* 0x30 */ public List<GcRewardMissionOverride> SpecificRewardOverrideTable;
        [NMS(Index = 1)]
        /* 0x40 */ public List<NMSString0x20A> StoryUtilityTags;
        [NMS(Index = 0)]
        /* 0x50 */ public bool NoInteractionUnlessOverriden;
    }
}
