using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD2BCB476F60009E, NameHash = 0x7BBBCE7D7BC0F1F4)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Index = 60)]
        /* 0x000 */ public GcResourceElement ResourceOverride;
        [NMS(Index = 37)]
        /* 0x2A8 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        [NMS(Index = 38)]
        /* 0x318 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        [NMS(Index = 1)]
        /* 0x388 */ public NMSString0x20A ForceInteraction;
        [NMS(Index = 5)]
        /* 0x3A8 */ public NMSString0x20A MustMatchStoryUtilityPuzzle;
        [NMS(Index = 0)]
        /* 0x3C8 */ public NMSString0x20A Name;
        [NMS(Index = 41)]
        /* 0x3E8 */ public NMSString0x20A NextOption;
        [NMS(Index = 18)]
        /* 0x408 */ public NMSString0x20A PlanetLabelText;
        [NMS(Index = 20)]
        /* 0x428 */ public NMSString0x20A SurveyDiscoveryOSDMessage;
        [NMS(Index = 42)]
        /* 0x448 */ public GcScanEventTriggers TriggerActions;
        [NMS(Index = 10)]
        /* 0x460 */ public NMSString0x10 ForceOverrideEncounter;
        [NMS(Index = 40)]
        /* 0x470 */ public NMSString0x10 HasReward;
        [NMS(Index = 59)]
        /* 0x480 */ public NMSString0x10 MissionMessageOnInteract;
        [NMS(Index = 8)]
        /* 0x490 */ public NMSString0x10 ReplacementMaintData;
        [NMS(Index = 43)]
        /* 0x4A0 */ public List<NMSString0x100> UAsList;
        [NMS(Index = 48)]
        /* 0x4B0 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 30)]
        /* 0x534 */ public GcBuildingClassification BuildingClass;
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
        [NMS(Index = 28)]
        /* 0x538 */ public BuildingLocationEnum BuildingLocation;
        [NMS(Index = 13)]
        /* 0x53C */ public float BuildingPreventionRadius;
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
        [NMS(Index = 29)]
        /* 0x540 */ public BuildingTypeEnum BuildingType;
        // size: 0x5
        public enum EventEndTypeEnum : uint {
            None,
            Proximity,
            Interact,
            EnterBuilding,
            TimedInteract,
        }
        [NMS(Index = 22)]
        /* 0x544 */ public EventEndTypeEnum EventEndType;
        // size: 0x2
        public enum EventPriorityEnum : uint {
            Regular,
            High,
        }
        [NMS(Index = 23)]
        /* 0x548 */ public EventPriorityEnum EventPriority;
        // size: 0x6
        public enum EventStartTypeEnum : uint {
            None,
            Special,
            Discovered,
            Timer,
            ObjectScan,
            LeaveBuilding,
        }
        [NMS(Index = 21)]
        /* 0x54C */ public EventStartTypeEnum EventStartType;
        [NMS(Index = 2)]
        /* 0x550 */ public GcInteractionType ForceInteractionType;
        [NMS(Index = 54)]
        /* 0x554 */ public float IconTime;
        [NMS(Index = 53)]
        /* 0x558 */ public GcAudioWwiseEvents MessageAudio;
        [NMS(Index = 52)]
        /* 0x55C */ public float MessageDisplayTime;
        [NMS(Index = 51)]
        /* 0x560 */ public float MessageTime;
        [NMS(Index = 49)]
        /* 0x564 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        [NMS(Index = 4)]
        /* 0x568 */ public GcAlienRace OverrideInteractionRace;
        [NMS(Index = 3)]
        /* 0x56C */ public GcAlienRace RequireInteractionRace;
        // size: 0x6
        public enum SolarSystemLocationEnum : uint {
            Local,
            Near,
            LocalOrNear,
            NearWithNoExpeditions,
            FromList,
            SeasonParty,
        }
        [NMS(Index = 36)]
        /* 0x570 */ public SolarSystemLocationEnum SolarSystemLocation;
        [NMS(Index = 50)]
        /* 0x574 */ public float StartTime;
        [NMS(Index = 19)]
        /* 0x578 */ public float SurveyDistance;
        [NMS(Index = 44)]
        /* 0x57C */ public GcTechnologyCategory TechShopType;
        [NMS(Index = 55)]
        /* 0x580 */ public float TooltipTime;
        [NMS(Index = 46)]
        /* 0x584 */ public NMSString0x20 InterstellarOSDMessage;
        [NMS(Index = 47)]
        /* 0x5A4 */ public NMSString0x20 MarkerLabel;
        [NMS(Index = 45)]
        /* 0x5C4 */ public NMSString0x20 OSDMessage;
        [NMS(Index = 58)]
        /* 0x5E4 */ public NMSString0x20 TooltipMessage;
        [NMS(Index = 31)]
        /* 0x604 */ public bool AllowFriendsBases;
        [NMS(Index = 34)]
        /* 0x605 */ public bool AllowOverriddenBuildings;
        [NMS(Index = 15)]
        /* 0x606 */ public bool AlwaysShow;
        [NMS(Index = 26)]
        /* 0x607 */ public bool BlockStartedOnUseEvents;
        [NMS(Index = 24)]
        /* 0x608 */ public bool CanEndFromOutsideMission;
        [NMS(Index = 12)]
        /* 0x609 */ public bool ClearForcedInteractionOnCompletion;
        [NMS(Index = 25)]
        /* 0x60A */ public bool DisableMultiplayerSync;
        [NMS(Index = 6)]
        /* 0x60B */ public bool ForceBroken;
        [NMS(Index = 7)]
        /* 0x60C */ public bool ForceFixed;
        [NMS(Index = 9)]
        /* 0x60D */ public bool ForceOverridesAll;
        [NMS(Index = 39)]
        /* 0x60E */ public bool ForceRestartInteraction;
        [NMS(Index = 32)]
        /* 0x60F */ public bool ForceWideRandom;
        [NMS(Index = 11)]
        /* 0x610 */ public bool IsCommunityPortalOverride;
        [NMS(Index = 33)]
        /* 0x611 */ public bool MustFindSystem;
        [NMS(Index = 16)]
        /* 0x612 */ public bool NeverShow;
        [NMS(Index = 27)]
        /* 0x613 */ public bool ReplaceEventIfAlreadyActive;
        [NMS(Index = 57)]
        /* 0x614 */ public bool ShowEndTooltip;
        [NMS(Index = 17)]
        /* 0x615 */ public bool ShowOnlyIfSequenceTarget;
        [NMS(Index = 35)]
        /* 0x616 */ public bool TargetMustMatchMissionSeed;
        [NMS(Index = 56)]
        /* 0x617 */ public bool TooltipRepeats;
        [NMS(Index = 14)]
        /* 0x618 */ public bool UseMissionTradingDataOverride;
    }
}
