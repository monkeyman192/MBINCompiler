using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF87E7FCDE3852B45, NameHash = 0x4EDC167332F6B824)]
    public class GcSeasonalMilestone : NMSTemplate
    {
        [NMS(Index = 26)]
        /* 0x000 */ public GcSeasonalMilestoneEncryption Encryption;
        [NMS(Index = 5)]
        /* 0x180 */ public NMSString0x20A CantRewardMessage;
        [NMS(Index = 3)]
        /* 0x1A0 */ public NMSString0x20A Description;
        [NMS(Index = 4)]
        /* 0x1C0 */ public NMSString0x20A DescriptionDone;
        [NMS(Index = 1)]
        /* 0x1E0 */ public NMSString0x20A Title;
        [NMS(Index = 2)]
        /* 0x200 */ public NMSString0x20A TitleUpper;
        [NMS(Index = 6)]
        /* 0x220 */ public NMSString0x10 IdToUseInMissionData;
        [NMS(Index = 0)]
        /* 0x230 */ public NMSString0x10 Mission;
        [NMS(Index = 16)]
        /* 0x240 */ public NMSString0x10 Reward;
        [NMS(Index = 17)]
        /* 0x250 */ public NMSString0x10 RewardSwitchAlt;
        [NMS(Index = 11)]
        /* 0x260 */ public TkTextureResource Icon;
        [NMS(Index = 12)]
        /* 0x2E4 */ public TkTextureResource IconGrey;
        [NMS(Index = 13)]
        /* 0x368 */ public TkTextureResource MissionIcon;
        [NMS(Index = 15)]
        /* 0x3EC */ public TkTextureResource MissionIconNotSelected;
        [NMS(Index = 14)]
        /* 0x470 */ public TkTextureResource MissionIconSelected;
        [NMS(Index = 7)]
        /* 0x4F4 */ public float Amount;
        [NMS(Index = 24)]
        /* 0x4F8 */ public int BlockRendezvousMilestoneSeed;
        [NMS(Index = 9)]
        /* 0x4FC */ public int MilestoneIndex;
        [NMS(Index = 10)]
        /* 0x500 */ public int RendezvousIndex;
        [NMS(Index = 8)]
        /* 0x504 */ public int StageIndex;
        [NMS(Index = 19)]
        /* 0x508 */ public NMSString0x200 CantClaimRewardDescription;
        [NMS(Index = 18)]
        /* 0x708 */ public NMSString0x200 RewardDescription;
        [NMS(Index = 25)]
        /* 0x908 */ public bool DontAttemptFallbackTextSubs;
        [NMS(Index = 21)]
        /* 0x909 */ public bool GreyIfCantStart;
        [NMS(Index = 20)]
        /* 0x90A */ public bool IsOptional;
        [NMS(Index = 22)]
        /* 0x90B */ public bool IsRendezvous;
        [NMS(Index = 23)]
        /* 0x90C */ public bool IsStageControl;
    }
}
