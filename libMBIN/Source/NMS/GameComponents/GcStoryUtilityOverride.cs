using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE860B660F4C11F, NameHash = 0xCB317452)]
    public class GcStoryUtilityOverride : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x20A DefaultPuzzle;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A Name;
        [NMS(Index = 3)]
        /* 0x40 */ public NMSString0x20A Subtitle;
        [NMS(Index = 5)]
        /* 0x60 */ public NMSString0x10 Reward;
        [NMS(Index = 7)]
        /* 0x70 */ public List<GcRewardMissionOverride> SpecificRewardOverrideTable;
        [NMS(Index = 1)]
        /* 0x80 */ public List<NMSString0x20A> StoryUtilityTags;
        [NMS(Index = 4)]
        /* 0x90 */ public GcScannerBuildingIconTypes IntermediateInteractionIcon;
        [NMS(Index = 0)]
        /* 0x94 */ public bool NoInteractionUnlessOverriden;
    }
}
