using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0x198, GUID = 0x21D2395E8B4015, NameHash = 0xEAE36C86E1479AF5)]
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        // 0x1E entries
		public enum SimpleInteractionTypeEnum { Interact, Treasure, Beacon, Scan, Save, CallShip, CallVehicle, Word, Tech, GenericReward, Feed, Ladder, ClaimBase, TeleportStartPoint,
            TeleportEndPoint, Portal, Chest, ResourceHarvester, BaseCapsule, Hologram, NPCTerminalMessage, VehicleBoot, BiomeHarvester, FreighterGalacticMap, FreighterChest,
            Collectable, Chair, BaseTreasureChest, SpawnObject, NoiseBox }
		/* 0x00 */ public SimpleInteractionTypeEnum SimpleInteractionType;

        /* 0x04 */ public float InteractDistance;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Id;

        /* 0x18 */ public GcRarity Rarity;
        /* 0x1C */ public GcSizeIndicator Size;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string TriggerAction;
        [NMS(Size = 0x10)]
        /* 0x30 */ public string TriggerActionToggle;
        /* 0x40 */ public bool BroadcastTriggerAction;
        /* 0x44 */ public float Delay;
        /* 0x48 */ public bool HideContents;
        /* 0x49 */ public bool InteractIsCrime;
        /* 0x4C */ public GcFiendCrime InteractFiendCrimeType;
        /* 0x50 */ public int InteractCrimeLevel;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x54 */ public byte[] Padding54;
        /* 0x58 */ public GcInteractionActivationCost ActivationCost;

        /* 0x90 */ public GcStatsEnum StatToTrack;
        /* 0x94 */ public bool StartsBuried;
        /* 0x95 */ public bool MustBeVisibleToInteract;
        /* 0x96 */ public bool NeedsStorm;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x97 */ public byte[] Padding97;

        [NMS(Size = 0x20)]
        /* 0x98 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0xB8 */ public string VRInteractMessage;
        [NMS(Size = 0x20)]
        /* 0xD8 */ public string TerminalMessage;
        [NMS(Size = 0x20)]
        /* 0xF8 */ public string ScanType;
        [NMS(Size = 0x20)]
        /* 0x118 */ public string ScanData;
        /* 0x138 */ public GcDiscoveryTypes ScanIcon;
        /* 0x13C */ public bool ActivateLocatorsFromRarity;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x13D */ public byte[] Padding13D;
        [NMS(Size = 0x3)]
        /* 0x140 */ public NMSString0x10[] RarityLocators;
        /* 0x170 */ public List<GcInteractionBaseBuildingState> BaseBuildingTriggerActions;
        /* 0x180 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x190 */ public bool UsePersonalPersistentBuffer;
        /* 0x191 */ public bool ReseedOnRewardSuccess;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x192 */ public byte[] EndPadding;
    }
}
