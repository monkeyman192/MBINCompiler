using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x232EAAEF8A20BBF0, NameHash = 0xA12AC584067DF8E0)]
    public class GcNPCPlacementInfo : NMSTemplate
    {
        [NMS(Index = 26)]
        /* 0x000 */ public GcScanToRevealComponentData ScanToRevealData;
        [NMS(Index = 12)]
        /* 0x050 */ public NMSString0x20A ForceInteraction;
        [NMS(Index = 23)]
        /* 0x070 */ public List<NMSString0x10> HideDuringMissions;
        [NMS(Index = 14)]
        /* 0x080 */ public List<GcAlienMoodMissionOverride> MoodMissionOverrideTable;
        [NMS(Index = 0)]
        /* 0x090 */ public NMSString0x10 PlacementRuleId;
        [NMS(Index = 13)]
        /* 0x0A0 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        [NMS(Index = 7)]
        /* 0x0B0 */ public NMSString0x10 SpawnSpecific;
        [NMS(Index = 16)]
        /* 0x0C0 */ public GcNPCPropType DefaultProp;
        [NMS(Index = 5)]
        /* 0x0C4 */ public float FractionOfNodesActive;
        [NMS(Index = 10)]
        /* 0x0C8 */ public GcInteractionType InteractionOverride;
        [NMS(Index = 6)]
        /* 0x0CC */ public int MaxNodesActivated;
        [NMS(Index = 8)]
        /* 0x0D0 */ public GcAlienRace Race;
        [NMS(Index = 4)]
        /* 0x0D4 */ public float SpawnChance;
        [NMS(Index = 11)]
        /* 0x0D8 */ public GcTechnologyCategory TechShopCategory;
        [NMS(Index = 2)]
        /* 0x0DC */ public NMSString0x20 PlacmentNodeName;
        [NMS(Index = 1)]
        /* 0x0FC */ public NMSString0x20 SpawnUnderNodeName;
        [NMS(Index = 20)]
        /* 0x11C */ public bool CanTurn;
        [NMS(Index = 15)]
        /* 0x11D */ public bool DisableInteraction;
        [NMS(Index = 22)]
        /* 0x11E */ public bool IsMannequin;
        [NMS(Index = 3)]
        /* 0x11F */ public bool MustPlace;
        [NMS(Index = 24)]
        /* 0x120 */ public bool OnlyUsePuzzleOverridesIfPlayerOwned;
        [NMS(Index = 18)]
        /* 0x121 */ public bool PlaceAtLeastOne;
        [NMS(Index = 9)]
        /* 0x122 */ public bool SpawnAnyMajorRace;
        [NMS(Index = 21)]
        /* 0x123 */ public bool SpawnInAbandoned;
        [NMS(Index = 19)]
        /* 0x124 */ public bool SpawnMoving;
        [NMS(Index = 17)]
        /* 0x125 */ public bool UseFreighterNPC;
        [NMS(Index = 25)]
        /* 0x126 */ public bool UseScanToRevealData;
    }
}
