using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB584181F03B9E004, NameHash = 0xEAE36C86E1479AF5)]
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        /* 0x000 */ public GcInteractionActivationCost ActivationCost;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x068 */ public NMSString0x10[] RarityLocators;
        /* 0x098 */ public NMSString0x20A Name;
        /* 0x0B8 */ public NMSString0x20A ScanData;
        /* 0x0D8 */ public NMSString0x20A ScanType;
        /* 0x0F8 */ public NMSString0x20A TerminalHeading;
        /* 0x118 */ public NMSString0x20A TerminalMessage;
        /* 0x138 */ public NMSString0x20A VRInteractMessage;
        /* 0x158 */ public List<GcInteractionBaseBuildingState> BaseBuildingTriggerActions;
        /* 0x168 */ public NMSString0x10 Id;
        /* 0x178 */ public List<GcPersistencyMissionOverride> PersistencyBufferOverride;
        /* 0x188 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x198 */ public NMSString0x10 TriggerAction;
        /* 0x1A8 */ public NMSString0x10 TriggerActionOnPrepare;
        /* 0x1B8 */ public NMSString0x10 TriggerActionToggle;
        /* 0x1C8 */ public float Delay;
        /* 0x1CC */ public int IncreaseCorruptSentinelWanted;
        /* 0x1D0 */ public int InteractCrimeLevel;
        /* 0x1D4 */ public float InteractDistance;
        /* 0x1D8 */ public float InteractFiendCrimeChance;
        /* 0x1DC */ public GcFiendCrime InteractFiendCrimeType;
        /* 0x1E0 */ public GcRarity Rarity;
        /* 0x1E4 */ public GcDiscoveryType ScanIcon;
        // size: 0x24
        public enum SimpleInteractionTypeEnum : uint {
            Interact,
            Treasure,
            Beacon,
            Scan,
            Save,
            CallShip,
            CallVehicle,
            Word,
            Tech,
            GenericReward,
            Feed,
            Ladder,
            ClaimBase,
            TeleportStartPoint,
            TeleportEndPoint,
            Portal,
            Chest,
            ResourceHarvester,
            BaseCapsule,
            Hologram,
            NPCTerminalMessage,
            VehicleBoot,
            BiomeHarvester,
            FreighterGalacticMap,
            FreighterChest,
            Collectable,
            Chair,
            BaseTreasureChest,
            SpawnObject,
            NoiseBox,
            AbandFreighterTeleporter,
            PetEgg,
            SubstancePickup,
            FreighterTeleport,
            MiniPortalTrigger,
            SuperDoopaScanner,
        }
        /* 0x1E8 */ public SimpleInteractionTypeEnum SimpleInteractionType;
        /* 0x1EC */ public GcSizeIndicator Size;
        /* 0x1F0 */ public GcStatsEnum StatToTrack;
        /* 0x1F4 */ public bool ActivateLocatorsFromRarity;
        /* 0x1F5 */ public bool BroadcastTriggerAction;
        /* 0x1F6 */ public bool CanCollectInMech;
        /* 0x1F7 */ public bool HideContents;
        /* 0x1F8 */ public bool InteractIsCrime;
        /* 0x1F9 */ public bool MustBeVisibleToInteract;
        /* 0x1FA */ public bool NeedsStorm;
        /* 0x1FB */ public bool NotifyEncounter;
        /* 0x1FC */ public bool ReseedOnRewardSuccess;
        /* 0x1FD */ public bool StartsBuried;
        /* 0x1FE */ public bool Use2dInteractDistance;
        /* 0x1FF */ public bool UsePersonalPersistentBuffer;
    }
}
