using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1C8, Alignment = 0x8, GUID = 0x5142359D32BAE2D2, NameHash = 0xEAE36C86E1479AF5)]
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        // size: 0x21
		public enum SimpleInteractionTypeEnum {
            Interact, Treasure, Beacon, Scan, Save, CallShip, CallVehicle, Word, Tech, GenericReward, Feed, Ladder, ClaimBase, TeleportStartPoint,
            TeleportEndPoint, Portal, Chest, ResourceHarvester, BaseCapsule, Hologram, NPCTerminalMessage, VehicleBoot, BiomeHarvester,
            FreighterGalacticMap, FreighterChest, Collectable, Chair, BaseTreasureChest, SpawnObject, NoiseBox, AbandFreighterTeleporter,
            PetEgg, SubstancePickup
        }
        /* 0x000 */ public SimpleInteractionTypeEnum SimpleInteractionType;
        /* 0x004 */ public float InteractDistance;
        /* 0x008 */ public bool Use2dInteractDistance;
        /* 0x010 */ public NMSString0x10 Id;
        /* 0x020 */ public GcRarity Rarity;
        /* 0x024 */ public GcSizeIndicator Size;
        /* 0x028 */ public NMSString0x10 TriggerAction;
        /* 0x038 */ public NMSString0x10 TriggerActionOnPrepare;
        /* 0x048 */ public NMSString0x10 TriggerActionToggle;
        /* 0x058 */ public bool BroadcastTriggerAction;
        /* 0x05C */ public float Delay;
        /* 0x060 */ public bool HideContents;
        /* 0x061 */ public bool InteractIsCrime;
        /* 0x064 */ public GcFiendCrime InteractFiendCrimeType;
        /* 0x068 */ public float InteractFiendCrimeChance;
        /* 0x06C */ public int InteractCrimeLevel;
        /* 0x070 */ public bool NotifyEncounter;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x071 */ public byte[] Paddin71;
        /* 0x078 */ public GcInteractionActivationCost ActivationCost;
        /* 0x0B0 */ public GcStatsEnum StatToTrack;
        /* 0x0B4 */ public bool StartsBuried;
        /* 0x0B5 */ public bool MustBeVisibleToInteract;
        /* 0x0B6 */ public bool NeedsStorm;
        /* 0x0B8 */ public NMSString0x20A Name;
        /* 0x0D8 */ public NMSString0x20A VRInteractMessage;
        /* 0x0F8 */ public NMSString0x20A TerminalMessage;
        /* 0x118 */ public NMSString0x20A ScanType;
        /* 0x138 */ public NMSString0x20A ScanData;
        /* 0x158 */ public GcDiscoveryTypes ScanIcon;
        /* 0x15C */ public bool ActivateLocatorsFromRarity;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x15D */ public byte[] Padding15D;
        [NMS(Size = 0x3)]
        /* 0x160 */ public NMSString0x10[] RarityLocators;
        /* 0x190 */ public List<GcInteractionBaseBuildingState> BaseBuildingTriggerActions;
        /* 0x1A0 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x1B0 */ public List<GcPersistencyMissionOverride> PersistencyBufferOverride;
        /* 0x1C0 */ public bool UsePersonalPersistentBuffer;
        /* 0x1C1 */ public bool ReseedOnRewardSuccess;
        /* 0x1C2 */ public bool CanCollectInMech;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x1C3 */ public byte[] EndPadding;
    }
}
