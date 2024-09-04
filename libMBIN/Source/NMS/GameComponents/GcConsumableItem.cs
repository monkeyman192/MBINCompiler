using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D451DED7FE8C678, NameHash = 0xE0C6D820)]
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
        [NMS(Index = 2)]
        /* 0x050 */ public NMSString0x10 TutorialRewardID;
        [NMS(Index = 6)]
        /* 0x060 */ public GcAudioWwiseEvents AudioEventOnOpen;
        [NMS(Index = 3)]
        /* 0x064 */ public NMSString0x40 ButtonLocID;
        [NMS(Index = 4)]
        /* 0x0A4 */ public NMSString0x40 ButtonSubLocID;
        [NMS(Index = 7)]
        /* 0x0E4 */ public NMSString0x40 RewardFailedLocID;
        [NMS(Index = 9)]
        /* 0x124 */ public bool AddCommunityTierClassIcon;
        [NMS(Index = 5)]
        /* 0x125 */ public bool CloseInventoryWhenUsed;
        [NMS(Index = 8)]
        /* 0x126 */ public bool DestroyItemWhenConsumed;
        [NMS(Index = 10)]
        /* 0x127 */ public bool SuppressResourceMessage;
    }
}
