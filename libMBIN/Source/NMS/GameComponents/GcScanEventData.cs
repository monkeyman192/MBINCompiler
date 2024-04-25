using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFA3569419CEBE2E, NameHash = 0x7BBBCE7D7BC0F1F4)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Index = 59)]
        /* 0x000 */ public GcResourceElement ResourceOverride;
        [NMS(Index = 36)]
        /* 0x2A8 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        [NMS(Index = 37)]
        /* 0x318 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        [NMS(Index = 1)]
        /* 0x388 */ public NMSString0x20A ForceInteraction;
        [NMS(Index = 5)]
        /* 0x3A8 */ public NMSString0x20A MustMatchStoryUtilityPuzzle;
        [NMS(Index = 0)]
        /* 0x3C8 */ public NMSString0x20A Name;
        [NMS(Index = 40)]
        /* 0x3E8 */ public NMSString0x20A NextOption;
        [NMS(Index = 17)]
        /* 0x408 */ public NMSString0x20A PlanetLabelText;
        [NMS(Index = 19)]
        /* 0x428 */ public NMSString0x20A SurveyDiscoveryOSDMessage;
        [NMS(Index = 41)]
        /* 0x448 */ public GcScanEventTriggers TriggerActions;
        [NMS(Index = 9)]
        /* 0x460 */ public NMSString0x10 ForceOverrideEncounter;
        [NMS(Index = 39)]
        /* 0x470 */ public NMSString0x10 HasReward;
        [NMS(Index = 58)]
        /* 0x480 */ public NMSString0x10 MissionMessageOnInteract;
        [NMS(Index = 42)]
        /* 0x490 */ public List<NMSString0x100> UAsList;
        [NMS(Index = 47)]
        /* 0x4A0 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 29)]
        /* 0x524 */ public GcBuildingClassification BuildingClass;
        // size: 0x7
        public enum BuildingLocationEnum : uint {
            Nearest,
            AllNearest,
            Random,
            RandomOnNearPlanet,
            RandomOnFarPlanet,
            PlanetSearch,
            PlayerSettlement,
        }
        [NMS(Index = 27)]
        /* 0x528 */ public BuildingLocationEnum BuildingLocation;
        [NMS(Index = 12)]
        /* 0x52C */ public float BuildingPreventionRadius;
        // size: 0x19
        public enum BuildingTypeEnum : uint {
            Any,
            AnyShelter,
            AnyNPC,
            BuildingClass,
            SpaceStation,
            SpaceAnomaly,
            Atlas,
            Freighter,
            FreighterBase,
            ExternalPlanetBase,
            PlanetBaseTerminal,
            Expedition,
            ExpeditionLeader,
            TutorialShelter,
            MPMissionFreighter,
            Nexus,
            InitialDistressSignal,
            SpaceMarker,
            NexusEggMachine,
            PhotoTarget,
            SettlementConstruction,
            UnownedSettlement,
            NPC_HideOut,
            FriendlyDrone,
            AnyRobotSite,
        }
        [NMS(Index = 28)]
        /* 0x530 */ public BuildingTypeEnum BuildingType;
        // size: 0x5
        public enum EventEndTypeEnum : uint {
            None,
            Proximity,
            Interact,
            EnterBuilding,
            TimedInteract,
        }
        [NMS(Index = 21)]
        /* 0x534 */ public EventEndTypeEnum EventEndType;
        // size: 0x2
        public enum EventPriorityEnum : uint {
            Regular,
            High,
        }
        [NMS(Index = 22)]
        /* 0x538 */ public EventPriorityEnum EventPriority;
        // size: 0x6
        public enum EventStartTypeEnum : uint {
            None,
            Special,
            Discovered,
            Timer,
            ObjectScan,
            LeaveBuilding,
        }
        [NMS(Index = 20)]
        /* 0x53C */ public EventStartTypeEnum EventStartType;
        [NMS(Index = 2)]
        /* 0x540 */ public GcInteractionType ForceInteractionType;
        [NMS(Index = 53)]
        /* 0x544 */ public float IconTime;
        [NMS(Index = 52)]
        /* 0x548 */ public GcAudioWwiseEvents MessageAudio;
        [NMS(Index = 51)]
        /* 0x54C */ public float MessageDisplayTime;
        [NMS(Index = 50)]
        /* 0x550 */ public float MessageTime;
        [NMS(Index = 48)]
        /* 0x554 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        [NMS(Index = 4)]
        /* 0x558 */ public GcAlienRace OverrideInteractionRace;
        [NMS(Index = 3)]
        /* 0x55C */ public GcAlienRace RequireInteractionRace;
        // size: 0x6
        public enum SolarSystemLocationEnum : uint {
            Local,
            Near,
            LocalOrNear,
            NearWithNoExpeditions,
            FromList,
            SeasonParty,
        }
        [NMS(Index = 35)]
        /* 0x560 */ public SolarSystemLocationEnum SolarSystemLocation;
        [NMS(Index = 49)]
        /* 0x564 */ public float StartTime;
        [NMS(Index = 18)]
        /* 0x568 */ public float SurveyDistance;
        [NMS(Index = 43)]
        /* 0x56C */ public GcTechnologyCategory TechShopType;
        [NMS(Index = 54)]
        /* 0x570 */ public float TooltipTime;
        [NMS(Index = 45)]
        /* 0x574 */ public NMSString0x20 InterstellarOSDMessage;
        [NMS(Index = 46)]
        /* 0x594 */ public NMSString0x20 MarkerLabel;
        [NMS(Index = 44)]
        /* 0x5B4 */ public NMSString0x20 OSDMessage;
        [NMS(Index = 57)]
        /* 0x5D4 */ public NMSString0x20 TooltipMessage;
        [NMS(Index = 30)]
        /* 0x5F4 */ public bool AllowFriendsBases;
        [NMS(Index = 33)]
        /* 0x5F5 */ public bool AllowOverriddenBuildings;
        [NMS(Index = 14)]
        /* 0x5F6 */ public bool AlwaysShow;
        [NMS(Index = 25)]
        /* 0x5F7 */ public bool BlockStartedOnUseEvents;
        [NMS(Index = 23)]
        /* 0x5F8 */ public bool CanEndFromOutsideMission;
        [NMS(Index = 11)]
        /* 0x5F9 */ public bool ClearForcedInteractionOnCompletion;
        [NMS(Index = 24)]
        /* 0x5FA */ public bool DisableMultiplayerSync;
        [NMS(Index = 6)]
        /* 0x5FB */ public bool ForceBroken;
        [NMS(Index = 7)]
        /* 0x5FC */ public bool ForceFixed;
        [NMS(Index = 8)]
        /* 0x5FD */ public bool ForceOverridesAll;
        [NMS(Index = 38)]
        /* 0x5FE */ public bool ForceRestartInteraction;
        [NMS(Index = 31)]
        /* 0x5FF */ public bool ForceWideRandom;
        [NMS(Index = 10)]
        /* 0x600 */ public bool IsCommunityPortalOverride;
        [NMS(Index = 32)]
        /* 0x601 */ public bool MustFindSystem;
        [NMS(Index = 15)]
        /* 0x602 */ public bool NeverShow;
        [NMS(Index = 26)]
        /* 0x603 */ public bool ReplaceEventIfAlreadyActive;
        [NMS(Index = 56)]
        /* 0x604 */ public bool ShowEndTooltip;
        [NMS(Index = 16)]
        /* 0x605 */ public bool ShowOnlyIfSequenceTarget;
        [NMS(Index = 34)]
        /* 0x606 */ public bool TargetMustMatchMissionSeed;
        [NMS(Index = 55)]
        /* 0x607 */ public bool TooltipRepeats;
        [NMS(Index = 13)]
        /* 0x608 */ public bool UseMissionTradingDataOverride;
    }
}
