using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8F8, GUID = 0x2EEEDEBB6597DC9E, NameHash = 0x4EDC167332F6B824)]
    public class GcSeasonalMilestone : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Mission;
        /* 0x010 */ public NMSString0x20A Title;
        /* 0x030 */ public NMSString0x20A TitleUpper;
        /* 0x050 */ public NMSString0x20A Description;
        /* 0x070 */ public NMSString0x20A DescriptionDone;
        /* 0x090 */ public NMSString0x20A CantRewardMessage;
        /* 0x0B0 */ public NMSString0x10 Id;
        /* 0x0C0 */ public float Amount;
        /* 0x0C4 */ public int StageIndex;
        /* 0x0C8 */ public int MilestoneIndex;
        /* 0x0CC */ public TkTextureResource Icon;
        /* 0x150 */ public TkTextureResource IconGrey;
        /* 0x1D4 */ public TkTextureResource MissionIcon;
        /* 0x258 */ public TkTextureResource MissionIconSelected;
        /* 0x2DC */ public TkTextureResource MissionIconNotSelected;
        /* 0x360 */ public NMSString0x10 Reward;
        /* 0x370 */ public NMSString0x200 RewardDescription;
        /* 0x570 */ public NMSString0x200 CantClaimRewardDescription;
        /* 0x770 */ public bool IsRendezvous;
        /* 0x771 */ public bool IsStageControl;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x772 */ public byte[] Padding772;
        /* 0x778 */ public GcSeasonalMilestoneEncryption Encryption;
    }
}
