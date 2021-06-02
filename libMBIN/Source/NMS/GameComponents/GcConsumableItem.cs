using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x100, GUID = 0xC22686ED58582AC2, NameHash = 0xDA5F4DFE0527A693)]
    public class GcConsumableItem : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x10 RewardID;
        /* 0x20 */ public NMSString0x10 TutorialRewardID;
        /* 0x30 */ public NMSString0x40 ButtonLocID;
        /* 0x70 */ public NMSString0x40 ButtonSubLocID;
        /* 0xB0 */ public bool CloseInventoryWhenUsed;
        /* 0xB4 */ public GcAudioWwiseEvents AudioEventOnOpen;
        /* 0xB8 */ public NMSString0x40 RewardFailedLocID;
        /* 0xF8 */ public bool DestroyItemWhenConsumed;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0xF9 */ public byte[] EndPadding;
    }
}
