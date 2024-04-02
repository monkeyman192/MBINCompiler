using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x232EAAEF8A20BBF0, NameHash = 0xA12AC584067DF8E0)]
    public class GcNPCPlacementInfo : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PlacementRuleId;
        /* 0x10 */ public NMSString0x20 SpawnUnderNodeName;
        /* 0x30 */ public NMSString0x20 PlacmentNodeName;
        /* 0x50 */ public bool MustPlace;
        /* 0x54 */ public float SpawnChance;
        /* 0x58 */ public float FractionOfNodesActive;
        /* 0x5C */ public int MaxNodesActivated;
        /* 0x60 */ public NMSString0x10 SpawnSpecific;
        /* 0x70 */ public GcAlienRace Race;
        /* 0x74 */ public bool SpawnAnyMajorRace;
        /* 0x78 */ public GcInteractionType InteractionOverride;
        /* 0x7C */ public GcTechnologyCategory TechShopCategory;
        /* 0x80 */ public NMSString0x20A ForceInteraction;
        /* 0xA0 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        /* 0xB0 */ public List<GcAlienMoodMissionOverride> MoodMissionOverrideTable;
        /* 0xC0 */ public bool DisableInteraction;
        /* 0xC4 */ public GcNPCPropType DefaultProp;
        /* 0xC8 */ public bool UseFreighterNPC;
        /* 0xC9 */ public bool PlaceAtLeastOne;
        /* 0xCA */ public bool SpawnMoving;
        /* 0xCB */ public bool CanTurn;
        /* 0xCC */ public bool SpawnInAbandoned;
        /* 0xCD */ public bool IsMannequin;
        /* 0xD0 */ public List<NMSString0x10> HideDuringMissions;
        /* 0xE0 */ public bool OnlyUsePuzzleOverridesIfPlayerOwned;
        /* 0xE1 */ public bool UseScanToRevealData;
        /* 0xE8 */ public GcScanToRevealComponentData ScanToRevealData;
    }
}
