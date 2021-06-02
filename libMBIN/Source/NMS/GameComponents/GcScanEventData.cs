using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5E0, Alignment = 0x8, GUID = 0xC94E09D75F416150, NameHash = 0x7BBBCE7D7BC0F1F4)]
    public class GcScanEventData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 Name;
        /* 0x020 */ public NMSString0x20 ForceInteraction;
        /* 0x040 */ public GcInteractionType ForceInteractionType;
        /* 0x044 */ public bool ForceBroken;
        /* 0x045 */ public bool ForceFixed;
        /* 0x046 */ public bool ForceOverridesAll;
        /* 0x047 */ public bool IsCommunityPortalOverride;
        /* 0x048 */ public bool ClearForcedInteractionOnCompletion;
        /* 0x04C */ public float BuildingPreventionRadius;
        /* 0x050 */ public bool AlwaysShow;
        /* 0x051 */ public bool NeverShow;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x052 */ public byte[] Padding52;
        /* 0x058 */ public NMSString0x20 PlanetLabelText;
        /* 0x078 */ public float SurveyDistance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x07C */ public byte[] Padding7C;
        /* 0x080 */ public NMSString0x20 SurveyDiscoveryOSDMessage;
        public enum EventStartTypeEnum { None, Special, Discovered, Timer, ObjectScan, LeaveBuilding }
		/* 0x0A0 */ public EventStartTypeEnum EventStartType;
		public enum EventEndTypeEnum { None, Proximity, Interact, EnterBuilding, TimedInteract }
		/* 0x0A4 */ public EventEndTypeEnum EventEndType;
		public enum EventPriorityEnum { Regular, High }
		/* 0x0A8 */ public EventPriorityEnum EventPriority;
        /* 0x0AC */ public bool CanEndFromOutsideMission;
        /* 0x0AD */ public bool DisableMultiplayerSync;
        /* 0x0AE */ public bool ReplaceEventIfAlreadyActive;
        public enum BuildingLocationEnum { Nearest, AllNearest, Random, RandomOnNearPlanet, RandomOnFarPlanet, PlanetSearch }
		/* 0x0B0 */ public BuildingLocationEnum BuildingLocation;
		public enum BuildingTypeEnum { Any, AnyShelter, AnyNPC, BuildingClass, SpaceStation, SpaceAnomaly, Atlas, Freighter, FreighterBase,
            ExternalPlanetBase, PlanetBaseTerminal, Expedition, TutorialShelter, MPMissionFreighter, Nexus, InitialDistressSignal, SpaceMarker,
            NexusEggMachine, PhotoTarget }
		/* 0x0B4 */ public BuildingTypeEnum BuildingType;
        /* 0x0B8 */ public GcBuildingClassification BuildingClass;
        /* 0x0BC */ public bool AllowFriendsBases;
        /* 0x0BD */ public bool ForceWideRandom;
        /* 0x0BE */ public bool MustFindSystem;
        /* 0x0BF */ public bool AllowOverriddenBuildings;
		public enum SolarSystemLocationEnum { Local, Near, LocalOrNear, NearWithNoExpeditions, FromList, SeasonParty }
		/* 0x0C0 */ public SolarSystemLocationEnum SolarSystemLocation;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C4 */ public byte[] PaddingC4;
        /* 0x0C8 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        /* 0x138 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        /* 0x1A8 */ public bool ForceRestartInteraction;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1A9 */ public byte[] Padding1A9;
        /* 0x1B0 */ public NMSString0x10 HasReward;
        /* 0x1C0 */ public NMSString0x20 NextOption;
        /* 0x1E0 */ public GcScanEventTriggers TriggerActions;
        /* 0x200 */ public List<NMSString0x100> UAsList;
        /* 0x210 */ public GcTechnologyCategory TechShopType;
        /* 0x214 */ public NMSString0x20 OSDMessage;
        /* 0x234 */ public NMSString0x20 InterstellarOSDMessage;
        /* 0x254 */ public NMSString0x20 MarkerLabel;
        /* 0x274 */ public TkTextureResource MarkerIcon;
        /* 0x278 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        /* 0x2FC */ public float StartTime;
        /* 0x300 */ public float MessageTime;
        /* 0x304 */ public float MessageDisplayTime;
        /* 0x308 */ public GcAudioWwiseEvents MessageAudio;
        /* 0x30C */ public float IconTime;
        /* 0x310 */ public float TooltipTime;
        /* 0x314 */ public bool TooltipRepeats;
        /* 0x315 */ public bool ShowEndTooltip;
        /* 0x316 */ public NMSString0x20 TooltipMessage;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x336 */ public byte[] Padding336;
        /* 0x338 */ public GcResourceElement ResourceOverride;
    }
}