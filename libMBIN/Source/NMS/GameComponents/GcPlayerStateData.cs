using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1DAA3903B709D29F, NameHash = 0x5E49C3E9)]
    public class GcPlayerStateData : NMSTemplate
    {
        [NMS(Index = 119)]
        /* 0x00000 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Index = 213, Size = 0x64)]
        /* 0x3C780 */ public GcSettlementState[] SettlementStatesV2;
        [NMS(Index = 159, Size = 0xC)]
        /* 0x5B540 */ public GcPlayerOwnershipData[] ShipOwnership;
        [NMS(Index = 156, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x5EE40 */ public GcPlayerOwnershipData[] VehicleOwnership;
        [NMS(Index = 12, Size = 0x6)]
        /* 0x60F80 */ public GcMultitoolData[] Multitools;
        [NMS(Index = 120, Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x61E80 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Index = 85, Size = 0x10)]
        /* 0x62100 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 190)]
        /* 0x62200 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        [NMS(Index = 172)]
        /* 0x622D0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        [NMS(Index = 158)]
        /* 0x62350 */ public GcSkiffSaveData SkiffData;
        [NMS(Index = 43)]
        /* 0x62380 */ public GcInteractionData HoloExplorerInteraction;
        [NMS(Index = 45)]
        /* 0x623A0 */ public GcInteractionData HoloNooneInteraction;
        [NMS(Index = 44)]
        /* 0x623C0 */ public GcInteractionData HoloScepticInteraction;
        [NMS(Index = 95)]
        /* 0x623E0 */ public Vector4f AnomalyPositionOverride;
        [NMS(Index = 99)]
        /* 0x623F0 */ public Vector4f FirstShipPosition;
        [NMS(Index = 71)]
        /* 0x62400 */ public Vector4f FirstSpawnPosition;
        [NMS(Index = 112)]
        /* 0x62410 */ public Vector3f FreighterMatrixAt;
        [NMS(Index = 114)]
        /* 0x62420 */ public Vector3f FreighterMatrixPos;
        [NMS(Index = 113)]
        /* 0x62430 */ public Vector3f FreighterMatrixUp;
        [NMS(Index = 23)]
        /* 0x62440 */ public Vector4f GraveMatrixLookAt;
        [NMS(Index = 24)]
        /* 0x62450 */ public Vector4f GraveMatrixUp;
        [NMS(Index = 22)]
        /* 0x62460 */ public Vector4f GravePosition;
        [NMS(Index = 200)]
        /* 0x62470 */ public Vector3f NexusMatrixAt;
        [NMS(Index = 202)]
        /* 0x62480 */ public Vector3f NexusMatrixPos;
        [NMS(Index = 201)]
        /* 0x62490 */ public Vector3f NexusMatrixUp;
        [NMS(Index = 173)]
        /* 0x624A0 */ public Vector4f PortalMarkerPosition_Local;
        [NMS(Index = 174)]
        /* 0x624B0 */ public Vector4f PortalMarkerPosition_Offset;
        [NMS(Index = 164)]
        /* 0x624C0 */ public Vector4f StartGameShipPosition;
        [NMS(Index = 15, Size = 0x12)]
        /* 0x624D0 */ public GcPetData[] Eggs;
        [NMS(Index = 14, Size = 0x12)]
        /* 0x64960 */ public GcPetData[] Pets;
        [NMS(Index = 231)]
        /* 0x66DF0 */ public GcFishingRecord FishingRecord;
        [NMS(Index = 16, Size = 0x12)]
        /* 0x685F0 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 177, Size = 0x19, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x69BE0 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Index = 193, Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x6A608 */ public GcHotActionsSaveData[] HotActions;
        [NMS(Index = 116, Size = 0x4)]
        /* 0x6A9C8 */ public GcSquadronPilotData[] SquadronPilots;
        [NMS(Index = 220, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x6AC48 */ public GcWonderRecord[] WonderCreatureRecords;
        [NMS(Index = 142)]
        /* 0x6ADB0 */ public GcInventoryContainer Chest10Inventory;
        [NMS(Index = 124)]
        /* 0x6AF08 */ public GcInventoryContainer Chest1Inventory;
        [NMS(Index = 126)]
        /* 0x6B060 */ public GcInventoryContainer Chest2Inventory;
        [NMS(Index = 128)]
        /* 0x6B1B8 */ public GcInventoryContainer Chest3Inventory;
        [NMS(Index = 130)]
        /* 0x6B310 */ public GcInventoryContainer Chest4Inventory;
        [NMS(Index = 132)]
        /* 0x6B468 */ public GcInventoryContainer Chest5Inventory;
        [NMS(Index = 134)]
        /* 0x6B5C0 */ public GcInventoryContainer Chest6Inventory;
        [NMS(Index = 136)]
        /* 0x6B718 */ public GcInventoryContainer Chest7Inventory;
        [NMS(Index = 138)]
        /* 0x6B870 */ public GcInventoryContainer Chest8Inventory;
        [NMS(Index = 140)]
        /* 0x6B9C8 */ public GcInventoryContainer Chest9Inventory;
        [NMS(Index = 146)]
        /* 0x6BB20 */ public GcInventoryContainer ChestMagic2Inventory;
        [NMS(Index = 144)]
        /* 0x6BC78 */ public GcInventoryContainer ChestMagicInventory;
        [NMS(Index = 148)]
        /* 0x6BDD0 */ public GcInventoryContainer CookingIngredientsInventory;
        [NMS(Index = 154)]
        /* 0x6BF28 */ public GcInventoryContainer FishBaitBoxInventory;
        [NMS(Index = 152)]
        /* 0x6C080 */ public GcInventoryContainer FishPlatformInventory;
        [NMS(Index = 106)]
        /* 0x6C1D8 */ public GcInventoryContainer FreighterInventory;
        [NMS(Index = 108)]
        /* 0x6C330 */ public GcInventoryContainer FreighterInventory_Cargo;
        [NMS(Index = 107)]
        /* 0x6C488 */ public GcInventoryContainer FreighterInventory_TechOnly;
        [NMS(Index = 18)]
        /* 0x6C5E0 */ public GcInventoryContainer GraveInventory;
        [NMS(Index = 6)]
        /* 0x6C738 */ public GcInventoryContainer Inventory;
        [NMS(Index = 8)]
        /* 0x6C890 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 7)]
        /* 0x6C9E8 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 150)]
        /* 0x6CB40 */ public GcInventoryContainer RocketLockerInventory;
        [NMS(Index = 9)]
        /* 0x6CC98 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 10)]
        /* 0x6CDF0 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 223, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x6CF48 */ public GcWonderRecord[] WonderTreasureRecords;
        [NMS(Index = 225, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x6D080 */ public GcWonderRecord[] WonderCustomRecords;
        [NMS(Index = 179, Size = 0x3)]
        /* 0x6D1A0 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Index = 62, Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x6D2A8 */ public GcInteractionBuffer[] StoredInteractions;
        [NMS(Index = 219, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x6D3B0 */ public GcWonderRecord[] WonderPlanetRecords;
        [NMS(Index = 224, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x6D4B8 */ public GcWonderRecord[] WonderWeirdBasePartRecords;
        [NMS(Index = 86, Size = 0x10)]
        /* 0x6D5C0 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 221, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x6D6C0 */ public GcWonderRecord[] WonderFloraRecords;
        [NMS(Index = 222, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x6D780 */ public GcWonderRecord[] WonderMineralRecords;
        [NMS(Index = 216, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x6D840 */ public GcStoryPageSeenDataArray[] SeenStories;
        [NMS(Index = 103)]
        /* 0x6D8D0 */ public GcResourceElement CurrentFreighter;
        [NMS(Index = 155)]
        /* 0x6D918 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Index = 27)]
        /* 0x6D960 */ public GcResourceElement CurrentShip;
        [NMS(Index = 227, Size = 0x4, EnumType = typeof(GcSynchronisedBufferType.SyncBufferTypeEnum))]
        /* 0x6D9A8 */ public GcSyncBufferSaveDataArray[] SyncBuffersData;
        [NMS(Index = 28)]
        /* 0x6D9E8 */ public GcExactResource CurrentWeapon;
        [NMS(Index = 169)]
        /* 0x6DA08 */ public GcPortalSaveData VisitedPortal;
        [NMS(Index = 141)]
        /* 0x6DA28 */ public GcInventoryLayout Chest10Layout;
        [NMS(Index = 123)]
        /* 0x6DA40 */ public GcInventoryLayout Chest1Layout;
        [NMS(Index = 125)]
        /* 0x6DA58 */ public GcInventoryLayout Chest2Layout;
        [NMS(Index = 127)]
        /* 0x6DA70 */ public GcInventoryLayout Chest3Layout;
        [NMS(Index = 129)]
        /* 0x6DA88 */ public GcInventoryLayout Chest4Layout;
        [NMS(Index = 131)]
        /* 0x6DAA0 */ public GcInventoryLayout Chest5Layout;
        [NMS(Index = 133)]
        /* 0x6DAB8 */ public GcInventoryLayout Chest6Layout;
        [NMS(Index = 135)]
        /* 0x6DAD0 */ public GcInventoryLayout Chest7Layout;
        [NMS(Index = 137)]
        /* 0x6DAE8 */ public GcInventoryLayout Chest8Layout;
        [NMS(Index = 139)]
        /* 0x6DB00 */ public GcInventoryLayout Chest9Layout;
        [NMS(Index = 145)]
        /* 0x6DB18 */ public GcInventoryLayout ChestMagic2Layout;
        [NMS(Index = 143)]
        /* 0x6DB30 */ public GcInventoryLayout ChestMagicLayout;
        [NMS(Index = 147)]
        /* 0x6DB48 */ public GcInventoryLayout CookingIngredientsLayout;
        [NMS(Index = 153)]
        /* 0x6DB60 */ public GcInventoryLayout FishBaitBoxLayout;
        [NMS(Index = 151)]
        /* 0x6DB78 */ public GcInventoryLayout FishPlatformLayout;
        [NMS(Index = 105)]
        /* 0x6DB90 */ public GcInventoryLayout FreighterCargoLayout;
        [NMS(Index = 104)]
        /* 0x6DBA8 */ public GcInventoryLayout FreighterLayout;
        [NMS(Index = 149)]
        /* 0x6DBC0 */ public GcInventoryLayout RocketLockerLayout;
        [NMS(Index = 25)]
        /* 0x6DBD8 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 26)]
        /* 0x6DBF0 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 206)]
        /* 0x6DC08 */ public NMSString0x10 BannerTitleId;
        [NMS(Index = 118)]
        /* 0x6DC18 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Index = 102)]
        /* 0x6DC28 */ public GcSeed CurrentFreighterHomeSystemSeed;
        [NMS(Index = 37)]
        /* 0x6DC38 */ public NMSString0x10 CurrentMissionID;
        [NMS(Index = 185)]
        /* 0x6DC48 */ public List<ulong> ExpeditionSeedsSelectedToday;
        [NMS(Index = 184)]
        /* 0x6DC58 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        [NMS(Index = 183)]
        /* 0x6DC68 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        [NMS(Index = 182)]
        /* 0x6DC78 */ public GcSeed FleetSeed;
        [NMS(Index = 181)]
        /* 0x6DC88 */ public NMSString0x10 FreighterEngineEffect;
        [NMS(Index = 230)]
        /* 0x6DC98 */ public List<GcGalaxyWaypoint> GalaxyWaypoints;
        [NMS(Index = 74)]
        /* 0x6DCA8 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Index = 180)]
        /* 0x6DCB8 */ public NMSString0x10 JetpackEffect;
        [NMS(Index = 30)]
        /* 0x6DCC8 */ public List<NMSString0x10> KnownProducts;
        [NMS(Index = 32)]
        /* 0x6DCD8 */ public List<NMSString0x20A> KnownRefinerRecipes;
        [NMS(Index = 31)]
        /* 0x6DCE8 */ public List<NMSString0x10> KnownSpecials;
        [NMS(Index = 29)]
        /* 0x6DCF8 */ public List<NMSString0x10> KnownTech;
        [NMS(Index = 34)]
        /* 0x6DD08 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        [NMS(Index = 33)]
        /* 0x6DD18 */ public List<GcWordKnowledge> KnownWords;
        [NMS(Index = 168)]
        /* 0x6DD28 */ public List<GcPortalSaveData> LastPortal;
        [NMS(Index = 63)]
        /* 0x6DD38 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        [NMS(Index = 55)]
        /* 0x6DD48 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Index = 35)]
        /* 0x6DD58 */ public List<GcPlayerMissionProgress> MissionProgress;
        [NMS(Index = 42)]
        /* 0x6DD68 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Index = 56)]
        /* 0x6DD78 */ public List<GcScanEventSave> NewMPMarkerStack;
        [NMS(Index = 121)]
        /* 0x6DD88 */ public List<GcPersistentBase> PersistentPlayerBases;
        [NMS(Index = 64)]
        /* 0x6DD98 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        [NMS(Index = 39)]
        /* 0x6DDA8 */ public NMSString0x10 PreviousMissionID;
        [NMS(Index = 212)]
        /* 0x6DDB8 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Index = 210)]
        /* 0x6DDC8 */ public List<NMSString0x10> RedeemedSeasonRewards;
        [NMS(Index = 211)]
        /* 0x6DDD8 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Index = 229)]
        /* 0x6DDE8 */ public List<GcMaintenanceContainer> RefinerBufferData;
        [NMS(Index = 228)]
        /* 0x6DDF8 */ public List<GcMaintenanceSaveKey> RefinerBufferKeys;
        [NMS(Index = 191)]
        /* 0x6DE08 */ public List<GcRepairTechData> RepairTechBuffer;
        [NMS(Index = 73)]
        /* 0x6DE18 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        [NMS(Index = 117)]
        /* 0x6DE28 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        [NMS(Index = 60)]
        /* 0x6DE38 */ public List<GcPlayerStatsGroup> Stats;
        [NMS(Index = 57)]
        /* 0x6DE48 */ public List<Vector3f> SurveyedEventPositions;
        [NMS(Index = 61)]
        /* 0x6DE58 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Index = 122)]
        /* 0x6DE68 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Index = 167)]
        /* 0x6DE78 */ public List<GcTradingSupplyData> TradingSupplyData;
        [NMS(Index = 84)]
        /* 0x6DE88 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Index = 77)]
        /* 0x6DE98 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        [NMS(Index = 65)]
        /* 0x6DEA8 */ public List<ulong> VisitedSystems;
        [NMS(Index = 11)]
        /* 0x6DEB8 */ public List<GcInWorldUIScreenData> WristScreenData;
        [NMS(Index = 90)]
        /* 0x6DEC8 */ public ulong ActiveSpaceBattleUA;
        [NMS(Index = 38)]
        /* 0x6DED0 */ public ulong CurrentMissionSeed;
        [NMS(Index = 109)]
        /* 0x6DED8 */ public ulong FreighterLastSpawnTime;
        [NMS(Index = 100)]
        /* 0x6DEE0 */ public ulong HazardTimeAlive;
        [NMS(Index = 59)]
        /* 0x6DEE8 */ public ulong LastCheckedForStatResetsTime;
        [NMS(Index = 186)]
        /* 0x6DEF0 */ public ulong LastKnownDay;
        [NMS(Index = 194)]
        /* 0x6DEF8 */ public ulong LastUABeforePortalWarp;
        [NMS(Index = 94)]
        /* 0x6DF00 */ public ulong MiniStationUA;
        [NMS(Index = 188)]
        /* 0x6DF08 */ public ulong MultiplayerLobbyID;
        [NMS(Index = 192)]
        /* 0x6DF10 */ public ulong MultiplayerPrivileges;
        [NMS(Index = 40)]
        /* 0x6DF18 */ public ulong PreviousMissionSeed;
        [NMS(Index = 195)]
        /* 0x6DF20 */ public ulong StoryPortalSeed;
        [NMS(Index = 187)]
        /* 0x6DF28 */ public ulong SunTimer;
        [NMS(Index = 54)]
        /* 0x6DF30 */ public ulong TimeAlive;
        [NMS(Index = 92)]
        /* 0x6DF38 */ public ulong TimeLastMiniStation;
        [NMS(Index = 88)]
        /* 0x6DF40 */ public ulong TimeLastSpaceBattle;
        [NMS(Index = 5)]
        /* 0x6DF48 */ public ulong TimeStamp;
        [NMS(Index = 72, Size = 0x8E, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x6DF50 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        [NMS(Index = 226, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x6F9F0 */ public GcWonderRecordCustomData[] WonderCustomRecordsExtraData;
        [NMS(Index = 79, Size = 0xB)]
        /* 0x6FD20 */ public GcUniverseAddressData[] CompletedAtlasAddresses;
        [NMS(Index = 76, Size = 0xB)]
        /* 0x6FE28 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        [NMS(Index = 75, Size = 0xA)]
        /* 0x6FF30 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Index = 4)]
        /* 0x70020 */ public GcDifficultyStateData DifficultyState;
        [NMS(Index = 110)]
        /* 0x70088 */ public GcUniverseAddressData FreighterUniverseAddress;
        [NMS(Index = 96)]
        /* 0x700A0 */ public GcUniverseAddressData GameStartAddress1;
        [NMS(Index = 97)]
        /* 0x700B8 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Index = 21)]
        /* 0x700D0 */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Index = 66, Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x700E8 */ public float[] Hazard;
        [NMS(Index = 189)]
        /* 0x70100 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Index = 199)]
        /* 0x70118 */ public GcUniverseAddressData NexusUniverseAddress;
        [NMS(Index = 1)]
        /* 0x70130 */ public GcUniverseAddressData PreviousUniverseAddress;
        [NMS(Index = 0)]
        /* 0x70148 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 13)]
        /* 0x70160 */ public int ActiveMultioolIndex;
        [NMS(Index = 91)]
        /* 0x70164 */ public int ActiveSpaceBattleLevel;
        [NMS(Index = 205)]
        /* 0x70168 */ public int BannerBackgroundColour;
        [NMS(Index = 203)]
        /* 0x7016C */ public int BannerIcon;
        [NMS(Index = 204)]
        /* 0x70170 */ public int BannerMainColour;
        [NMS(Index = 67)]
        /* 0x70174 */ public int BoltAmmo;
        [NMS(Index = 50)]
        /* 0x70178 */ public int Energy;
        [NMS(Index = 46)]
        /* 0x7017C */ public int Health;
        [NMS(Index = 2)]
        /* 0x70180 */ public int HomeRealityIteration;
        [NMS(Index = 170)]
        /* 0x70184 */ public int KnownPortalRunes;
        [NMS(Index = 70)]
        /* 0x70188 */ public int LaserAmmo;
        [NMS(Index = 41)]
        /* 0x7018C */ public int MissionVersion;
        [NMS(Index = 52)]
        /* 0x70190 */ public int Nanites;
        [NMS(Index = 58)]
        /* 0x70194 */ public int NextSurveyedEventPositionIndex;
        [NMS(Index = 36)]
        /* 0x70198 */ public int PostMissionIndex;
        [NMS(Index = 87)]
        /* 0x7019C */ public int PrimaryPlanet;
        [NMS(Index = 160)]
        /* 0x701A0 */ public int PrimaryShip;
        [NMS(Index = 157)]
        /* 0x701A4 */ public int PrimaryVehicle;
        [NMS(Index = 81)]
        /* 0x701A8 */ public int ProcTechIndex;
        [NMS(Index = 80)]
        /* 0x701AC */ public int ProgressionLevel;
        [NMS(Index = 69)]
        /* 0x701B0 */ public int PulseAmmo;
        [NMS(Index = 68)]
        /* 0x701B4 */ public int ScatterAmmo;
        [NMS(Index = 214)]
        /* 0x701B8 */ public int SettlementStateRingBufferIndexV2;
        [NMS(Index = 48)]
        /* 0x701BC */ public int Shield;
        [NMS(Index = 47)]
        /* 0x701C0 */ public int ShipHealth;
        [NMS(Index = 49)]
        /* 0x701C4 */ public int ShipShield;
        [NMS(Index = 53)]
        /* 0x701C8 */ public int Specials;
        [NMS(Index = 175)]
        /* 0x701CC */ public GcPlayerWeapons StartingPrimaryWeapon;
        [NMS(Index = 218)]
        /* 0x701D0 */ public int StartingSeasonNumber;
        [NMS(Index = 176)]
        /* 0x701D4 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Index = 207)]
        /* 0x701D8 */ public int TelemetryUploadVersion;
        [NMS(Index = 166)]
        /* 0x701DC */ public int TradingSupplyDataIndex;
        [NMS(Index = 51)]
        /* 0x701E0 */ public int Units;
        [NMS(Index = 208)]
        /* 0x701E4 */ public float VRCameraOffset;
        [NMS(Index = 93)]
        /* 0x701E8 */ public int WarpsLastMiniStation;
        [NMS(Index = 89)]
        /* 0x701EC */ public int WarpsLastSpaceBattle;
        [NMS(Index = 196)]
        /* 0x701F0 */ public ushort ShopNumber;
        [NMS(Index = 197)]
        /* 0x701F2 */ public ushort ShopTier;
        [NMS(Index = 3)]
        /* 0x701F4 */ public NMSString0x80 SaveSummary;
        [NMS(Index = 163)]
        /* 0x70274 */ public NMSString0x20 PlayerFreighterName;
        [NMS(Index = 17, Size = 0x12)]
        /* 0x70294 */ public bool[] UnlockedPetSlots;
        [NMS(Index = 98, Size = 0x10)]
        /* 0x702A6 */ public bool[] GalacticMapRequests;
        [NMS(Index = 178, Size = 0xC)]
        /* 0x702B6 */ public bool[] ShipUsesLegacyColours;
        [NMS(Index = 115, Size = 0x4)]
        /* 0x702C2 */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Index = 217)]
        /* 0x702C6 */ public bool BuildersKnown;
        [NMS(Index = 78)]
        /* 0x702C7 */ public bool FirstAtlasStationDiscovered;
        [NMS(Index = 111)]
        /* 0x702C8 */ public bool FreighterDismissed;
        [NMS(Index = 198)]
        /* 0x702C9 */ public bool HasAccessToNexus;
        [NMS(Index = 82)]
        /* 0x702CA */ public bool IsNew;
        [NMS(Index = 161)]
        /* 0x702CB */ public bool MultiShipEnabled;
        [NMS(Index = 215)]
        /* 0x702CC */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Index = 171)]
        /* 0x702CD */ public bool OnOtherSideOfPortal;
        [NMS(Index = 209)]
        /* 0x702CE */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Index = 101)]
        /* 0x702CF */ public bool RevealBlackHoles;
        [NMS(Index = 165)]
        /* 0x702D0 */ public bool ShipNeedsTerrainPositioning;
        [NMS(Index = 20)]
        /* 0x702D1 */ public bool SpaceGrave;
        [NMS(Index = 19)]
        /* 0x702D2 */ public bool SpawnGrave;
        [NMS(Index = 83)]
        /* 0x702D3 */ public bool UseSmallerBlackholeJumps;
        [NMS(Index = 162)]
        /* 0x702D4 */ public bool VehicleAIControlEnabled;
    }
}
