using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4ED9AB261420750B, NameHash = 0x4EDC167332F6B824)]
    public class GcSeasonalMilestone : NMSTemplate
    {
        /* 0x000 */ public GcSeasonalMilestoneEncryption Encryption;
        /* 0x180 */ public NMSString0x20A CantRewardMessage;
        /* 0x1A0 */ public NMSString0x20A Description;
        /* 0x1C0 */ public NMSString0x20A DescriptionDone;
        /* 0x1E0 */ public NMSString0x20A Title;
        /* 0x200 */ public NMSString0x20A TitleUpper;
        /* 0x220 */ public NMSString0x10 IdToUseInMissionData;
        /* 0x230 */ public NMSString0x10 Mission;
        /* 0x240 */ public NMSString0x10 Reward;
        /* 0x250 */ public NMSString0x10 RewardSwitchAlt;
        /* 0x260 */ public TkTextureResource Icon;
        /* 0x2E4 */ public TkTextureResource IconGrey;
        /* 0x368 */ public TkTextureResource MissionIcon;
        /* 0x3EC */ public TkTextureResource MissionIconNotSelected;
        /* 0x470 */ public TkTextureResource MissionIconSelected;
        /* 0x4F4 */ public float Amount;
        /* 0x4F8 */ public int BlockRendezvousMilestoneSeed;
        /* 0x4FC */ public int MilestoneIndex;
        /* 0x500 */ public int RendezvousIndex;
        /* 0x504 */ public int StageIndex;
        /* 0x508 */ public NMSString0x200 CantClaimRewardDescription;
        /* 0x708 */ public NMSString0x200 RewardDescription;
        /* 0x908 */ public bool DontAttemptFallbackTextSubs;
        /* 0x909 */ public bool GreyIfCantStart;
        /* 0x90A */ public bool IsOptional;
        /* 0x90B */ public bool IsRendezvous;
        /* 0x90C */ public bool IsStageControl;
    }
}
