using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96D4DC761A1242F, NameHash = 0xFAE86B2801335B6D)]
    public class GcGenericMissionSequence : NMSTemplate
    {
        /* 0x000 */ public Colour MissionColourOverride;
        /* 0x010 */ public GcTradeData TradingDataOverride;
        /* 0x0E0 */ public GcMissionBoardOptions MissionBoardOptions;
        /* 0x160 */ public GcSeasonalLogOverrides SeasonalLogTextOverrides;
        /* 0x1D0 */ public GcDefaultMissionItemsTable DefaultItems;
        /* 0x220 */ public NMSString0x20A MissionPageLocID;
        /* 0x240 */ public List<NMSTemplate> CancelingConditions;
        /* 0x250 */ public List<GcCostTableEntry> Costs;
        /* 0x260 */ public GcAlienPuzzleTable Dialog;
        /* 0x270 */ public List<GcGenericMissionVersionProgress> FinalStageVersions;
        /* 0x280 */ public NMSString0x10 MissionBuildMenuHint;
        /* 0x290 */ public NMSString0x10 MissionID;
        /* 0x2A0 */ public NMSString0x10 NextMissionHint;
        /* 0x2B0 */ public List<GcGenericRewardTableEntry> Rewards;
        /* 0x2C0 */ public List<GcScanEventData> ScanEvents;
        /* 0x2D0 */ public List<GcGenericMissionStage> Stages;
        /* 0x2E0 */ public List<NMSTemplate> StartingConditions;
        /* 0x2F0 */ public NMSString0x10 UseCommunityMissionForLog;
        /* 0x300 */ public TkTextureResource MissionIcon;
        /* 0x384 */ public TkTextureResource MissionIconNotSelected;
        /* 0x408 */ public TkTextureResource MissionIconSelected;
        /* 0x48C */ public GcNumberedTextList MissionDescriptions;
        /* 0x4B0 */ public GcNumberedTextList MissionProcDescriptionA;
        /* 0x4D4 */ public GcNumberedTextList MissionProcDescriptionB;
        /* 0x4F8 */ public GcNumberedTextList MissionProcDescriptionC;
        /* 0x51C */ public GcNumberedTextList MissionProcDescriptionHeader;
        /* 0x540 */ public GcNumberedTextList MissionSubtitles;
        /* 0x564 */ public GcNumberedTextList MissionTitles;
        // size: 0x4
        public enum AutoStartEnum : uint {
            None,
            AllModes,
            Seasonal,
            OnSelected,
        }
        /* 0x588 */ public AutoStartEnum AutoStart;
        /* 0x58C */ public int BeginCheckFrequency;
        /* 0x590 */ public GcMissionConditionTest CancelConditionTest;
        // size: 0x3
        public enum MessageCompleteEnum : uint {
            Default,
            Always,
            Never,
        }
        /* 0x594 */ public MessageCompleteEnum MessageComplete;
        // size: 0x3
        public enum MessageStartEnum : uint {
            Default,
            Always,
            Never,
        }
        /* 0x598 */ public MessageStartEnum MessageStart;
        /* 0x59C */ public GcMissionCategory MissionCategory;
        // size: 0xA
        public enum MissionClassEnum : uint {
            Primary,
            Secondary,
            ChainedSecondary,
            Guide,
            Wiki,
            Seasonal,
            Milestone,
            Atlas,
            BlackHole,
            FleetSupport,
        }
        /* 0x5A0 */ public MissionClassEnum MissionClass;
        /* 0x5A4 */ public GcMissionPageHint MissionPageHint;
        /* 0x5A8 */ public int MissionPriority;
        /* 0x5AC */ public GcMissionConditionTest StartConditionTest;
        /* 0x5B0 */ public NMSString0x20 MissionDescSwitchOverride;
        /* 0x5D0 */ public NMSString0x20 MissionObjective;
        /* 0x5F0 */ public bool BlocksPinning;
        /* 0x5F1 */ public bool CancelSetsComplete;
        /* 0x5F2 */ public bool CanRenounce;
        /* 0x5F3 */ public bool ForcesBuildMenuHint;
        /* 0x5F4 */ public bool ForcesPageHint;
        /* 0x5F5 */ public bool IsLegacy;
        /* 0x5F6 */ public bool IsProceduralAllowed;
        /* 0x5F7 */ public bool IsRecurring;
        /* 0x5F8 */ public bool MissionHasColourOverride;
        /* 0x5F9 */ public bool MissionIsCritical;
        /* 0x5FA */ public bool PrefixTitle;
        /* 0x5FB */ public bool RestartOnCompletion;
        /* 0x5FC */ public bool StartIsCancel;
        /* 0x5FD */ public bool TakeCommunityMissionIDFromSeasonData;
        /* 0x5FE */ public bool TelemetryUpload;
        /* 0x5FF */ public bool UseScanEventDetailsInLogInfo;
        /* 0x600 */ public bool UseSeasonTitleOverride;
    }
}
