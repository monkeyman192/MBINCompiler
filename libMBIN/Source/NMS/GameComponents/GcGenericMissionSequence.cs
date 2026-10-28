using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x82998D1A7570B41E, NameHash = 0x7FD50C85)]
    public class GcGenericMissionSequence : NMSTemplate
    {
        [NMS(Index = 24)]
        /* 0x000 */ public Colour MissionColourOverride;
        [NMS(Index = 40)]
        /* 0x010 */ public GcTradeData TradingDataOverride;
        [NMS(Index = 32)]
        /* 0x388 */ public GcMissionBoardOptions MissionBoardOptions;
        [NMS(Index = 7)]
        /* 0x438 */ public GcSeasonalLogOverrides SeasonalLogTextOverrides;
        [NMS(Index = 27)]
        /* 0x4A8 */ public GcDefaultMissionItemsTable DefaultItems;
        [NMS(Index = 21)]
        /* 0x4F8 */ public NMSString0x20A MissionPageLocID;
        [NMS(Index = 59)]
        /* 0x518 */ public NMSString0x20A SettlementAbandonOSD;
        [NMS(Index = 6)]
        /* 0x538 */ public GcNumberedTextList MissionDescriptions;
        [NMS(Index = 15)]
        /* 0x550 */ public TkTextureResource MissionIcon;
        [NMS(Index = 17)]
        /* 0x568 */ public TkTextureResource MissionIconNotSelected;
        [NMS(Index = 16)]
        /* 0x580 */ public TkTextureResource MissionIconSelected;
        [NMS(Index = 10)]
        /* 0x598 */ public GcNumberedTextList MissionProcDescriptionA;
        [NMS(Index = 11)]
        /* 0x5B0 */ public GcNumberedTextList MissionProcDescriptionB;
        [NMS(Index = 12)]
        /* 0x5C8 */ public GcNumberedTextList MissionProcDescriptionC;
        [NMS(Index = 9)]
        /* 0x5E0 */ public GcNumberedTextList MissionProcDescriptionHeader;
        [NMS(Index = 5)]
        /* 0x5F8 */ public GcNumberedTextList MissionSubtitles;
        [NMS(Index = 4)]
        /* 0x610 */ public GcNumberedTextList MissionTitles;
        [NMS(Index = 45)]
        /* 0x628 */ public List<NMSTemplate> CancelingConditions;
        [NMS(Index = 39)]
        /* 0x638 */ public List<GcCostTableEntry> Costs;
        [NMS(Index = 36)]
        /* 0x648 */ public GcAlienPuzzleTable Dialog;
        [NMS(Index = 46)]
        /* 0x658 */ public List<GcGenericMissionVersionProgress> FinalStageVersions;
        [NMS(Index = 22)]
        /* 0x668 */ public NMSString0x10 MissionBuildMenuHint;
        [NMS(Index = 0)]
        /* 0x678 */ public NMSString0x10 MissionID;
        [NMS(Index = 29)]
        /* 0x688 */ public NMSString0x10 NextMissionHint;
        [NMS(Index = 38)]
        /* 0x698 */ public List<GcGenericRewardTableEntry> Rewards;
        [NMS(Index = 37)]
        /* 0x6A8 */ public List<GcScanEventData> ScanEvents;
        [NMS(Index = 47)]
        /* 0x6B8 */ public List<GcGenericMissionStage> Stages;
        [NMS(Index = 44)]
        /* 0x6C8 */ public List<NMSTemplate> StartingConditions;
        [NMS(Index = 54)]
        /* 0x6D8 */ public NMSString0x10 UseCommunityMissionForLog;
        [NMS(Index = 26)]
        /* 0x6E8 */ public List<int> WikiMissionBlockedBySeasons;
        // size: 0x4
        public enum AutoStartEnum : uint {
            None,
            AllModes,
            Seasonal,
            OnSelected,
        }
        [NMS(Index = 33)]
        /* 0x6F8 */ public AutoStartEnum AutoStart;
        [NMS(Index = 25)]
        /* 0x6FC */ public int BeginCheckFrequency;
        [NMS(Index = 42)]
        /* 0x700 */ public GcMissionConditionTest CancelConditionTest;
        // size: 0x3
        public enum MessageCompleteEnum : uint {
            Default,
            Always,
            Never,
        }
        [NMS(Index = 30)]
        /* 0x704 */ public MessageCompleteEnum MessageComplete;
        // size: 0x3
        public enum MessageStartEnum : uint {
            Default,
            Always,
            Never,
        }
        [NMS(Index = 31)]
        /* 0x708 */ public MessageStartEnum MessageStart;
        [NMS(Index = 19)]
        /* 0x70C */ public GcMissionCategory MissionCategory;
        // size: 0xC
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
            Settlement,
            SecondaryTempMaxPriority,
        }
        [NMS(Index = 1)]
        /* 0x710 */ public MissionClassEnum MissionClass;
        [NMS(Index = 20)]
        /* 0x714 */ public GcMissionPageHint MissionPageHint;
        [NMS(Index = 18)]
        /* 0x718 */ public int MissionPriority;
        [NMS(Index = 41)]
        /* 0x71C */ public GcMissionConditionTest StartConditionTest;
        [NMS(Index = 8)]
        /* 0x720 */ public NMSString0x20 MissionDescSwitchOverride;
        [NMS(Index = 3)]
        /* 0x740 */ public NMSString0x20 MissionObjective;
        [NMS(Index = 52)]
        /* 0x760 */ public bool BlocksPinning;
        [NMS(Index = 35)]
        /* 0x761 */ public bool CancelSetsComplete;
        [NMS(Index = 53)]
        /* 0x762 */ public bool CanRenounce;
        [NMS(Index = 48)]
        /* 0x763 */ public bool ForcesBuildMenuHint;
        [NMS(Index = 51)]
        /* 0x764 */ public bool IsLegacy;
        [NMS(Index = 49)]
        /* 0x765 */ public bool IsProceduralAllowed;
        [NMS(Index = 50)]
        /* 0x766 */ public bool IsRecurring;
        [NMS(Index = 23)]
        /* 0x767 */ public bool MissionHasColourOverride;
        [NMS(Index = 2)]
        /* 0x768 */ public bool MissionIsCritical;
        [NMS(Index = 28)]
        /* 0x769 */ public bool PrefixTitle;
        [NMS(Index = 58)]
        /* 0x76A */ public bool RequiresSettlement;
        [NMS(Index = 34)]
        /* 0x76B */ public bool RestartOnCompletion;
        [NMS(Index = 43)]
        /* 0x76C */ public bool StartIsCancel;
        [NMS(Index = 55)]
        /* 0x76D */ public bool TakeCommunityMissionIDFromSeasonData;
        [NMS(Index = 56)]
        /* 0x76E */ public bool TelemetryUpload;
        [NMS(Index = 14)]
        /* 0x76F */ public bool UseFirstPurpleSystemDetailsInLogInfo;
        [NMS(Index = 13)]
        /* 0x770 */ public bool UseScanEventDetailsInLogInfo;
        [NMS(Index = 57)]
        /* 0x771 */ public bool UseSeasonTitleOverride;
    }
}
