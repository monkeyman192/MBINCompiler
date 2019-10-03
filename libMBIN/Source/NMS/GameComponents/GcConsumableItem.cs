using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xB8, GUID = 0xBFEAEB66CB032F28, NameHash = 0xDA5F4DFE0527A693)]
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
    }
}
