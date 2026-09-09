using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6E019A0A687C183, NameHash = 0x60BCEB20)]
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        [NMS(Index = 20)]
        /* 0x000 */ public GcInteractionActivationCost ActivationCost;
        [NMS(Index = 34, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x068 */ public NMSString0x10[] RarityLocators;
        [NMS(Index = 26)]
        /* 0x098 */ public NMSString0x20A ForceSubtitle;
        [NMS(Index = 25)]
        /* 0x0B8 */ public NMSString0x20A Name;
        [NMS(Index = 31)]
        /* 0x0D8 */ public NMSString0x20A ScanData;
        [NMS(Index = 30)]
        /* 0x0F8 */ public NMSString0x20A ScanType;
        [NMS(Index = 28)]
        /* 0x118 */ public NMSString0x20A TerminalHeading;
        [NMS(Index = 29)]
        /* 0x138 */ public NMSString0x20A TerminalMessage;
        [NMS(Index = 27)]
        /* 0x158 */ public NMSString0x20A VRInteractMessage;
        [NMS(Index = 35)]
        /* 0x178 */ public List<GcInteractionBaseBuildingState> BaseBuildingTriggerActions;
        [NMS(Index = 4)]
        /* 0x188 */ public NMSString0x10 Id;
        [NMS(Index = 44)]
        /* 0x198 */ public List<int> OnlyActiveDuringSeasons;
        [NMS(Index = 37)]
        /* 0x1A8 */ public List<GcPersistencyMissionOverride> PersistencyBufferOverride;
        [NMS(Index = 36)]
        /* 0x1B8 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        [NMS(Index = 7)]
        /* 0x1C8 */ public NMSString0x10 TriggerAction;
        [NMS(Index = 8)]
        /* 0x1D8 */ public NMSString0x10 TriggerActionOnPrepare;
        [NMS(Index = 9)]
        /* 0x1E8 */ public NMSString0x10 TriggerActionToggle;
        [NMS(Index = 10)]
        /* 0x1F8 */ public float DeactivateSimilarInteractionsNearbyRadius;
        [NMS(Index = 12)]
        /* 0x1FC */ public float Delay;
        [NMS(Index = 18)]
        /* 0x200 */ public int IncreaseCorruptSentinelWanted;
        [NMS(Index = 3)]
        /* 0x204 */ public float InteractAngle;
        [NMS(Index = 17)]
        /* 0x208 */ public int InteractCrimeLevel;
        [NMS(Index = 1)]
        /* 0x20C */ public float InteractDistance;
        [NMS(Index = 16)]
        /* 0x210 */ public float InteractFiendCrimeChance;
        [NMS(Index = 15)]
        /* 0x214 */ public GcFiendCrime InteractFiendCrimeType;
        [NMS(Index = 5)]
        /* 0x218 */ public GcRarity Rarity;
        [NMS(Index = 32)]
        /* 0x21C */ public GcDiscoveryType ScanIcon;
        // size: 0x2A
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
            RefundedCorvetteStorage,
            CorvetteMissionBoard,
            CorvetteRampSwitch,
            JoinTable,
            RoverDumpSwitch,
            TractorBeamEject,
        }
        [NMS(Index = 0)]
        /* 0x220 */ public SimpleInteractionTypeEnum SimpleInteractionType;
        [NMS(Index = 6)]
        /* 0x224 */ public GcSizeIndicator Size;
        [NMS(Index = 21)]
        /* 0x228 */ public GcStatsEnum StatToTrack;
        [NMS(Index = 33)]
        /* 0x22C */ public bool ActivateLocatorsFromRarity;
        [NMS(Index = 41)]
        /* 0x22D */ public bool AnimateOnInteract;
        [NMS(Index = 11)]
        /* 0x22E */ public bool BroadcastTriggerAction;
        [NMS(Index = 40)]
        /* 0x22F */ public bool CanCollectInMech;
        [NMS(Index = 42)]
        /* 0x230 */ public bool DisableAnimationUntilInteract;
        [NMS(Index = 13)]
        /* 0x231 */ public bool HideContents;
        [NMS(Index = 43)]
        /* 0x232 */ public bool HideInteractLabelUntilRelease;
        [NMS(Index = 14)]
        /* 0x233 */ public bool InteractIsCrime;
        [NMS(Index = 23)]
        /* 0x234 */ public bool MustBeVisibleToInteract;
        [NMS(Index = 24)]
        /* 0x235 */ public bool NeedsStorm;
        [NMS(Index = 19)]
        /* 0x236 */ public bool NotifyEncounter;
        [NMS(Index = 39)]
        /* 0x237 */ public bool ReseedOnRewardSuccess;
        [NMS(Index = 22)]
        /* 0x238 */ public bool StartsBuried;
        [NMS(Index = 2)]
        /* 0x239 */ public bool Use2dInteractDistance;
        [NMS(Index = 38)]
        /* 0x23A */ public bool UsePersonalPersistentBuffer;
    }
}
