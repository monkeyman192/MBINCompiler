namespace MBINCompiler.Models.Structs
{
    public class GcNPCPlacementInfo : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string PlacementRuleId;

        [NMS(Size = 0x20)]
        /* 0x010 */ public string SpawnUnderNodeName;
        [NMS(Size = 0x20)]
        /* 0x030 */ public string PlacementNodeName;
        /* 0x050 */ public bool MustPlace;
        /* 0x054 */ public float SpawnChance;
        /* 0x058 */ public float FractionOfNodesActive;
        /* 0x05C */ public int MaxNodesActivated;
        [NMS(Size = 0x10)]
        /* 0x060 */ public string SpawnSpecific;
        /* 0x070 */ public GcAlienRace Race;
        /* 0x074 */ public GcInteractionType InteractionType;
        
        [NMS(Size = 0x10)]
        /* 0x078 */ public string ForceInteraction;
        /* 0x088 */ public bool DisableInteraction;
        /* 0x089 */ public bool UseFreighterNPC;
        [NMS(Size = 0x6, Ignore = true)]
        public byte[] pad90;
        
    }
}
