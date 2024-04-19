using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFA3569419CEBE2E, NameHash = 0x7BBBCE7D7BC0F1F4)]
    public class GcScanEventData : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement ResourceOverride;
        /* 0x2A8 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        /* 0x318 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        /* 0x388 */ public NMSString0x20A ForceInteraction;
        /* 0x3A8 */ public NMSString0x20A MustMatchStoryUtilityPuzzle;
        /* 0x3C8 */ public NMSString0x20A Name;
        /* 0x3E8 */ public NMSString0x20A NextOption;
        /* 0x408 */ public NMSString0x20A PlanetLabelText;
        /* 0x428 */ public NMSString0x20A SurveyDiscoveryOSDMessage;
        /* 0x448 */ public GcScanEventTriggers TriggerActions;
        /* 0x460 */ public NMSString0x10 ForceOverrideEncounter;
        /* 0x470 */ public NMSString0x10 HasReward;
        /* 0x480 */ public NMSString0x10 MissionMessageOnInteract;
        /* 0x490 */ public List<NMSString0x100> UAsList;
        /* 0x4A0 */ public TkTextureResource MarkerIcon;
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
        /* 0x528 */ public BuildingLocationEnum BuildingLocation;
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
        /* 0x530 */ public BuildingTypeEnum BuildingType;
        // size: 0x5
        public enum EventEndTypeEnum : uint {
            None,
            Proximity,
            Interact,
            EnterBuilding,
            TimedInteract,
        }
        /* 0x534 */ public EventEndTypeEnum EventEndType;
        // size: 0x2
        public enum EventPriorityEnum : uint {
            Regular,
            High,
        }
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
        /* 0x53C */ public EventStartTypeEnum EventStartType;
        /* 0x540 */ public GcInteractionType ForceInteractionType;
        /* 0x544 */ public float IconTime;
        /* 0x548 */ public GcAudioWwiseEvents MessageAudio;
        /* 0x54C */ public float MessageDisplayTime;
        /* 0x550 */ public float MessageTime;
        /* 0x554 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        /* 0x558 */ public GcAlienRace OverrideInteractionRace;
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
        /* 0x560 */ public SolarSystemLocationEnum SolarSystemLocation;
        /* 0x564 */ public float StartTime;
        /* 0x568 */ public float SurveyDistance;
        /* 0x56C */ public GcTechnologyCategory TechShopType;
        /* 0x570 */ public float TooltipTime;
        /* 0x574 */ public NMSString0x20 InterstellarOSDMessage;
        /* 0x594 */ public NMSString0x20 MarkerLabel;
        /* 0x5B4 */ public NMSString0x20 OSDMessage;
        /* 0x5D4 */ public NMSString0x20 TooltipMessage;
        /* 0x5F4 */ public bool AllowFriendsBases;
        /* 0x5F5 */ public bool AllowOverriddenBuildings;
        /* 0x5F6 */ public bool AlwaysShow;
        /* 0x5F7 */ public bool BlockStartedOnUseEvents;
        /* 0x5F8 */ public bool CanEndFromOutsideMission;
        /* 0x5F9 */ public bool ClearForcedInteractionOnCompletion;
        /* 0x5FA */ public bool DisableMultiplayerSync;
        /* 0x5FB */ public bool ForceBroken;
        /* 0x5FC */ public bool ForceFixed;
        /* 0x5FD */ public bool ForceOverridesAll;
        /* 0x5FE */ public bool ForceRestartInteraction;
        /* 0x5FF */ public bool ForceWideRandom;
        /* 0x600 */ public bool IsCommunityPortalOverride;
        /* 0x601 */ public bool MustFindSystem;
        /* 0x602 */ public bool NeverShow;
        /* 0x603 */ public bool ReplaceEventIfAlreadyActive;
        /* 0x604 */ public bool ShowEndTooltip;
        /* 0x605 */ public bool ShowOnlyIfSequenceTarget;
        /* 0x606 */ public bool TargetMustMatchMissionSeed;
        /* 0x607 */ public bool TooltipRepeats;
        /* 0x608 */ public bool UseMissionTradingDataOverride;
    }
}
