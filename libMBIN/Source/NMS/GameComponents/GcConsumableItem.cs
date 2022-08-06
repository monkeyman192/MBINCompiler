using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71C3463D3D0B43F1, NameHash = 0xDA5F4DFE0527A693)]
    public class GcConsumableItem : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ID;
        /* 0x010 */ public NMSString0x10 RewardID;
        /* 0x020 */ public NMSString0x10 TutorialRewardID;
        /* 0x030 */ public NMSString0x40 ButtonLocID;
        /* 0x070 */ public NMSString0x40 ButtonSubLocID;
        /* 0x0B0 */ public bool CloseInventoryWhenUsed;
        /* 0x0B4 */ public GcAudioWwiseEvents AudioEventOnOpen;
        /* 0x0B8 */ public NMSString0x40 RewardFailedLocID;
        /* 0x0F8 */ public bool DestroyItemWhenConsumed;
        /* 0x0F9 */ public bool AddCommunityTierClassIcon;
        /* 0x0FA */ public bool SuppressResourceMessage;
        /* 0x100 */ public NMSString0x20A CustomOSD;
    }
}
