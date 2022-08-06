using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDAF8F57E112A338E, NameHash = 0x7BBBCE7D7BC0F1F4)]
    public class GcScanEventData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Name;
        /* 0x020 */ public NMSString0x20A ForceInteraction;
        /* 0x040 */ public GcInteractionType ForceInteractionType;
        /* 0x044 */ public GcAlienRace RequireInteractionRace;
        /* 0x048 */ public bool ForceBroken;
        /* 0x049 */ public bool ForceFixed;
        /* 0x04A */ public bool ForceOverridesAll;
        /* 0x050 */ public NMSString0x10 ForceOverrideEncounter;
        /* 0x060 */ public bool IsCommunityPortalOverride;
        /* 0x061 */ public bool ClearForcedInteractionOnCompletion;
        /* 0x064 */ public float BuildingPreventionRadius;
        /* 0x068 */ public bool AlwaysShow;
        /* 0x069 */ public bool NeverShow;
        /* 0x070 */ public NMSString0x20A PlanetLabelText;
        /* 0x090 */ public float SurveyDistance;
        /* 0x098 */ public NMSString0x20A SurveyDiscoveryOSDMessage;
        // size: 0x6
        public enum EventStartTypeEnum { None, Special, Discovered, Timer, ObjectScan, LeaveBuilding }
        /* 0x0B8 */ public EventStartTypeEnum EventStartType;
        // size: 0x5
        public enum EventEndTypeEnum { None, Proximity, Interact, EnterBuilding, TimedInteract }
        /* 0x0BC */ public EventEndTypeEnum EventEndType;
        // size: 0x2
        public enum EventPriorityEnum { Regular, High }
        /* 0x0C0 */ public EventPriorityEnum EventPriority;
        /* 0x0C4 */ public bool CanEndFromOutsideMission;
        /* 0x0C5 */ public bool DisableMultiplayerSync;
        /* 0x0C6 */ public bool ReplaceEventIfAlreadyActive;
        // size: 0x7
        public enum BuildingLocationEnum { Nearest, AllNearest, Random, RandomOnNearPlanet, RandomOnFarPlanet, PlanetSearch,
            PlayerSettlement
        }
        /* 0x0C8 */ public BuildingLocationEnum BuildingLocation;
        // size: 0x17
        public enum BuildingTypeEnum { Any, AnyShelter, AnyNPC, BuildingClass, SpaceStation, SpaceAnomaly, Atlas,
            Freighter, FreighterBase, ExternalPlanetBase, PlanetBaseTerminal, Expedition,
            TutorialShelter, MPMissionFreighter, Nexus, InitialDistressSignal,
            SpaceMarker, NexusEggMachine, PhotoTarget, SettlementConstruction,
            UnownedSettlement, NPC_HideOut, FriendlyDrone
        }
        /* 0x0CC */ public BuildingTypeEnum BuildingType;
        /* 0x0D0 */ public GcBuildingClassification BuildingClass;
        /* 0x0D4 */ public bool AllowFriendsBases;
        /* 0x0D5 */ public bool ForceWideRandom;
        /* 0x0D6 */ public bool MustFindSystem;
        /* 0x0D7 */ public bool AllowOverriddenBuildings;
        // size: 0x6
        public enum SolarSystemLocationEnum { Local, Near, LocalOrNear, NearWithNoExpeditions, FromList, SeasonParty }
        /* 0x0D8 */ public SolarSystemLocationEnum SolarSystemLocation;
        /* 0x0E0 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        /* 0x150 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        /* 0x1C0 */ public bool ForceRestartInteraction;
        /* 0x1C8 */ public NMSString0x10 HasReward;
        /* 0x1D8 */ public NMSString0x20A NextOption;
        /* 0x1F8 */ public GcScanEventTriggers TriggerActions;
        /* 0x218 */ public List<NMSString0x100> UAsList;
        /* 0x228 */ public GcTechnologyCategory TechShopType;
        /* 0x22C */ public NMSString0x20 OSDMessage;
        /* 0x24C */ public NMSString0x20 InterstellarOSDMessage;
        /* 0x26C */ public NMSString0x20 MarkerLabel;
        /* 0x28C */ public TkTextureResource MarkerIcon;
        /* 0x310 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        /* 0x314 */ public float StartTime;
        /* 0x318 */ public float MessageTime;
        /* 0x31C */ public float MessageDisplayTime;
        /* 0x320 */ public GcAudioWwiseEvents MessageAudio;
        /* 0x324 */ public float IconTime;
        /* 0x328 */ public float TooltipTime;
        /* 0x32C */ public bool TooltipRepeats;
        /* 0x32D */ public bool ShowEndTooltip;
        /* 0x32E */ public NMSString0x20 TooltipMessage;
        /* 0x350 */ public GcResourceElement ResourceOverride;
    }
}
