using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA00D498ACCB0FEA0, NameHash = 0xDA5F4DFE0527A693)]
    public class GcConsumableItem : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A CustomOSD;
        /* 0x020 */ public NMSString0x10 ID;
        /* 0x030 */ public NMSString0x10 RequiresMissionActive;
        /* 0x040 */ public NMSString0x10 RewardID;
        /* 0x050 */ public NMSString0x10 TutorialRewardID;
        /* 0x060 */ public GcAudioWwiseEvents AudioEventOnOpen;
        /* 0x064 */ public NMSString0x40 ButtonLocID;
        /* 0x0A4 */ public NMSString0x40 ButtonSubLocID;
        /* 0x0E4 */ public NMSString0x40 RewardFailedLocID;
        /* 0x124 */ public bool AddCommunityTierClassIcon;
        /* 0x125 */ public bool CloseInventoryWhenUsed;
        /* 0x126 */ public bool DestroyItemWhenConsumed;
        /* 0x127 */ public bool SuppressResourceMessage;
    }
}
