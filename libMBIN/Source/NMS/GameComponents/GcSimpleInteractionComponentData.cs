using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1C0, Alignment = 0x8, GUID = 0x3BE4B4A7E69DF575, NameHash = 0xEAE36C86E1479AF5)]
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
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x009 */ public byte[] Padding9;
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
        /* 0x070 */ public GcInteractionActivationCost ActivationCost;
        /* 0x0A8 */ public GcStatsEnum StatToTrack;
        /* 0x0AC */ public bool StartsBuried;
        /* 0x0AD */ public bool MustBeVisibleToInteract;
        /* 0x0AE */ public bool NeedsStorm;
        /* 0x0B0 */ public NMSString0x20A Name;
        /* 0x0D0 */ public NMSString0x20A VRInteractMessage;
        /* 0x0F0 */ public NMSString0x20A TerminalMessage;
        /* 0x110 */ public NMSString0x20A ScanType;
        /* 0x130 */ public NMSString0x20A ScanData;
        /* 0x150 */ public GcDiscoveryTypes ScanIcon;
        /* 0x154 */ public bool ActivateLocatorsFromRarity;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x155 */ public byte[] Padding155;
        [NMS(Size = 0x3)]
        /* 0x158 */ public NMSString0x10[] RarityLocators;
        /* 0x188 */ public List<GcInteractionBaseBuildingState> BaseBuildingTriggerActions;
        /* 0x198 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x1A8 */ public List<GcPersistencyMissionOverride> PersistencyBufferOverride;
        /* 0x1B8 */ public bool UsePersonalPersistentBuffer;
        /* 0x1B9 */ public bool ReseedOnRewardSuccess;
        /* 0x1BA */ public bool CanCollectInMech;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x1BB */ public byte[] EndPadding;
    }
}
