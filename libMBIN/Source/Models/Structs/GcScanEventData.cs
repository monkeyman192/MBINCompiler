using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1F0)]
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
        /* 0x047 */ public bool AlwaysShow;
        /* 0x048 */ public bool IsCommunityPortalOverride;

        /* 0x04C */ public int EventStartType;
        public string[] EventStartTypeValues()
        {
            return new[] { "None", "Special", "Discovered", "Timer", "ObjectScan", "LeaveBuilding" };
        }
        /* 0x050 */ public int EventEndType;
        public string[] EventEndTypeValues()
        {
            return new[] { "None", "Proximity", "Interact", "EnterBuilding", "TimedInteract" };
        }
        /* 0x054 */ public int EventPriority;
        public string[] EventPriorityValues()
        {
            return new[] { "Regular", "High" };
        }

        /* 0x058 */ public bool CanEndFromOutsideMission;

        /* 0x05C */ public int BuildingLocation;
        public string[] BuildingLocationValues()
        {
            return new[] { "Nearest", "AllNearest", "Random", "RandomOnNearPlanet", "RandomOnFarPlanet" };
        }
        /* 0x060 */ public int BuildingType;
        public string[] BuildingTypeValues()
        {
            return new[] { "Any", "AnyShelter", "AnyNPC", "BuildingClass", "SpaceStation", "SpaceAnomaly",
                           "Atlas", "Freighter", "FreighterBase", "ExternalPlanetBase", "PlanetBaseTerminal",
                           "Expedition", "TutorialShelter", "MPMissionFreighter"};
        }
        /* 0x064 */ public GcBuildingClassification BuildingClass;
        /* 0x068 */ public bool AllowFriendBases;

        /* 0x06C */ public int SolarSystemLocation;
        public string[] SolarSystemLocationValues()
        {
            return new[] { "Local", "Near", "LocalOrNear", "NearWithNoExpeditions", "FromList"};
        }

        /* 0x070 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        /* 0x08C */ public bool ForceRestartInteraction;
        [NMS(Size = 3, Ignore = true)]
        /* 0x08D */ public byte[] Padding8D;
        [NMS(Size = 0x10)]
        /* 0x090 */ public string HasReward;
        [NMS(Size = 0x20)]
        /* 0x0A0 */ public string NextOption;
        /* 0x0C0 */ public GcScanEventTriggers TriggerActions;
        /* 0x0E0 */ public List<NMSString0x100> UAsList;        //maybe??
        [NMS(Size = 0x20)]
        /* 0x0F0 */ public string OSDMessage;
        [NMS(Size = 0x20)]
        /* 0x110 */ public string MarkerLabel;
        /* 0x130 */ public TkTextureResource MarkerIcon;
        /* 0x1B4 */ public float StartTime;
        /* 0x1B8 */ public float MessageTime;
        /* 0x1BC */ public float MessageDisplayTime;
        /* 0x1C0 */ public GcAudioWwiseEvents MessageAudio;
        /* 0x1C4 */ public float IconTime;
        /* 0x1C8 */ public float TooltipTime;
        /* 0x1CC */ public bool TooltipRepeats;
        /* 0x1CD */ public bool ShowEndTooltip;
        [NMS(Size = 0x20)]
        /* 0x1CE */ public string TooltipMessage;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1EE */ public byte[] EndPadding;
    }
}