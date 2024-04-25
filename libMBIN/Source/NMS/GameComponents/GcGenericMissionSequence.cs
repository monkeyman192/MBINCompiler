using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96D4DC761A1242F, NameHash = 0xFAE86B2801335B6D)]
    public class GcGenericMissionSequence : NMSTemplate
    {
        [NMS(Index = 23)]
        /* 0x000 */ public Colour MissionColourOverride;
        [NMS(Index = 38)]
        /* 0x010 */ public GcTradeData TradingDataOverride;
        [NMS(Index = 30)]
        /* 0x0E0 */ public GcMissionBoardOptions MissionBoardOptions;
        [NMS(Index = 7)]
        /* 0x160 */ public GcSeasonalLogOverrides SeasonalLogTextOverrides;
        [NMS(Index = 25)]
        /* 0x1D0 */ public GcDefaultMissionItemsTable DefaultItems;
        [NMS(Index = 20)]
        /* 0x220 */ public NMSString0x20A MissionPageLocID;
        [NMS(Index = 43)]
        /* 0x240 */ public List<NMSTemplate> CancelingConditions;
        [NMS(Index = 37)]
        /* 0x250 */ public List<GcCostTableEntry> Costs;
        [NMS(Index = 34)]
        /* 0x260 */ public GcAlienPuzzleTable Dialog;
        [NMS(Index = 44)]
        /* 0x270 */ public List<GcGenericMissionVersionProgress> FinalStageVersions;
        [NMS(Index = 21)]
        /* 0x280 */ public NMSString0x10 MissionBuildMenuHint;
        [NMS(Index = 0)]
        /* 0x290 */ public NMSString0x10 MissionID;
        [NMS(Index = 27)]
        /* 0x2A0 */ public NMSString0x10 NextMissionHint;
        [NMS(Index = 36)]
        /* 0x2B0 */ public List<GcGenericRewardTableEntry> Rewards;
        [NMS(Index = 35)]
        /* 0x2C0 */ public List<GcScanEventData> ScanEvents;
        [NMS(Index = 45)]
        /* 0x2D0 */ public List<GcGenericMissionStage> Stages;
        [NMS(Index = 42)]
        /* 0x2E0 */ public List<NMSTemplate> StartingConditions;
        [NMS(Index = 53)]
        /* 0x2F0 */ public NMSString0x10 UseCommunityMissionForLog;
        [NMS(Index = 14)]
        /* 0x300 */ public TkTextureResource MissionIcon;
        [NMS(Index = 16)]
        /* 0x384 */ public TkTextureResource MissionIconNotSelected;
        [NMS(Index = 15)]
        /* 0x408 */ public TkTextureResource MissionIconSelected;
        [NMS(Index = 6)]
        /* 0x48C */ public GcNumberedTextList MissionDescriptions;
        [NMS(Index = 10)]
        /* 0x4B0 */ public GcNumberedTextList MissionProcDescriptionA;
        [NMS(Index = 11)]
        /* 0x4D4 */ public GcNumberedTextList MissionProcDescriptionB;
        [NMS(Index = 12)]
        /* 0x4F8 */ public GcNumberedTextList MissionProcDescriptionC;
        [NMS(Index = 9)]
        /* 0x51C */ public GcNumberedTextList MissionProcDescriptionHeader;
        [NMS(Index = 5)]
        /* 0x540 */ public GcNumberedTextList MissionSubtitles;
        [NMS(Index = 4)]
        /* 0x564 */ public GcNumberedTextList MissionTitles;
        // size: 0x4
        public enum AutoStartEnum : uint {
            None,
            AllModes,
            Seasonal,
            OnSelected,
        }
        [NMS(Index = 31)]
        /* 0x588 */ public AutoStartEnum AutoStart;
        [NMS(Index = 24)]
        /* 0x58C */ public int BeginCheckFrequency;
        [NMS(Index = 40)]
        /* 0x590 */ public GcMissionConditionTest CancelConditionTest;
        // size: 0x3
        public enum MessageCompleteEnum : uint {
            Default,
            Always,
            Never,
        }
        [NMS(Index = 28)]
        /* 0x594 */ public MessageCompleteEnum MessageComplete;
        // size: 0x3
        public enum MessageStartEnum : uint {
            Default,
            Always,
            Never,
        }
        [NMS(Index = 29)]
        /* 0x598 */ public MessageStartEnum MessageStart;
        [NMS(Index = 18)]
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
        [NMS(Index = 1)]
        /* 0x5A0 */ public MissionClassEnum MissionClass;
        [NMS(Index = 19)]
        /* 0x5A4 */ public GcMissionPageHint MissionPageHint;
        [NMS(Index = 17)]
        /* 0x5A8 */ public int MissionPriority;
        [NMS(Index = 39)]
        /* 0x5AC */ public GcMissionConditionTest StartConditionTest;
        [NMS(Index = 8)]
        /* 0x5B0 */ public NMSString0x20 MissionDescSwitchOverride;
        [NMS(Index = 3)]
        /* 0x5D0 */ public NMSString0x20 MissionObjective;
        [NMS(Index = 51)]
        /* 0x5F0 */ public bool BlocksPinning;
        [NMS(Index = 33)]
        /* 0x5F1 */ public bool CancelSetsComplete;
        [NMS(Index = 52)]
        /* 0x5F2 */ public bool CanRenounce;
        [NMS(Index = 47)]
        /* 0x5F3 */ public bool ForcesBuildMenuHint;
        [NMS(Index = 46)]
        /* 0x5F4 */ public bool ForcesPageHint;
        [NMS(Index = 50)]
        /* 0x5F5 */ public bool IsLegacy;
        [NMS(Index = 48)]
        /* 0x5F6 */ public bool IsProceduralAllowed;
        [NMS(Index = 49)]
        /* 0x5F7 */ public bool IsRecurring;
        [NMS(Index = 22)]
        /* 0x5F8 */ public bool MissionHasColourOverride;
        [NMS(Index = 2)]
        /* 0x5F9 */ public bool MissionIsCritical;
        [NMS(Index = 26)]
        /* 0x5FA */ public bool PrefixTitle;
        [NMS(Index = 32)]
        /* 0x5FB */ public bool RestartOnCompletion;
        [NMS(Index = 41)]
        /* 0x5FC */ public bool StartIsCancel;
        [NMS(Index = 54)]
        /* 0x5FD */ public bool TakeCommunityMissionIDFromSeasonData;
        [NMS(Index = 55)]
        /* 0x5FE */ public bool TelemetryUpload;
        [NMS(Index = 13)]
        /* 0x5FF */ public bool UseScanEventDetailsInLogInfo;
        [NMS(Index = 56)]
        /* 0x600 */ public bool UseSeasonTitleOverride;
    }
}
