using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC8, GUID = 0xB52CEC5AC5E1EB4D, NameHash = 0xA12AC584067DF8E0)]
    public class GcNPCPlacementInfo : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PlacementRuleId;
        /* 0x10 */ public NMSString0x20 SpawnUnderNodeName;
        /* 0x30 */ public NMSString0x20 PlacementNodeName;
        /* 0x50 */ public bool MustPlace;
        /* 0x54 */ public float SpawnChance;
        /* 0x58 */ public float FractionOfNodesActive;
        /* 0x5C */ public int MaxNodesActivated;
        /* 0x60 */ public NMSString0x10 SpawnSpecific;
        /* 0x70 */ public GcAlienRace Race;
        /* 0x74 */ public GcInteractionType InteractionOverride;
        /* 0x78 */ public GcTechnologyCategory TechShopCategory;
        /* 0x80 */ public NMSString0x20A ForceInteraction;
        /* 0xA0 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        /* 0xB0 */ public bool DisableInteraction;
        /* 0xB1 */ public bool UseFreighterNPC;
        /* 0xB2 */ public bool PlaceAtLeastOne;
        /* 0xB3 */ public bool SpawnMoving;
        /* 0xB4 */ public bool SpawnInAbandoned;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0xB5 */ public byte[] PaddingB5;
        /* 0xB8 */ public List<NMSString0x10> HideDuringMissions;
        
    }
}
