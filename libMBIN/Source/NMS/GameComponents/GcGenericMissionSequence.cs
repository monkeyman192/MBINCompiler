using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8042D55B01D543F2, NameHash = 0x7FD50C85)]
    public class GcGenericMissionSequence : NMSTemplate
    {
        [NMS(Index = 23)]
        /* 0x000 */ public Colour MissionColourOverride;
        [NMS(Index = 39)]
        /* 0x010 */ public GcTradeData TradingDataOverride;
        [NMS(Index = 31)]
        /* 0x0E0 */ public GcMissionBoardOptions MissionBoardOptions;
        [NMS(Index = 7)]
        /* 0x160 */ public GcSeasonalLogOverrides SeasonalLogTextOverrides;
        [NMS(Index = 26)]
        /* 0x1D0 */ public GcDefaultMissionItemsTable DefaultItems;
        [NMS(Index = 20)]
        /* 0x220 */ public NMSString0x20A MissionPageLocID;
        [NMS(Index = 6)]
        /* 0x240 */ public GcNumberedTextList MissionDescriptions;
        [NMS(Index = 14)]
        /* 0x258 */ public TkTextureResource MissionIcon;
        [NMS(Index = 16)]
        /* 0x270 */ public TkTextureResource MissionIconNotSelected;
        [NMS(Index = 15)]
        /* 0x288 */ public TkTextureResource MissionIconSelected;
        [NMS(Index = 10)]
        /* 0x2A0 */ public GcNumberedTextList MissionProcDescriptionA;
        [NMS(Index = 11)]
        /* 0x2B8 */ public GcNumberedTextList MissionProcDescriptionB;
        [NMS(Index = 12)]
        /* 0x2D0 */ public GcNumberedTextList MissionProcDescriptionC;
        [NMS(Index = 9)]
        /* 0x2E8 */ public GcNumberedTextList MissionProcDescriptionHeader;
        [NMS(Index = 5)]
        /* 0x300 */ public GcNumberedTextList MissionSubtitles;
        [NMS(Index = 4)]
        /* 0x318 */ public GcNumberedTextList MissionTitles;
        [NMS(Index = 44)]
        /* 0x330 */ public List<NMSTemplate> CancelingConditions;
        [NMS(Index = 38)]
        /* 0x340 */ public List<GcCostTableEntry> Costs;
        [NMS(Index = 35)]
        /* 0x350 */ public GcAlienPuzzleTable Dialog;
        [NMS(Index = 45)]
        /* 0x360 */ public List<GcGenericMissionVersionProgress> FinalStageVersions;
        [NMS(Index = 21)]
        /* 0x370 */ public NMSString0x10 MissionBuildMenuHint;
        [NMS(Index = 0)]
        /* 0x380 */ public NMSString0x10 MissionID;
        [NMS(Index = 28)]
        /* 0x390 */ public NMSString0x10 NextMissionHint;
        [NMS(Index = 37)]
        /* 0x3A0 */ public List<GcGenericRewardTableEntry> Rewards;
        [NMS(Index = 36)]
        /* 0x3B0 */ public List<GcScanEventData> ScanEvents;
        [NMS(Index = 46)]
        /* 0x3C0 */ public List<GcGenericMissionStage> Stages;
        [NMS(Index = 43)]
        /* 0x3D0 */ public List<NMSTemplate> StartingConditions;
        [NMS(Index = 54)]
        /* 0x3E0 */ public NMSString0x10 UseCommunityMissionForLog;
        [NMS(Index = 25)]
        /* 0x3F0 */ public List<int> WikiMissionBlockedBySeasons;
        // size: 0x4
        public enum AutoStartEnum : uint {
            None,
            AllModes,
            Seasonal,
            OnSelected,
        }
        [NMS(Index = 32)]
        /* 0x400 */ public AutoStartEnum AutoStart;
        [NMS(Index = 24)]
        /* 0x404 */ public int BeginCheckFrequency;
        [NMS(Index = 41)]
        /* 0x408 */ public GcMissionConditionTest CancelConditionTest;
        // size: 0x3
        public enum MessageCompleteEnum : uint {
            Default,
            Always,
            Never,
        }
        [NMS(Index = 29)]
        /* 0x40C */ public MessageCompleteEnum MessageComplete;
        // size: 0x3
        public enum MessageStartEnum : uint {
            Default,
            Always,
            Never,
        }
        [NMS(Index = 30)]
        /* 0x410 */ public MessageStartEnum MessageStart;
        [NMS(Index = 18)]
        /* 0x414 */ public GcMissionCategory MissionCategory;
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
        /* 0x418 */ public MissionClassEnum MissionClass;
        [NMS(Index = 19)]
        /* 0x41C */ public GcMissionPageHint MissionPageHint;
        [NMS(Index = 17)]
        /* 0x420 */ public int MissionPriority;
        [NMS(Index = 40)]
        /* 0x424 */ public GcMissionConditionTest StartConditionTest;
        [NMS(Index = 8)]
        /* 0x428 */ public NMSString0x20 MissionDescSwitchOverride;
        [NMS(Index = 3)]
        /* 0x448 */ public NMSString0x20 MissionObjective;
        [NMS(Index = 52)]
        /* 0x468 */ public bool BlocksPinning;
        [NMS(Index = 34)]
        /* 0x469 */ public bool CancelSetsComplete;
        [NMS(Index = 53)]
        /* 0x46A */ public bool CanRenounce;
        [NMS(Index = 48)]
        /* 0x46B */ public bool ForcesBuildMenuHint;
        [NMS(Index = 47)]
        /* 0x46C */ public bool ForcesPageHint;
        [NMS(Index = 51)]
        /* 0x46D */ public bool IsLegacy;
        [NMS(Index = 49)]
        /* 0x46E */ public bool IsProceduralAllowed;
        [NMS(Index = 50)]
        /* 0x46F */ public bool IsRecurring;
        [NMS(Index = 22)]
        /* 0x470 */ public bool MissionHasColourOverride;
        [NMS(Index = 2)]
        /* 0x471 */ public bool MissionIsCritical;
        [NMS(Index = 27)]
        /* 0x472 */ public bool PrefixTitle;
        [NMS(Index = 33)]
        /* 0x473 */ public bool RestartOnCompletion;
        [NMS(Index = 42)]
        /* 0x474 */ public bool StartIsCancel;
        [NMS(Index = 55)]
        /* 0x475 */ public bool TakeCommunityMissionIDFromSeasonData;
        [NMS(Index = 56)]
        /* 0x476 */ public bool TelemetryUpload;
        [NMS(Index = 13)]
        /* 0x477 */ public bool UseScanEventDetailsInLogInfo;
        [NMS(Index = 57)]
        /* 0x478 */ public bool UseSeasonTitleOverride;
    }
}
