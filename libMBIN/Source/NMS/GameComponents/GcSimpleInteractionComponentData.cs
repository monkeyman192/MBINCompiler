using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8FAA9B7632EA1B1, NameHash = 0xEAE36C86E1479AF5)]
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x000 */ public GcInteractionActivationCost ActivationCost;
        [NMS(Index = 31, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x068 */ public NMSString0x10[] RarityLocators;
        [NMS(Index = 23)]
        /* 0x098 */ public NMSString0x20A Name;
        [NMS(Index = 28)]
        /* 0x0B8 */ public NMSString0x20A ScanData;
        [NMS(Index = 27)]
        /* 0x0D8 */ public NMSString0x20A ScanType;
        [NMS(Index = 25)]
        /* 0x0F8 */ public NMSString0x20A TerminalHeading;
        [NMS(Index = 26)]
        /* 0x118 */ public NMSString0x20A TerminalMessage;
        [NMS(Index = 24)]
        /* 0x138 */ public NMSString0x20A VRInteractMessage;
        [NMS(Index = 32)]
        /* 0x158 */ public List<GcInteractionBaseBuildingState> BaseBuildingTriggerActions;
        [NMS(Index = 3)]
        /* 0x168 */ public NMSString0x10 Id;
        [NMS(Index = 34)]
        /* 0x178 */ public List<GcPersistencyMissionOverride> PersistencyBufferOverride;
        [NMS(Index = 33)]
        /* 0x188 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        [NMS(Index = 6)]
        /* 0x198 */ public NMSString0x10 TriggerAction;
        [NMS(Index = 7)]
        /* 0x1A8 */ public NMSString0x10 TriggerActionOnPrepare;
        [NMS(Index = 8)]
        /* 0x1B8 */ public NMSString0x10 TriggerActionToggle;
        [NMS(Index = 10)]
        /* 0x1C8 */ public float Delay;
        [NMS(Index = 16)]
        /* 0x1CC */ public int IncreaseCorruptSentinelWanted;
        [NMS(Index = 15)]
        /* 0x1D0 */ public int InteractCrimeLevel;
        [NMS(Index = 1)]
        /* 0x1D4 */ public float InteractDistance;
        [NMS(Index = 14)]
        /* 0x1D8 */ public float InteractFiendCrimeChance;
        [NMS(Index = 13)]
        /* 0x1DC */ public GcFiendCrime InteractFiendCrimeType;
        [NMS(Index = 4)]
        /* 0x1E0 */ public GcRarity Rarity;
        [NMS(Index = 29)]
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
        [NMS(Index = 0)]
        /* 0x1E8 */ public SimpleInteractionTypeEnum SimpleInteractionType;
        [NMS(Index = 5)]
        /* 0x1EC */ public GcSizeIndicator Size;
        [NMS(Index = 19)]
        /* 0x1F0 */ public GcStatsEnum StatToTrack;
        [NMS(Index = 30)]
        /* 0x1F4 */ public bool ActivateLocatorsFromRarity;
        [NMS(Index = 9)]
        /* 0x1F5 */ public bool BroadcastTriggerAction;
        [NMS(Index = 37)]
        /* 0x1F6 */ public bool CanCollectInMech;
        [NMS(Index = 11)]
        /* 0x1F7 */ public bool HideContents;
        [NMS(Index = 12)]
        /* 0x1F8 */ public bool InteractIsCrime;
        [NMS(Index = 21)]
        /* 0x1F9 */ public bool MustBeVisibleToInteract;
        [NMS(Index = 22)]
        /* 0x1FA */ public bool NeedsStorm;
        [NMS(Index = 17)]
        /* 0x1FB */ public bool NotifyEncounter;
        [NMS(Index = 36)]
        /* 0x1FC */ public bool ReseedOnRewardSuccess;
        [NMS(Index = 20)]
        /* 0x1FD */ public bool StartsBuried;
        [NMS(Index = 2)]
        /* 0x1FE */ public bool Use2dInteractDistance;
        [NMS(Index = 35)]
        /* 0x1FF */ public bool UsePersonalPersistentBuffer;
    }
}
