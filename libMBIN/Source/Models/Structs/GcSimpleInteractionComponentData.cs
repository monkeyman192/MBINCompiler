using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x130)]
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
		public enum SimpleInteractionTypeEnum { Interact, Treasure, Beacon, Scan, Save, CallShip, CallVehicle, Word, Tech, GenericReward, Feed, Ladder, ClaimBase, TeleportStartPoint, TeleportEndPoint, Portal, Chest, ResourceHarvester, BaseCapsule, Hologram, NPCTerminalMessage, VehicleBoot, BiomeHarvester, FreighterGalacticMap }
		public SimpleInteractionTypeEnum SimpleInteractionType;

        /* 0x04 */ public float InteractDistance;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Id;

        /* 0x18 */ public GcRarity Rarity;
        /* 0x1C */ public GcSizeIndicator SizeIndicator;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string TriggerAction;
        /* 0x30 */ public bool BroadcastTriggerAction;
        /* 0x34 */ public float Delay;
        /* 0x38 */ public bool HideContents;
        /* 0x39 */ public bool InteractIsCrime;
        /* 0x3C */ public int InteractCrimeLevel;
        /* 0x40 */ public GcInteractionActivationCost ActivationCost;

        /* 0x78 */ public GcStatsEnum StatToTrack;
        /* 0x7C */ public bool StartsBuried;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x7D */ public byte[] Padding7D;

        [NMS(Size = 0x20)]
        /* 0x80 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0xA0 */ public string TerminalMessage;
        [NMS(Size = 0x20)]
        /* 0xC0 */ public string ScanType;
        [NMS(Size = 0x20)]
        /* 0xE0 */ public string ScanData;
        /* 0x100 */ public GcDiscoveryTypes ScanIcon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x104 */ public byte[] Padding104;
        /* 0x108 */ public List<GcBaseBuildingTriggerAction> BaseBuildingTriggerActions;
        /* 0x118 */ public List<int> RewardOverrideTable;       // I don't know...
        /* 0x128 */ public bool UsePersonalPersistentBuffer;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x129 */ public byte[] EndPadding;
    }
}
