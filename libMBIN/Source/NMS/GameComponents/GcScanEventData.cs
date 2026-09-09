using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEBC749534379071D, NameHash = 0x37EE71BB)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Index = 47)]
        /* 0x000 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        [NMS(Index = 48)]
        /* 0x0C0 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        [NMS(Index = 71)]
        /* 0x180 */ public GcResourceElement ResourceOverride;
        [NMS(Index = 1)]
        /* 0x1C8 */ public NMSString0x20A ForceInteraction;
        [NMS(Index = 8)]
        /* 0x1E8 */ public NMSString0x20A MustMatchStoryUtilityPuzzle;
        [NMS(Index = 7)]
        /* 0x208 */ public NMSString0x20A MustMatchStoryUtilityTag;
        [NMS(Index = 0)]
        /* 0x228 */ public NMSString0x20A Name;
        [NMS(Index = 52)]
        /* 0x248 */ public NMSString0x20A NextOption;
        [NMS(Index = 73)]
        /* 0x268 */ public NMSString0x20A OverrideGameTableConfig;
        [NMS(Index = 75)]
        /* 0x288 */ public NMSString0x20A OverrideGameTableGameConfig;
        [NMS(Index = 76)]
        /* 0x2A8 */ public NMSString0x20A OverrideGameTableGameConfigOnCompletion;
        [NMS(Index = 23)]
        /* 0x2C8 */ public NMSString0x20A PlanetLabelText;
        [NMS(Index = 72)]
        /* 0x2E8 */ public NMSString0x20A RequireDefaultGameTableConfig;
        [NMS(Index = 25)]
        /* 0x308 */ public NMSString0x20A SurveyDiscoveryOSDMessage;
        [NMS(Index = 26)]
        /* 0x328 */ public NMSString0x20A SurveyHUDName;
        [NMS(Index = 59)]
        /* 0x348 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 53)]
        /* 0x360 */ public GcScanEventTriggers TriggerActions;
        [NMS(Index = 14)]
        /* 0x378 */ public NMSString0x10 ForceOverrideEncounter;
        [NMS(Index = 51)]
        /* 0x388 */ public NMSString0x10 HasReward;
        [NMS(Index = 57)]
        /* 0x398 */ public VariableSizeString InterstellarOSDMessage;
        [NMS(Index = 58)]
        /* 0x3A8 */ public VariableSizeString MarkerLabel;
        [NMS(Index = 70)]
        /* 0x3B8 */ public NMSString0x10 MissionMessageOnInteract;
        [NMS(Index = 56)]
        /* 0x3C8 */ public VariableSizeString OSDMessage;
        [NMS(Index = 85)]
        /* 0x3D8 */ public NMSString0x10 OverrideSpacePoiEncounter;
        [NMS(Index = 11)]
        /* 0x3E8 */ public NMSString0x10 ReplacementMaintData;
        [NMS(Index = 82)]
        /* 0x3F8 */ public NMSString0x10 SpecificSpacePoiId;
        [NMS(Index = 69)]
        /* 0x408 */ public VariableSizeString TooltipMessage;
        [NMS(Index = 54)]
        /* 0x418 */ public List<VariableSizeString> UAsList;
        [NMS(Index = 44)]
        /* 0x428 */ public VariableSizeString UseUDAAsSearchPoint;
        // size: 0x8
        public enum BuildingLocationEnum : uint {
            Nearest,
            AllNearest,
            Random,
            RandomOnNearPlanet,
            RandomOnFarPlanet,
            PlanetSearch,
            PlayerSettlement,
            NearestUnmarked,
        }
        [NMS(Index = 35)]
        /* 0x438 */ public BuildingLocationEnum BuildingLocation;
        [NMS(Index = 17)]
        /* 0x43C */ public float BuildingPreventionRadius;
        // size: 0x5
        public enum EventEndTypeEnum : uint {
            None,
            Proximity,
            Interact,
            EnterBuilding,
            TimedInteract,
        }
        [NMS(Index = 29)]
        /* 0x440 */ public EventEndTypeEnum EventEndType;
        // size: 0x2
        public enum EventPriorityEnum : uint {
            Regular,
            High,
        }
        [NMS(Index = 30)]
        /* 0x444 */ public EventPriorityEnum EventPriority;
        // size: 0x6
        public enum EventStartTypeEnum : uint {
            None,
            Special,
            Discovered,
            Timer,
            ObjectScan,
            LeaveBuilding,
        }
        [NMS(Index = 28)]
        /* 0x448 */ public EventStartTypeEnum EventStartType;
        [NMS(Index = 3)]
        /* 0x44C */ public GcInteractionType ForceInteractionType;
        [NMS(Index = 65)]
        /* 0x450 */ public float IconTime;
        [NMS(Index = 64)]
        /* 0x454 */ public GcAudioWwiseEvents MessageAudio;
        [NMS(Index = 63)]
        /* 0x458 */ public float MessageDisplayTime;
        [NMS(Index = 62)]
        /* 0x45C */ public float MessageTime;
        [NMS(Index = 60)]
        /* 0x460 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        [NMS(Index = 6)]
        /* 0x464 */ public GcAlienRace OverrideInteractionRace;
        [NMS(Index = 27)]
        /* 0x468 */ public GcStaticTag PlaceMarkerAtTaggedNode;
        [NMS(Index = 80)]
        /* 0x46C */ public GcSpacePoiDiscoveryLevel RequiredSpacePoiDiscoveryLevel;
        [NMS(Index = 78)]
        /* 0x470 */ public GcSpacePoiType RequiredSpacePoiType;
        [NMS(Index = 5)]
        /* 0x474 */ public GcAlienRace RequireInteractionRace;
        // size: 0x1E
        public enum SearchTypeEnum : uint {
            Any,
            AnyShelter,
            AnyNPC,
            FindBuildingClass,
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
            NPC_PetBattle,
            SettlementConstruction,
            UnownedSettlement,
            NPC_HideOut,
            FriendlyDrone,
            AnyRobotSite,
            UnownedSettlement_Builders,
            OwnedSettlementHub,
            SpacePoi,
            PlanetPostBoxes,
        }
        [NMS(Index = 36)]
        /* 0x478 */ public SearchTypeEnum SearchType;
        // size: 0x8
        public enum SolarSystemLocationEnum : uint {
            Local,
            Near,
            LocalOrNear,
            NearWithNoExpeditions,
            FromList,
            SeasonParty,
            FirstPurpleSystemUA,
            NearSpecificPartyIndex,
        }
        [NMS(Index = 45)]
        /* 0x47C */ public SolarSystemLocationEnum SolarSystemLocation;
        // size: 0x2
        public enum SpacePoiLocationEnum : uint {
            Nearest,
            Random,
        }
        [NMS(Index = 83)]
        /* 0x480 */ public SpacePoiLocationEnum SpacePoiLocation;
        [NMS(Index = 46)]
        /* 0x484 */ public int SpecificPartyIndexToSearchFrom;
        [NMS(Index = 61)]
        /* 0x488 */ public float StartTime;
        [NMS(Index = 24)]
        /* 0x48C */ public float SurveyDistance;
        [NMS(Index = 55)]
        /* 0x490 */ public GcTechnologyCategory TechShopType;
        [NMS(Index = 66)]
        /* 0x494 */ public float TooltipTime;
        [NMS(Index = 38)]
        /* 0x498 */ public bool AllowFriendsBases;
        [NMS(Index = 41)]
        /* 0x499 */ public bool AllowOverriddenBuildings;
        [NMS(Index = 20)]
        /* 0x49A */ public bool AlwaysShow;
        [NMS(Index = 33)]
        /* 0x49B */ public bool BlockStartedOnUseEvents;
        [NMS(Index = 18)]
        /* 0x49C */ public bool BuildingPreventionDisallowBuilding;
        [NMS(Index = 31)]
        /* 0x49D */ public bool CanEndFromOutsideMission;
        [NMS(Index = 16)]
        /* 0x49E */ public bool ClearForcedInteractionOnCompletion;
        [NMS(Index = 74)]
        /* 0x49F */ public bool ClearGameTableConfigOverrideOnCompletion;
        [NMS(Index = 32)]
        /* 0x4A0 */ public bool DisableMultiplayerSync;
        [NMS(Index = 9)]
        /* 0x4A1 */ public bool ForceBroken;
        [NMS(Index = 10)]
        /* 0x4A2 */ public bool ForceFixed;
        [NMS(Index = 13)]
        /* 0x4A3 */ public bool ForceOverridesAll;
        [NMS(Index = 12)]
        /* 0x4A4 */ public bool ForceReplaceStoryPortalSeed;
        [NMS(Index = 50)]
        /* 0x4A5 */ public bool ForceResetPortal;
        [NMS(Index = 49)]
        /* 0x4A6 */ public bool ForceRestartInteraction;
        [NMS(Index = 39)]
        /* 0x4A7 */ public bool ForceWideRandom;
        [NMS(Index = 81)]
        /* 0x4A8 */ public bool IgnoreCompletedSpacePoi;
        [NMS(Index = 15)]
        /* 0x4A9 */ public bool IsCommunityPortalOverride;
        [NMS(Index = 40)]
        /* 0x4AA */ public bool MustFindSystem;
        [NMS(Index = 21)]
        /* 0x4AB */ public bool NeverShow;
        [NMS(Index = 4)]
        /* 0x4AC */ public bool NPCReactsToPlayer;
        [NMS(Index = 34)]
        /* 0x4AD */ public bool ReplaceEventIfAlreadyActive;
        [NMS(Index = 79)]
        /* 0x4AE */ public bool RequiresSpacePoiDiscoveryLevel;
        [NMS(Index = 77)]
        /* 0x4AF */ public bool RequiresSpacePoiType;
        [NMS(Index = 68)]
        /* 0x4B0 */ public bool ShowEndTooltip;
        [NMS(Index = 22)]
        /* 0x4B1 */ public bool ShowOnlyIfSequenceTarget;
        [NMS(Index = 84)]
        /* 0x4B2 */ public bool SpacePoiSetToUndiscovered;
        [NMS(Index = 37)]
        /* 0x4B3 */ public GcBuildingClassification SpecificBuildingClass;
        [NMS(Index = 86)]
        /* 0x4B4 */ public bool SuppressSpacePoiActivity;
        [NMS(Index = 42)]
        /* 0x4B5 */ public bool TargetMustMatchMissionSeed;
        [NMS(Index = 67)]
        /* 0x4B6 */ public bool TooltipRepeats;
        [NMS(Index = 43)]
        /* 0x4B7 */ public bool UseBuildingFromRendezvousStage;
        [NMS(Index = 19)]
        /* 0x4B8 */ public bool UseMissionTradingDataOverride;
        [NMS(Index = 2)]
        /* 0x4B9 */ public bool UseSeasonDataAsInteraction;
    }
}
