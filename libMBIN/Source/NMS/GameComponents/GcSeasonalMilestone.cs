using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8F8, GUID = 0x2EEEDEBB6597DC9E, NameHash = 0x4EDC167332F6B824)]
    public class GcSeasonalMilestone : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Mission;
        [NMS(Size = 0x20)]
        /* 0x010 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x030 */ public string TitleUpper;
        [NMS(Size = 0x20)]
        /* 0x050 */ public string Description;
        [NMS(Size = 0x20)]
        /* 0x070 */ public string DescriptionDone;
        [NMS(Size = 0x20)]
        /* 0x090 */ public string CantRewardMessage;
        [NMS(Size = 0x10)]
        /* 0x0B0 */ public string Id;
        /* 0x0C0 */ public float Amount;
        /* 0x0C4 */ public int StageIndex;
        /* 0x0C8 */ public int MilestoneIndex;
        /* 0x0CC */ public TkTextureResource Icon;
        /* 0x150 */ public TkTextureResource IconGrey;
        /* 0x1D4 */ public TkTextureResource MissionIcon;
        /* 0x258 */ public TkTextureResource MissionIconSelected;
        /* 0x2DC */ public TkTextureResource MissionIconNotSelected;
        [NMS(Size = 0x10)]
        /* 0x360 */ public string Reward;
        [NMS(Size = 0x200)]
        /* 0x370 */ public string RewardDescription;
        [NMS(Size = 0x200)]
        /* 0x570 */ public string CantClaimRewardDescription;
        /* 0x770 */ public bool IsRendezvous;
        /* 0x771 */ public bool IsStageControl;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x772 */ public byte[] Padding772;
        /* 0x778 */ public GcSeasonalMilestoneEncryption Encryption;
    }
}
