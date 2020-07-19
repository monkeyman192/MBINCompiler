using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC8, GUID = 0xA7D988E9E9BD36EE, NameHash = 0xA12AC584067DF8E0)]
    public class GcNPCPlacementInfo : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string PlacementRuleId;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string SpawnUnderNodeName;
        [NMS(Size = 0x20)]
        /* 0x30 */ public string PlacementNodeName;
        /* 0x50 */ public bool MustPlace;
        /* 0x54 */ public float SpawnChance;
        /* 0x58 */ public float FractionOfNodesActive;
        /* 0x5C */ public int MaxNodesActivated;
        [NMS(Size = 0x10)]
        /* 0x60 */ public string SpawnSpecific;
        /* 0x70 */ public GcAlienRace Race;
        /* 0x74 */ public GcInteractionType InteractionOverride;
        /* 0x78 */ public GcTechnologyCategory TechShopCategory;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x7C */ public byte[] Padding7C;
        [NMS(Size = 0x20)]
        /* 0x80 */ public string ForceInteraction;
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
