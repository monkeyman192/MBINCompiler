using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8D8DFCA6E2D8E78, NameHash = 0xE0C6D820)]
    public class GcConsumableItem : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x000 */ public NMSString0x20A CustomOSD;
        [NMS(Index = 0)]
        /* 0x020 */ public NMSString0x10 ID;
        [NMS(Index = 12)]
        /* 0x030 */ public NMSString0x10 RequiresMissionActive;
        [NMS(Index = 1)]
        /* 0x040 */ public NMSString0x10 RewardID;
        [NMS(Index = 14)]
        /* 0x050 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        [NMS(Index = 2)]
        /* 0x060 */ public NMSString0x10 TutorialRewardID;
        [NMS(Index = 6)]
        /* 0x070 */ public GcAudioWwiseEvents AudioEventOnOpen;
        [NMS(Index = 3)]
        /* 0x074 */ public NMSString0x40 ButtonLocID;
        [NMS(Index = 4)]
        /* 0x0B4 */ public NMSString0x40 ButtonSubLocID;
        [NMS(Index = 7)]
        /* 0x0F4 */ public NMSString0x40 RewardFailedLocID;
        [NMS(Index = 9)]
        /* 0x134 */ public bool AddCommunityTierClassIcon;
        [NMS(Index = 5)]
        /* 0x135 */ public bool CloseInventoryWhenUsed;
        [NMS(Index = 8)]
        /* 0x136 */ public bool DestroyItemWhenConsumed;
        [NMS(Index = 13)]
        /* 0x137 */ public bool OverrideMissionMustBeSelected;
        [NMS(Index = 10)]
        /* 0x138 */ public bool SuppressResourceMessage;
    }
}
