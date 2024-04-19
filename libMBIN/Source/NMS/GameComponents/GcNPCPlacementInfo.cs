using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x232EAAEF8A20BBF0, NameHash = 0xA12AC584067DF8E0)]
    public class GcNPCPlacementInfo : NMSTemplate
    {
        /* 0x000 */ public GcScanToRevealComponentData ScanToRevealData;
        /* 0x050 */ public NMSString0x20A ForceInteraction;
        /* 0x070 */ public List<NMSString0x10> HideDuringMissions;
        /* 0x080 */ public List<GcAlienMoodMissionOverride> MoodMissionOverrideTable;
        /* 0x090 */ public NMSString0x10 PlacementRuleId;
        /* 0x0A0 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        /* 0x0B0 */ public NMSString0x10 SpawnSpecific;
        /* 0x0C0 */ public GcNPCPropType DefaultProp;
        /* 0x0C4 */ public float FractionOfNodesActive;
        /* 0x0C8 */ public GcInteractionType InteractionOverride;
        /* 0x0CC */ public int MaxNodesActivated;
        /* 0x0D0 */ public GcAlienRace Race;
        /* 0x0D4 */ public float SpawnChance;
        /* 0x0D8 */ public GcTechnologyCategory TechShopCategory;
        /* 0x0DC */ public NMSString0x20 PlacmentNodeName;
        /* 0x0FC */ public NMSString0x20 SpawnUnderNodeName;
        /* 0x11C */ public bool CanTurn;
        /* 0x11D */ public bool DisableInteraction;
        /* 0x11E */ public bool IsMannequin;
        /* 0x11F */ public bool MustPlace;
        /* 0x120 */ public bool OnlyUsePuzzleOverridesIfPlayerOwned;
        /* 0x121 */ public bool PlaceAtLeastOne;
        /* 0x122 */ public bool SpawnAnyMajorRace;
        /* 0x123 */ public bool SpawnInAbandoned;
        /* 0x124 */ public bool SpawnMoving;
        /* 0x125 */ public bool UseFreighterNPC;
        /* 0x126 */ public bool UseScanToRevealData;
    }
}
