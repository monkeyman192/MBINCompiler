using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4A0, GUID = 0x925D3DBC080972C6, NameHash = 0xFAE86B2801335B6D)]
    public class GcGenericMissionSequence : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string MissionID;
		public enum MissionClassEnum { Primary, Secondary, ChainedSecondary, Guide, Wiki }
		/* 0x010 */ public MissionClassEnum MissionClass;

        /* 0x014 */ public bool MissionIsCritical;
        [NMS(Size = 0x20)]
        /* 0x015 */ public string MissionObjective;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x035 */ public byte[] Padding35;

        /* 0x038 */ public GcNumberedTextList MissionTitles;
        /* 0x05C */ public GcNumberedTextList MissionSubtitles;
        /* 0x080 */ public GcNumberedTextList MissionDescriptions;
        /* 0x0A4 */ public GcNumberedTextList MissionProcDescriptionHeader;
        /* 0x0C8 */ public GcNumberedTextList MissionProcDescriptionA;
        /* 0x0EC */ public GcNumberedTextList MissionProcDescriptionB;
        /* 0x110 */ public GcNumberedTextList MissionProcDescriptionC;

        /* 0x134 */ public TkTextureResource MissionIcon;
        /* 0x1B8 */ public TkTextureResource MissionIconSelected;
        /* 0x23C */ public TkTextureResource MissionIconNotSelected;

        /* 0x2C0 */ public int MissionPriority;
        /* 0x2C4 */ public GcMissionCategory MissionCategory;
        /* 0x2C8 */ public GcMissionPageHint MissionPageHint;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2CC */ public byte[] Padding2CC;
        [NMS(Size = 0x20)]
        /* 0x2D0 */ public string MissionPageLocID;
        [NMS(Size = 0x10)]
        /* 0x2F0 */ public string MissionBuildMenuHint;

        /* 0x300 */ public bool MissionHasColourOverride;
        /* 0x310 */ public Colour MissionColourOverride;

        /* 0x320 */ public GcDefaultMissionItemsTable DefaultItems;

        /* 0x360 */ public bool PrefixTitle;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x361 */ public byte[] Padding331;
        [NMS(Size = 0x10)]
        /* 0x368 */ public string NextMissionHint;
		public enum MessageCompleteEnum { Default, Always, Never }
		/* 0x378 */ public MessageCompleteEnum MessageComplete;
		public enum MessageStartEnum { Default, Always, Never }
		/* 0x37C */ public MessageStartEnum MessageStart;

        /* 0x380 */ public GcMissionBoardOptions MissionBoardOptions;

		public enum AutoStartEnum { None, AllModes, NotCreative, Survival, Creative, OnSelected }
		/* 0x400 */ public AutoStartEnum AutoStart;
        /* 0x404 */ public bool RestartOnCompletion;
        /* 0x405 */ public bool CancelSetsComplete;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x3D6 */ public byte[] Padding3D6;

        /* 0x408 */ public List<GcAlienPuzzleEntry> Dialog;
        /* 0x418 */ public List<GcScanEventData> ScanEvents;
        /* 0x428 */ public List<GcGenericRewardTableEntry> Rewards;
        /* 0x438 */ public List<GcCostTableEntry> Costs;

        /* 0x448 */ public GcMissionConditionTest StartConditionTest;
        /* 0x44C */ public GcMissionConditionTest CancelConditionTest;
        /* 0x450 */ public bool StartIsCancel;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x451 */ public byte[] Padding451;

        /* 0x458 */ public List<NMSTemplate> StartingConditions;
        /* 0x468 */ public List<NMSTemplate> CancelingConditions;
        /* 0x478 */ public List<GcGenericMissionVersionProgress> FinalStageVersions;
        /* 0x488 */ public List<GcGenericMissionStage> Stages;
        /* 0x498 */ public bool ForcesPageHint;
        /* 0x499 */ public bool ForcesBuildMenuHint;
        /* 0x49A */ public bool IsProceduralAllowed;
        /* 0x49B */ public bool IsRecurring;
        /* 0x49C */ public bool IsLegacy;
        /* 0x49D */ public bool BlocksPinning;
        /* 0x49E */ public bool TelemetryUpload;

        [NMS(Size = 0x1, Ignore = true)]
        /* 0x49F */ public byte[] EndPadding;
    }
}
