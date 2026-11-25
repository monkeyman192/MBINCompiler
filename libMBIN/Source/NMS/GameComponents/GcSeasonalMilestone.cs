using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x68AE8F9F9E5D2C82, NameHash = 0xF300EF56)]
    public class GcSeasonalMilestone : NMSTemplate
    {
        [NMS(Index = 28)]
        /* 0x000 */ public GcSeasonalMilestoneEncryption Encryption;
        [NMS(Index = 6)]
        /* 0x0A8 */ public NMSString0x20A CantRewardMessage;
        [NMS(Index = 3)]
        /* 0x0C8 */ public NMSString0x20A Description;
        [NMS(Index = 4)]
        /* 0x0E8 */ public NMSString0x20A DescriptionDone;
        [NMS(Index = 5)]
        /* 0x108 */ public NMSString0x20A LogDescOverride;
        [NMS(Index = 1)]
        /* 0x128 */ public NMSString0x20A Title;
        [NMS(Index = 2)]
        /* 0x148 */ public NMSString0x20A TitleUpper;
        [NMS(Index = 12)]
        /* 0x168 */ public TkTextureResource Icon;
        [NMS(Index = 13)]
        /* 0x180 */ public TkTextureResource IconGrey;
        [NMS(Index = 14)]
        /* 0x198 */ public TkTextureResource MissionIcon;
        [NMS(Index = 16)]
        /* 0x1B0 */ public TkTextureResource MissionIconNotSelected;
        [NMS(Index = 15)]
        /* 0x1C8 */ public TkTextureResource MissionIconSelected;
        [NMS(Index = 27)]
        /* 0x1E0 */ public List<NMSString0x10> BlockedMultiplayerMissions;
        [NMS(Index = 7)]
        /* 0x1F0 */ public NMSString0x10 IdToUseInMissionData;
        [NMS(Index = 0)]
        /* 0x200 */ public NMSString0x10 Mission;
        [NMS(Index = 17)]
        /* 0x210 */ public NMSString0x10 Reward;
        [NMS(Index = 18)]
        /* 0x220 */ public NMSString0x10 RewardSwitchAlt;
        [NMS(Index = 29)]
        /* 0x230 */ public List<GcSeasonalMilestoneTeamOverrides> TeamOverrides;
        [NMS(Index = 8)]
        /* 0x240 */ public float Amount;
        [NMS(Index = 25)]
        /* 0x244 */ public int BlockRendezvousMilestoneSeed;
        [NMS(Index = 10)]
        /* 0x248 */ public int MilestoneIndex;
        [NMS(Index = 11)]
        /* 0x24C */ public int RendezvousIndex;
        [NMS(Index = 9)]
        /* 0x250 */ public int StageIndex;
        [NMS(Index = 20)]
        /* 0x254 */ public NMSString0x200 CantClaimRewardDescription;
        [NMS(Index = 19)]
        /* 0x454 */ public NMSString0x200 RewardDescription;
        [NMS(Index = 26)]
        /* 0x654 */ public bool DontAttemptFallbackTextSubs;
        [NMS(Index = 22)]
        /* 0x655 */ public bool GreyIfCantStart;
        [NMS(Index = 21)]
        /* 0x656 */ public bool IsOptional;
        [NMS(Index = 23)]
        /* 0x657 */ public bool IsRendezvous;
        [NMS(Index = 24)]
        /* 0x658 */ public bool IsStageControl;
    }
}
