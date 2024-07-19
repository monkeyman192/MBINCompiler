using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5278DA4D312060E, NameHash = 0x5E49C3E9)]
    public class GcPlayerStateData : NMSTemplate
    {
        [NMS(Index = 119)]
        /* 0x00000 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Index = 208, Size = 0x64)]
        /* 0x3C780 */ public GcSettlementState[] SettlementStatesV2;
        [NMS(Index = 154, Size = 0xC)]
        /* 0x5B540 */ public GcPlayerOwnershipData[] ShipOwnership;
        [NMS(Index = 152, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x5EE40 */ public GcPlayerOwnershipData[] VehicleOwnership;
        [NMS(Index = 12, Size = 0x6)]
        /* 0x60F80 */ public GcMultitoolData[] Multitools;
        [NMS(Index = 120, Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x61E80 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Index = 85, Size = 0x10)]
        /* 0x62100 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 185)]
        /* 0x62200 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        [NMS(Index = 167)]
        /* 0x622D0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        [NMS(Index = 43)]
        /* 0x62350 */ public GcInteractionData HoloExplorerInteraction;
        [NMS(Index = 45)]
        /* 0x62370 */ public GcInteractionData HoloNooneInteraction;
        [NMS(Index = 44)]
        /* 0x62390 */ public GcInteractionData HoloScepticInteraction;
        [NMS(Index = 95)]
        /* 0x623B0 */ public Vector4f AnomalyPositionOverride;
        [NMS(Index = 99)]
        /* 0x623C0 */ public Vector4f FirstShipPosition;
        [NMS(Index = 71)]
        /* 0x623D0 */ public Vector4f FirstSpawnPosition;
        [NMS(Index = 112)]
        /* 0x623E0 */ public Vector3f FreighterMatrixAt;
        [NMS(Index = 114)]
        /* 0x623F0 */ public Vector3f FreighterMatrixPos;
        [NMS(Index = 113)]
        /* 0x62400 */ public Vector3f FreighterMatrixUp;
        [NMS(Index = 23)]
        /* 0x62410 */ public Vector4f GraveMatrixLookAt;
        [NMS(Index = 24)]
        /* 0x62420 */ public Vector4f GraveMatrixUp;
        [NMS(Index = 22)]
        /* 0x62430 */ public Vector4f GravePosition;
        [NMS(Index = 195)]
        /* 0x62440 */ public Vector3f NexusMatrixAt;
        [NMS(Index = 197)]
        /* 0x62450 */ public Vector3f NexusMatrixPos;
        [NMS(Index = 196)]
        /* 0x62460 */ public Vector3f NexusMatrixUp;
        [NMS(Index = 168)]
        /* 0x62470 */ public Vector4f PortalMarkerPosition_Local;
        [NMS(Index = 169)]
        /* 0x62480 */ public Vector4f PortalMarkerPosition_Offset;
        [NMS(Index = 159)]
        /* 0x62490 */ public Vector4f StartGameShipPosition;
        [NMS(Index = 15, Size = 0x12)]
        /* 0x624A0 */ public GcPetData[] Eggs;
        [NMS(Index = 14, Size = 0x12)]
        /* 0x64930 */ public GcPetData[] Pets;
        [NMS(Index = 16, Size = 0x12)]
        /* 0x66DC0 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 172, Size = 0x18, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x683B0 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Index = 188, Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x68D70 */ public GcHotActionsSaveData[] HotActions;
        [NMS(Index = 116, Size = 0x4)]
        /* 0x69130 */ public GcSquadronPilotData[] SquadronPilots;
        [NMS(Index = 215, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x693B0 */ public GcWonderRecord[] WonderCreatureRecords;
        [NMS(Index = 142)]
        /* 0x69518 */ public GcInventoryContainer Chest10Inventory;
        [NMS(Index = 124)]
        /* 0x69670 */ public GcInventoryContainer Chest1Inventory;
        [NMS(Index = 126)]
        /* 0x697C8 */ public GcInventoryContainer Chest2Inventory;
        [NMS(Index = 128)]
        /* 0x69920 */ public GcInventoryContainer Chest3Inventory;
        [NMS(Index = 130)]
        /* 0x69A78 */ public GcInventoryContainer Chest4Inventory;
        [NMS(Index = 132)]
        /* 0x69BD0 */ public GcInventoryContainer Chest5Inventory;
        [NMS(Index = 134)]
        /* 0x69D28 */ public GcInventoryContainer Chest6Inventory;
        [NMS(Index = 136)]
        /* 0x69E80 */ public GcInventoryContainer Chest7Inventory;
        [NMS(Index = 138)]
        /* 0x69FD8 */ public GcInventoryContainer Chest8Inventory;
        [NMS(Index = 140)]
        /* 0x6A130 */ public GcInventoryContainer Chest9Inventory;
        [NMS(Index = 146)]
        /* 0x6A288 */ public GcInventoryContainer ChestMagic2Inventory;
        [NMS(Index = 144)]
        /* 0x6A3E0 */ public GcInventoryContainer ChestMagicInventory;
        [NMS(Index = 148)]
        /* 0x6A538 */ public GcInventoryContainer CookingIngredientsInventory;
        [NMS(Index = 106)]
        /* 0x6A690 */ public GcInventoryContainer FreighterInventory;
        [NMS(Index = 108)]
        /* 0x6A7E8 */ public GcInventoryContainer FreighterInventory_Cargo;
        [NMS(Index = 107)]
        /* 0x6A940 */ public GcInventoryContainer FreighterInventory_TechOnly;
        [NMS(Index = 18)]
        /* 0x6AA98 */ public GcInventoryContainer GraveInventory;
        [NMS(Index = 6)]
        /* 0x6ABF0 */ public GcInventoryContainer Inventory;
        [NMS(Index = 8)]
        /* 0x6AD48 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 7)]
        /* 0x6AEA0 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 150)]
        /* 0x6AFF8 */ public GcInventoryContainer RocketLockerInventory;
        [NMS(Index = 9)]
        /* 0x6B150 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 10)]
        /* 0x6B2A8 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 218, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x6B400 */ public GcWonderRecord[] WonderTreasureRecords;
        [NMS(Index = 220, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x6B538 */ public GcWonderRecord[] WonderCustomRecords;
        [NMS(Index = 174, Size = 0x3)]
        /* 0x6B658 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Index = 62, Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x6B760 */ public GcInteractionBuffer[] StoredInteractions;
        [NMS(Index = 214, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x6B868 */ public GcWonderRecord[] WonderPlanetRecords;
        [NMS(Index = 219, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x6B970 */ public GcWonderRecord[] WonderWeirdBasePartRecords;
        [NMS(Index = 86, Size = 0x10)]
        /* 0x6BA78 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 216, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x6BB78 */ public GcWonderRecord[] WonderFloraRecords;
        [NMS(Index = 217, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x6BC38 */ public GcWonderRecord[] WonderMineralRecords;
        [NMS(Index = 211, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x6BCF8 */ public GcStoryPageSeenDataArray[] SeenStories;
        [NMS(Index = 103)]
        /* 0x6BD88 */ public GcResourceElement CurrentFreighter;
        [NMS(Index = 151)]
        /* 0x6BDD0 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Index = 27)]
        /* 0x6BE18 */ public GcResourceElement CurrentShip;
        [NMS(Index = 222, Size = 0x4, EnumType = typeof(GcSynchronisedBufferType.SyncBufferTypeEnum))]
        /* 0x6BE60 */ public GcSyncBufferSaveDataArray[] SyncBuffersData;
        [NMS(Index = 28)]
        /* 0x6BEA0 */ public GcExactResource CurrentWeapon;
        [NMS(Index = 164)]
        /* 0x6BEC0 */ public GcPortalSaveData VisitedPortal;
        [NMS(Index = 141)]
        /* 0x6BEE0 */ public GcInventoryLayout Chest10Layout;
        [NMS(Index = 123)]
        /* 0x6BEF8 */ public GcInventoryLayout Chest1Layout;
        [NMS(Index = 125)]
        /* 0x6BF10 */ public GcInventoryLayout Chest2Layout;
        [NMS(Index = 127)]
        /* 0x6BF28 */ public GcInventoryLayout Chest3Layout;
        [NMS(Index = 129)]
        /* 0x6BF40 */ public GcInventoryLayout Chest4Layout;
        [NMS(Index = 131)]
        /* 0x6BF58 */ public GcInventoryLayout Chest5Layout;
        [NMS(Index = 133)]
        /* 0x6BF70 */ public GcInventoryLayout Chest6Layout;
        [NMS(Index = 135)]
        /* 0x6BF88 */ public GcInventoryLayout Chest7Layout;
        [NMS(Index = 137)]
        /* 0x6BFA0 */ public GcInventoryLayout Chest8Layout;
        [NMS(Index = 139)]
        /* 0x6BFB8 */ public GcInventoryLayout Chest9Layout;
        [NMS(Index = 145)]
        /* 0x6BFD0 */ public GcInventoryLayout ChestMagic2Layout;
        [NMS(Index = 143)]
        /* 0x6BFE8 */ public GcInventoryLayout ChestMagicLayout;
        [NMS(Index = 147)]
        /* 0x6C000 */ public GcInventoryLayout CookingIngredientsLayout;
        [NMS(Index = 105)]
        /* 0x6C018 */ public GcInventoryLayout FreighterCargoLayout;
        [NMS(Index = 104)]
        /* 0x6C030 */ public GcInventoryLayout FreighterLayout;
        [NMS(Index = 149)]
        /* 0x6C048 */ public GcInventoryLayout RocketLockerLayout;
        [NMS(Index = 25)]
        /* 0x6C060 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 26)]
        /* 0x6C078 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 201)]
        /* 0x6C090 */ public NMSString0x10 BannerTitleId;
        [NMS(Index = 118)]
        /* 0x6C0A0 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Index = 102)]
        /* 0x6C0B0 */ public GcSeed CurrentFreighterHomeSystemSeed;
        [NMS(Index = 37)]
        /* 0x6C0C0 */ public NMSString0x10 CurrentMissionID;
        [NMS(Index = 180)]
        /* 0x6C0D0 */ public List<ulong> ExpeditionSeedsSelectedToday;
        [NMS(Index = 179)]
        /* 0x6C0E0 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        [NMS(Index = 178)]
        /* 0x6C0F0 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        [NMS(Index = 177)]
        /* 0x6C100 */ public GcSeed FleetSeed;
        [NMS(Index = 176)]
        /* 0x6C110 */ public NMSString0x10 FreighterEngineEffect;
        [NMS(Index = 225)]
        /* 0x6C120 */ public List<GcGalaxyWaypoint> GalaxyWaypoints;
        [NMS(Index = 74)]
        /* 0x6C130 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Index = 175)]
        /* 0x6C140 */ public NMSString0x10 JetpackEffect;
        [NMS(Index = 30)]
        /* 0x6C150 */ public List<NMSString0x10> KnownProducts;
        [NMS(Index = 32)]
        /* 0x6C160 */ public List<NMSString0x20A> KnownRefinerRecipes;
        [NMS(Index = 31)]
        /* 0x6C170 */ public List<NMSString0x10> KnownSpecials;
        [NMS(Index = 29)]
        /* 0x6C180 */ public List<NMSString0x10> KnownTech;
        [NMS(Index = 34)]
        /* 0x6C190 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        [NMS(Index = 33)]
        /* 0x6C1A0 */ public List<GcWordKnowledge> KnownWords;
        [NMS(Index = 163)]
        /* 0x6C1B0 */ public List<GcPortalSaveData> LastPortal;
        [NMS(Index = 63)]
        /* 0x6C1C0 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        [NMS(Index = 55)]
        /* 0x6C1D0 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Index = 35)]
        /* 0x6C1E0 */ public List<GcPlayerMissionProgress> MissionProgress;
        [NMS(Index = 42)]
        /* 0x6C1F0 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Index = 56)]
        /* 0x6C200 */ public List<GcScanEventSave> NewMPMarkerStack;
        [NMS(Index = 121)]
        /* 0x6C210 */ public List<GcPersistentBase> PersistentPlayerBases;
        [NMS(Index = 64)]
        /* 0x6C220 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        [NMS(Index = 39)]
        /* 0x6C230 */ public NMSString0x10 PreviousMissionID;
        [NMS(Index = 207)]
        /* 0x6C240 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Index = 205)]
        /* 0x6C250 */ public List<NMSString0x10> RedeemedSeasonRewards;
        [NMS(Index = 206)]
        /* 0x6C260 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Index = 224)]
        /* 0x6C270 */ public List<GcMaintenanceContainer> RefinerBufferData;
        [NMS(Index = 223)]
        /* 0x6C280 */ public List<GcMaintenanceSaveKey> RefinerBufferKeys;
        [NMS(Index = 186)]
        /* 0x6C290 */ public List<GcRepairTechData> RepairTechBuffer;
        [NMS(Index = 73)]
        /* 0x6C2A0 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        [NMS(Index = 117)]
        /* 0x6C2B0 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        [NMS(Index = 60)]
        /* 0x6C2C0 */ public List<GcPlayerStatsGroup> Stats;
        [NMS(Index = 57)]
        /* 0x6C2D0 */ public List<Vector3f> SurveyedEventPositions;
        [NMS(Index = 61)]
        /* 0x6C2E0 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Index = 122)]
        /* 0x6C2F0 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Index = 162)]
        /* 0x6C300 */ public List<GcTradingSupplyData> TradingSupplyData;
        [NMS(Index = 84)]
        /* 0x6C310 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Index = 77)]
        /* 0x6C320 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        [NMS(Index = 65)]
        /* 0x6C330 */ public List<ulong> VisitedSystems;
        [NMS(Index = 11)]
        /* 0x6C340 */ public List<GcInWorldUIScreenData> WristScreenData;
        [NMS(Index = 90)]
        /* 0x6C350 */ public ulong ActiveSpaceBattleUA;
        [NMS(Index = 38)]
        /* 0x6C358 */ public ulong CurrentMissionSeed;
        [NMS(Index = 109)]
        /* 0x6C360 */ public ulong FreighterLastSpawnTime;
        [NMS(Index = 100)]
        /* 0x6C368 */ public ulong HazardTimeAlive;
        [NMS(Index = 59)]
        /* 0x6C370 */ public ulong LastCheckedForStatResetsTime;
        [NMS(Index = 181)]
        /* 0x6C378 */ public ulong LastKnownDay;
        [NMS(Index = 189)]
        /* 0x6C380 */ public ulong LastUABeforePortalWarp;
        [NMS(Index = 94)]
        /* 0x6C388 */ public ulong MiniStationUA;
        [NMS(Index = 183)]
        /* 0x6C390 */ public ulong MultiplayerLobbyID;
        [NMS(Index = 187)]
        /* 0x6C398 */ public ulong MultiplayerPrivileges;
        [NMS(Index = 40)]
        /* 0x6C3A0 */ public ulong PreviousMissionSeed;
        [NMS(Index = 190)]
        /* 0x6C3A8 */ public ulong StoryPortalSeed;
        [NMS(Index = 182)]
        /* 0x6C3B0 */ public ulong SunTimer;
        [NMS(Index = 54)]
        /* 0x6C3B8 */ public ulong TimeAlive;
        [NMS(Index = 92)]
        /* 0x6C3C0 */ public ulong TimeLastMiniStation;
        [NMS(Index = 88)]
        /* 0x6C3C8 */ public ulong TimeLastSpaceBattle;
        [NMS(Index = 5)]
        /* 0x6C3D0 */ public ulong TimeStamp;
        [NMS(Index = 72, Size = 0x8C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x6C3D8 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        [NMS(Index = 221, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x6DE18 */ public GcWonderRecordCustomData[] WonderCustomRecordsExtraData;
        [NMS(Index = 79, Size = 0xB)]
        /* 0x6E148 */ public GcUniverseAddressData[] CompletedAtlasAddresses;
        [NMS(Index = 76, Size = 0xB)]
        /* 0x6E250 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        [NMS(Index = 75, Size = 0xA)]
        /* 0x6E358 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Index = 4)]
        /* 0x6E448 */ public GcDifficultyStateData DifficultyState;
        [NMS(Index = 110)]
        /* 0x6E4AC */ public GcUniverseAddressData FreighterUniverseAddress;
        [NMS(Index = 96)]
        /* 0x6E4C4 */ public GcUniverseAddressData GameStartAddress1;
        [NMS(Index = 97)]
        /* 0x6E4DC */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Index = 21)]
        /* 0x6E4F4 */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Index = 66, Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x6E50C */ public float[] Hazard;
        [NMS(Index = 184)]
        /* 0x6E524 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Index = 194)]
        /* 0x6E53C */ public GcUniverseAddressData NexusUniverseAddress;
        [NMS(Index = 1)]
        /* 0x6E554 */ public GcUniverseAddressData PreviousUniverseAddress;
        [NMS(Index = 0)]
        /* 0x6E56C */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 13)]
        /* 0x6E584 */ public int ActiveMultioolIndex;
        [NMS(Index = 91)]
        /* 0x6E588 */ public int ActiveSpaceBattleLevel;
        [NMS(Index = 200)]
        /* 0x6E58C */ public int BannerBackgroundColour;
        [NMS(Index = 198)]
        /* 0x6E590 */ public int BannerIcon;
        [NMS(Index = 199)]
        /* 0x6E594 */ public int BannerMainColour;
        [NMS(Index = 67)]
        /* 0x6E598 */ public int BoltAmmo;
        [NMS(Index = 50)]
        /* 0x6E59C */ public int Energy;
        [NMS(Index = 46)]
        /* 0x6E5A0 */ public int Health;
        [NMS(Index = 2)]
        /* 0x6E5A4 */ public int HomeRealityIteration;
        [NMS(Index = 165)]
        /* 0x6E5A8 */ public int KnownPortalRunes;
        [NMS(Index = 70)]
        /* 0x6E5AC */ public int LaserAmmo;
        [NMS(Index = 41)]
        /* 0x6E5B0 */ public int MissionVersion;
        [NMS(Index = 52)]
        /* 0x6E5B4 */ public int Nanites;
        [NMS(Index = 58)]
        /* 0x6E5B8 */ public int NextSurveyedEventPositionIndex;
        [NMS(Index = 36)]
        /* 0x6E5BC */ public int PostMissionIndex;
        [NMS(Index = 87)]
        /* 0x6E5C0 */ public int PrimaryPlanet;
        [NMS(Index = 155)]
        /* 0x6E5C4 */ public int PrimaryShip;
        [NMS(Index = 153)]
        /* 0x6E5C8 */ public int PrimaryVehicle;
        [NMS(Index = 81)]
        /* 0x6E5CC */ public int ProcTechIndex;
        [NMS(Index = 80)]
        /* 0x6E5D0 */ public int ProgressionLevel;
        [NMS(Index = 69)]
        /* 0x6E5D4 */ public int PulseAmmo;
        [NMS(Index = 68)]
        /* 0x6E5D8 */ public int ScatterAmmo;
        [NMS(Index = 209)]
        /* 0x6E5DC */ public int SettlementStateRingBufferIndexV2;
        [NMS(Index = 48)]
        /* 0x6E5E0 */ public int Shield;
        [NMS(Index = 47)]
        /* 0x6E5E4 */ public int ShipHealth;
        [NMS(Index = 49)]
        /* 0x6E5E8 */ public int ShipShield;
        [NMS(Index = 53)]
        /* 0x6E5EC */ public int Specials;
        [NMS(Index = 170)]
        /* 0x6E5F0 */ public GcPlayerWeapons StartingPrimaryWeapon;
        [NMS(Index = 213)]
        /* 0x6E5F4 */ public int StartingSeasonNumber;
        [NMS(Index = 171)]
        /* 0x6E5F8 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Index = 202)]
        /* 0x6E5FC */ public int TelemetryUploadVersion;
        [NMS(Index = 161)]
        /* 0x6E600 */ public int TradingSupplyDataIndex;
        [NMS(Index = 51)]
        /* 0x6E604 */ public int Units;
        [NMS(Index = 203)]
        /* 0x6E608 */ public float VRCameraOffset;
        [NMS(Index = 93)]
        /* 0x6E60C */ public int WarpsLastMiniStation;
        [NMS(Index = 89)]
        /* 0x6E610 */ public int WarpsLastSpaceBattle;
        [NMS(Index = 191)]
        /* 0x6E614 */ public ushort ShopNumber;
        [NMS(Index = 192)]
        /* 0x6E616 */ public ushort ShopTier;
        [NMS(Index = 3)]
        /* 0x6E618 */ public NMSString0x80 SaveSummary;
        [NMS(Index = 158)]
        /* 0x6E698 */ public NMSString0x20 PlayerFreighterName;
        [NMS(Index = 17, Size = 0x12)]
        /* 0x6E6B8 */ public bool[] UnlockedPetSlots;
        [NMS(Index = 98, Size = 0x10)]
        /* 0x6E6CA */ public bool[] GalacticMapRequests;
        [NMS(Index = 173, Size = 0xC)]
        /* 0x6E6DA */ public bool[] ShipUsesLegacyColours;
        [NMS(Index = 115, Size = 0x4)]
        /* 0x6E6E6 */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Index = 212)]
        /* 0x6E6EA */ public bool BuildersKnown;
        [NMS(Index = 78)]
        /* 0x6E6EB */ public bool FirstAtlasStationDiscovered;
        [NMS(Index = 111)]
        /* 0x6E6EC */ public bool FreighterDismissed;
        [NMS(Index = 193)]
        /* 0x6E6ED */ public bool HasAccessToNexus;
        [NMS(Index = 82)]
        /* 0x6E6EE */ public bool IsNew;
        [NMS(Index = 156)]
        /* 0x6E6EF */ public bool MultiShipEnabled;
        [NMS(Index = 210)]
        /* 0x6E6F0 */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Index = 166)]
        /* 0x6E6F1 */ public bool OnOtherSideOfPortal;
        [NMS(Index = 204)]
        /* 0x6E6F2 */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Index = 101)]
        /* 0x6E6F3 */ public bool RevealBlackHoles;
        [NMS(Index = 160)]
        /* 0x6E6F4 */ public bool ShipNeedsTerrainPositioning;
        [NMS(Index = 20)]
        /* 0x6E6F5 */ public bool SpaceGrave;
        [NMS(Index = 19)]
        /* 0x6E6F6 */ public bool SpawnGrave;
        [NMS(Index = 83)]
        /* 0x6E6F7 */ public bool UseSmallerBlackholeJumps;
        [NMS(Index = 157)]
        /* 0x6E6F8 */ public bool VehicleAIControlEnabled;
    }
}
