using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF18C9A5DF8962BFA, NameHash = 0x37EE71BB)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Index = 40)]
        /* 0x000 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        [NMS(Index = 41)]
        /* 0x088 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        [NMS(Index = 64)]
        /* 0x110 */ public GcResourceElement ResourceOverride;
        [NMS(Index = 1)]
        /* 0x158 */ public NMSString0x20A ForceInteraction;
        [NMS(Index = 7)]
        /* 0x178 */ public NMSString0x20A MustMatchStoryUtilityPuzzle;
        [NMS(Index = 0)]
        /* 0x198 */ public NMSString0x20A Name;
        [NMS(Index = 45)]
        /* 0x1B8 */ public NMSString0x20A NextOption;
        [NMS(Index = 20)]
        /* 0x1D8 */ public NMSString0x20A PlanetLabelText;
        [NMS(Index = 22)]
        /* 0x1F8 */ public NMSString0x20A SurveyDiscoveryOSDMessage;
        [NMS(Index = 23)]
        /* 0x218 */ public NMSString0x20A SurveyHUDName;
        [NMS(Index = 52)]
        /* 0x238 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 46)]
        /* 0x250 */ public GcScanEventTriggers TriggerActions;
        [NMS(Index = 12)]
        /* 0x268 */ public NMSString0x10 ForceOverrideEncounter;
        [NMS(Index = 44)]
        /* 0x278 */ public NMSString0x10 HasReward;
        [NMS(Index = 50)]
        /* 0x288 */ public VariableSizeString InterstellarOSDMessage;
        [NMS(Index = 51)]
        /* 0x298 */ public VariableSizeString MarkerLabel;
        [NMS(Index = 63)]
        /* 0x2A8 */ public NMSString0x10 MissionMessageOnInteract;
        [NMS(Index = 49)]
        /* 0x2B8 */ public VariableSizeString OSDMessage;
        [NMS(Index = 10)]
        /* 0x2C8 */ public NMSString0x10 ReplacementMaintData;
        [NMS(Index = 62)]
        /* 0x2D8 */ public VariableSizeString TooltipMessage;
        [NMS(Index = 47)]
        /* 0x2E8 */ public List<VariableSizeString> UAsList;
        [NMS(Index = 33)]
        /* 0x2F8 */ public GcBuildingClassification BuildingClass;
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
        [NMS(Index = 31)]
        /* 0x2FC */ public BuildingLocationEnum BuildingLocation;
        [NMS(Index = 15)]
        /* 0x300 */ public float BuildingPreventionRadius;
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
        [NMS(Index = 32)]
        /* 0x304 */ public BuildingTypeEnum BuildingType;
        // size: 0x5
        public enum EventEndTypeEnum : uint {
            None,
            Proximity,
            Interact,
            EnterBuilding,
            TimedInteract,
        }
        [NMS(Index = 25)]
        /* 0x308 */ public EventEndTypeEnum EventEndType;
        // size: 0x2
        public enum EventPriorityEnum : uint {
            Regular,
            High,
        }
        [NMS(Index = 26)]
        /* 0x30C */ public EventPriorityEnum EventPriority;
        // size: 0x6
        public enum EventStartTypeEnum : uint {
            None,
            Special,
            Discovered,
            Timer,
            ObjectScan,
            LeaveBuilding,
        }
        [NMS(Index = 24)]
        /* 0x310 */ public EventStartTypeEnum EventStartType;
        [NMS(Index = 3)]
        /* 0x314 */ public GcInteractionType ForceInteractionType;
        [NMS(Index = 58)]
        /* 0x318 */ public float IconTime;
        [NMS(Index = 57)]
        /* 0x31C */ public GcAudioWwiseEvents MessageAudio;
        [NMS(Index = 56)]
        /* 0x320 */ public float MessageDisplayTime;
        [NMS(Index = 55)]
        /* 0x324 */ public float MessageTime;
        [NMS(Index = 53)]
        /* 0x328 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        [NMS(Index = 6)]
        /* 0x32C */ public GcAlienRace OverrideInteractionRace;
        [NMS(Index = 5)]
        /* 0x330 */ public GcAlienRace RequireInteractionRace;
        // size: 0x6
        public enum SolarSystemLocationEnum : uint {
            Local,
            Near,
            LocalOrNear,
            NearWithNoExpeditions,
            FromList,
            SeasonParty,
        }
        [NMS(Index = 39)]
        /* 0x334 */ public SolarSystemLocationEnum SolarSystemLocation;
        [NMS(Index = 54)]
        /* 0x338 */ public float StartTime;
        [NMS(Index = 21)]
        /* 0x33C */ public float SurveyDistance;
        [NMS(Index = 48)]
        /* 0x340 */ public GcTechnologyCategory TechShopType;
        [NMS(Index = 59)]
        /* 0x344 */ public float TooltipTime;
        [NMS(Index = 34)]
        /* 0x348 */ public bool AllowFriendsBases;
        [NMS(Index = 37)]
        /* 0x349 */ public bool AllowOverriddenBuildings;
        [NMS(Index = 17)]
        /* 0x34A */ public bool AlwaysShow;
        [NMS(Index = 29)]
        /* 0x34B */ public bool BlockStartedOnUseEvents;
        [NMS(Index = 27)]
        /* 0x34C */ public bool CanEndFromOutsideMission;
        [NMS(Index = 14)]
        /* 0x34D */ public bool ClearForcedInteractionOnCompletion;
        [NMS(Index = 28)]
        /* 0x34E */ public bool DisableMultiplayerSync;
        [NMS(Index = 8)]
        /* 0x34F */ public bool ForceBroken;
        [NMS(Index = 9)]
        /* 0x350 */ public bool ForceFixed;
        [NMS(Index = 11)]
        /* 0x351 */ public bool ForceOverridesAll;
        [NMS(Index = 43)]
        /* 0x352 */ public bool ForceResetPortal;
        [NMS(Index = 42)]
        /* 0x353 */ public bool ForceRestartInteraction;
        [NMS(Index = 35)]
        /* 0x354 */ public bool ForceWideRandom;
        [NMS(Index = 13)]
        /* 0x355 */ public bool IsCommunityPortalOverride;
        [NMS(Index = 36)]
        /* 0x356 */ public bool MustFindSystem;
        [NMS(Index = 18)]
        /* 0x357 */ public bool NeverShow;
        [NMS(Index = 4)]
        /* 0x358 */ public bool NPCReactsToPlayer;
        [NMS(Index = 30)]
        /* 0x359 */ public bool ReplaceEventIfAlreadyActive;
        [NMS(Index = 61)]
        /* 0x35A */ public bool ShowEndTooltip;
        [NMS(Index = 19)]
        /* 0x35B */ public bool ShowOnlyIfSequenceTarget;
        [NMS(Index = 38)]
        /* 0x35C */ public bool TargetMustMatchMissionSeed;
        [NMS(Index = 60)]
        /* 0x35D */ public bool TooltipRepeats;
        [NMS(Index = 16)]
        /* 0x35E */ public bool UseMissionTradingDataOverride;
        [NMS(Index = 2)]
        /* 0x35F */ public bool UseSeasonDataAsInteraction;
    }
}
