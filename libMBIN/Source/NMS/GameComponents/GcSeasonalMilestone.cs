using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DA5BF204F840BC0, NameHash = 0xF300EF56)]
    public class GcSeasonalMilestone : NMSTemplate
    {
        [NMS(Index = 26)]
        /* 0x000 */ public GcSeasonalMilestoneEncryption Encryption;
        [NMS(Index = 5)]
        /* 0x0A8 */ public NMSString0x20A CantRewardMessage;
        [NMS(Index = 3)]
        /* 0x0C8 */ public NMSString0x20A Description;
        [NMS(Index = 4)]
        /* 0x0E8 */ public NMSString0x20A DescriptionDone;
        [NMS(Index = 1)]
        /* 0x108 */ public NMSString0x20A Title;
        [NMS(Index = 2)]
        /* 0x128 */ public NMSString0x20A TitleUpper;
        [NMS(Index = 11)]
        /* 0x148 */ public TkTextureResource Icon;
        [NMS(Index = 12)]
        /* 0x160 */ public TkTextureResource IconGrey;
        [NMS(Index = 13)]
        /* 0x178 */ public TkTextureResource MissionIcon;
        [NMS(Index = 15)]
        /* 0x190 */ public TkTextureResource MissionIconNotSelected;
        [NMS(Index = 14)]
        /* 0x1A8 */ public TkTextureResource MissionIconSelected;
        [NMS(Index = 6)]
        /* 0x1C0 */ public NMSString0x10 IdToUseInMissionData;
        [NMS(Index = 0)]
        /* 0x1D0 */ public NMSString0x10 Mission;
        [NMS(Index = 16)]
        /* 0x1E0 */ public NMSString0x10 Reward;
        [NMS(Index = 17)]
        /* 0x1F0 */ public NMSString0x10 RewardSwitchAlt;
        [NMS(Index = 7)]
        /* 0x200 */ public float Amount;
        [NMS(Index = 24)]
        /* 0x204 */ public int BlockRendezvousMilestoneSeed;
        [NMS(Index = 9)]
        /* 0x208 */ public int MilestoneIndex;
        [NMS(Index = 10)]
        /* 0x20C */ public int RendezvousIndex;
        [NMS(Index = 8)]
        /* 0x210 */ public int StageIndex;
        [NMS(Index = 19)]
        /* 0x214 */ public NMSString0x200 CantClaimRewardDescription;
        [NMS(Index = 18)]
        /* 0x414 */ public NMSString0x200 RewardDescription;
        [NMS(Index = 25)]
        /* 0x614 */ public bool DontAttemptFallbackTextSubs;
        [NMS(Index = 21)]
        /* 0x615 */ public bool GreyIfCantStart;
        [NMS(Index = 20)]
        /* 0x616 */ public bool IsOptional;
        [NMS(Index = 22)]
        /* 0x617 */ public bool IsRendezvous;
        [NMS(Index = 23)]
        /* 0x618 */ public bool IsStageControl;
    }
}
