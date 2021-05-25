using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4B0, GUID = 0x8C5CCFEA425668CE, NameHash = 0xFAE86B2801335B6D)]
    public class GcGenericMissionSequence : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string MissionID;
		public enum MissionClassEnum { Primary, Secondary, ChainedSecondary, Guide, Wiki, Seasonal }
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
        /* 0x320 */ public int BeginCheckFrequency;
        /* 0x328 */ public GcDefaultMissionItemsTable DefaultItems;
        /* 0x368 */ public bool PrefixTitle;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x369 */ public byte[] Padding339;
        [NMS(Size = 0x10)]
        /* 0x370 */ public string NextMissionHint;
		public enum MessageCompleteEnum { Default, Always, Never }
		/* 0x380 */ public MessageCompleteEnum MessageComplete;
		public enum MessageStartEnum { Default, Always, Never }
		/* 0x384 */ public MessageStartEnum MessageStart;
        /* 0x388 */ public GcMissionBoardOptions MissionBoardOptions;
		public enum AutoStartEnum { None, AllModes, NotCreative, Survival, Creative, Seasonal, OnSelected }
		/* 0x408 */ public AutoStartEnum AutoStart;
        /* 0x40C */ public bool RestartOnCompletion;
        /* 0x40D */ public bool CancelSetsComplete;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x40E */ public byte[] Padding40E;
        /* 0x410 */ public List<GcAlienPuzzleEntry> Dialog;
        /* 0x420 */ public List<GcScanEventData> ScanEvents;
        /* 0x430 */ public List<GcGenericRewardTableEntry> Rewards;
        /* 0x440 */ public List<GcCostTableEntry> Costs;
        /* 0x450 */ public GcMissionConditionTest StartConditionTest;
        /* 0x454 */ public GcMissionConditionTest CancelConditionTest;
        /* 0x458 */ public bool StartIsCancel;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x459 */ public byte[] Padding459;
        /* 0x460 */ public List<NMSTemplate> StartingConditions;
        /* 0x470 */ public List<NMSTemplate> CancelingConditions;
        /* 0x480 */ public List<GcGenericMissionVersionProgress> FinalStageVersions;
        /* 0x490 */ public List<GcGenericMissionStage> Stages;
        /* 0x4A0 */ public bool ForcesPageHint;
        /* 0x4A1 */ public bool ForcesBuildMenuHint;
        /* 0x4A2 */ public bool IsProceduralAllowed;
        /* 0x4A3 */ public bool IsRecurring;
        /* 0x4A4 */ public bool IsLegacy;
        /* 0x4A5 */ public bool BlocksPinning;
        /* 0x4A6 */ public bool TelemetryUpload;
        /* 0x4A7 */ public bool UseSeasonTitleOverride;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x4A8 */ public byte[] EndPadding;
    }
}
