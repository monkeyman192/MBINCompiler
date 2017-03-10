using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        public int SimpleInteractionType;
        /* 0x00 */ public string[] SimpleInteractionTypeValues()
        {
            return new[] { "Interact", "Treasure", "Beacon", "Scan", "Save", "CallShip", "Word", "Tech", "GenericReward", "Feed",
                "Teleport", "ClaimBase", "TeleportStartPoint", "TeleportEndPoint", "Portal", "Chest", "ResourceHarvester",
                "BaseCapsule", "NPCTerminalMessage"};
        }

        /* 0x04 */ public float InteractDistance;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Id;

        /* 0x18 */ public GcRarity Rarity;
        /* 0x1C */ public GcSizeIndicator SizeIndicator;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string TriggerAction;
        /* 0x30 */ public bool BroadcastTriggerAction;
        /* 0x34 */ public float Delay;

        /* 0x38 */ public bool InteractIsCrime;
        /* 0x3C */ public int InteractCrimeLevel;
        /* 0x40 */ public GcInteractionActivationCost ActivationCost;

        [NMS(Size = 0x20)]
        /* 0x78 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0x98 */ public string TerminalMessage;
        /* 0xB8 */ public List<GcBaseBuildingTriggerAction> BaseBuildingTriggerActions;
    }
}
