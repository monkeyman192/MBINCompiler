using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x100, GUID = 0xC22686ED58582AC2, NameHash = 0xDA5F4DFE0527A693)]
    public class GcConsumableItem : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string RewardID;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string TutorialRewardID;
        [NMS(Size = 0x40)]
        /* 0x30 */ public string ButtonLocID;
        [NMS(Size = 0x40)]
        /* 0x70 */ public string ButtonSubLocID;
        /* 0xB0 */ public bool CloseInventoryWhenUsed;
        /* 0xB4 */ public GcAudioWwiseEvents AudioEventOnOpen;
        [NMS(Size = 0x40)]
        /* 0xB8 */ public string RewardFailedLocID;
        /* 0xF8 */ public bool DestroyItemWhenConsumed;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0xF9 */ public byte[] EndPadding;
    }
}
