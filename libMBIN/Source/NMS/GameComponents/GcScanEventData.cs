using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2F8, Alignment = 0x8, GUID = 0xCFB90ED6E2063076, NameHash = 0x7BBBCE7D7BC0F1F4)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string ForceInteraction;
        /* 0x040 */ public GcInteractionType ForceInteractionType;
        /* 0x044 */ public bool ForceBroken;
        /* 0x045 */ public bool ForceFixed;
        /* 0x046 */ public bool ForceOverridesAll;
        /* 0x047 */ public bool IsCommunityPortalOverride;
        /* 0x048 */ public bool ClearForcedInteractionOnCompletion;
        /* 0x049 */ public bool AlwaysShow;
        /* 0x04A */ public bool NeverShow;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x04B */ public byte[] Padding4B;
        [NMS(Size = 0x20)]
        /* 0x050 */ public string PlanetLabelText;

        public enum EventStartTypeEnum { None, Special, Discovered, Timer, ObjectScan, LeaveBuilding }
		/* 0x070 */ public EventStartTypeEnum EventStartType;
		public enum EventEndTypeEnum { None, Proximity, Interact, EnterBuilding, TimedInteract }
		/* 0x074 */ public EventEndTypeEnum EventEndType;
		public enum EventPriorityEnum { Regular, High }
		/* 0x078 */ public EventPriorityEnum EventPriority;

        /* 0x07C */ public bool CanEndFromOutsideMission;
        /* 0x07D */ public bool DisableMultiplayerSync;
        /* 0x07E */ public bool ReplaceEventIfAlreadyActive;

        public enum BuildingLocationEnum { Nearest, AllNearest, Random, RandomOnNearPlanet, RandomOnFarPlanet, PlanetSearch }
		/* 0x080 */ public BuildingLocationEnum BuildingLocation;
		public enum BuildingTypeEnum { Any, AnyShelter, AnyNPC, BuildingClass, SpaceStation, SpaceAnomaly, Atlas, Freighter, FreighterBase,
            ExternalPlanetBase, PlanetBaseTerminal, Expedition, TutorialShelter, MPMissionFreighter, Nexus, InitialDistressSignal }
		/* 0x084 */ public BuildingTypeEnum BuildingType;
        /* 0x088 */ public GcBuildingClassification BuildingClass;
        /* 0x08C */ public bool AllowFriendBases;

		public enum SolarSystemLocationEnum { Local, Near, LocalOrNear, NearWithNoExpeditions, FromList }
		/* 0x090 */ public SolarSystemLocationEnum SolarSystemLocation;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x094 */ public byte[] Padding94;

        /* 0x098 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        /* 0x100 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        /* 0x168 */ public bool ForceRestartInteraction;
        [NMS(Size = 7, Ignore = true)]
        /* 0x169 */ public byte[] Padding169;
        [NMS(Size = 0x10)]
        /* 0x170 */ public string HasReward;
        [NMS(Size = 0x20)]
        /* 0x180 */ public string NextOption;
        /* 0x1A0 */ public GcScanEventTriggers TriggerActions;
        /* 0x1C0 */ public List<NMSString0x100> UAsList;
        /* 0x1D0 */ public GcTechnologyCategory TechShopType;
        [NMS(Size = 0x20)]
        /* 0x1D4 */ public string OSDMessage;
        [NMS(Size = 0x20)]
        /* 0x1F4 */ public string InterstellarOSDMessage;
        [NMS(Size = 0x20)]
        /* 0x214 */ public string MarkerLabel;
        /* 0x234 */ public TkTextureResource MarkerIcon;
        /* 0x2B8 */ public float StartTime;
        /* 0x2BC */ public float MessageTime;
        /* 0x2C0 */ public float MessageDisplayTime;
        /* 0x2C4 */ public GcAudioWwiseEvents MessageAudio;
        /* 0x2C8 */ public float IconTime;
        /* 0x2CC */ public float TooltipTime;
        /* 0x2D0 */ public bool TooltipRepeats;
        /* 0x2D1 */ public bool ShowEndTooltip;
        [NMS(Size = 0x20)]
        /* 0x2D2 */ public string TooltipMessage;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x2E2 */ public byte[] EndPadding;
    }
}