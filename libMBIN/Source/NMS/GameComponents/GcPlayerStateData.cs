using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x166CB9B157BFC0B1, NameHash = 0x5E49C3E9)]
    public class GcPlayerStateData : NMSTemplate
    {
        [NMS(Index = 125)]
        /* 0x00000 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Index = 230, Size = 0x64)]
        /* 0x3C780 */ public GcSettlementState[] SettlementStatesV2;
        [NMS(Index = 170, Size = 0x12)]
        /* 0x5DAC0 */ public GcArchivedShipData[] ArchivedShipOwnership;
        [NMS(Index = 169, Size = 0xC)]
        /* 0x64480 */ public GcPlayerOwnershipData[] ShipOwnership;
        [NMS(Index = 14, Size = 0x12)]
        /* 0x67F00 */ public GcArchivedMultitoolData[] ArchivedMultitools;
        [NMS(Index = 120, Size = 0x8)]
        /* 0x6B080 */ public GcFreighterSaveData[] FreighterFleet;
        [NMS(Index = 166, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x6D880 */ public GcPlayerOwnershipData[] VehicleOwnership;
        [NMS(Index = 12, Size = 0x6)]
        /* 0x6FAA0 */ public GcMultitoolData[] Multitools;
        [NMS(Index = 126, Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x70A00 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Index = 90, Size = 0x10)]
        /* 0x70C80 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 207)]
        /* 0x70D80 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        [NMS(Index = 184)]
        /* 0x70E60 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        [NMS(Index = 168)]
        /* 0x70EF0 */ public GcSkiffSaveData SkiffData;
        [NMS(Index = 45)]
        /* 0x70F20 */ public GcInteractionData HoloExplorerInteraction;
        [NMS(Index = 47)]
        /* 0x70F40 */ public GcInteractionData HoloNooneInteraction;
        [NMS(Index = 46)]
        /* 0x70F60 */ public GcInteractionData HoloScepticInteraction;
        [NMS(Index = 100)]
        /* 0x70F80 */ public Vector4f AnomalyPositionOverride;
        [NMS(Index = 104)]
        /* 0x70F90 */ public Vector4f FirstShipPosition;
        [NMS(Index = 73)]
        /* 0x70FA0 */ public Vector4f FirstSpawnPosition;
        [NMS(Index = 117)]
        /* 0x70FB0 */ public Vector3f FreighterMatrixAt;
        [NMS(Index = 119)]
        /* 0x70FC0 */ public Vector3f FreighterMatrixPos;
        [NMS(Index = 118)]
        /* 0x70FD0 */ public Vector3f FreighterMatrixUp;
        [NMS(Index = 25)]
        /* 0x70FE0 */ public Vector4f GraveMatrixLookAt;
        [NMS(Index = 26)]
        /* 0x70FF0 */ public Vector4f GraveMatrixUp;
        [NMS(Index = 24)]
        /* 0x71000 */ public Vector4f GravePosition;
        [NMS(Index = 217)]
        /* 0x71010 */ public Vector3f NexusMatrixAt;
        [NMS(Index = 219)]
        /* 0x71020 */ public Vector3f NexusMatrixPos;
        [NMS(Index = 218)]
        /* 0x71030 */ public Vector3f NexusMatrixUp;
        [NMS(Index = 185)]
        /* 0x71040 */ public Vector4f PortalMarkerPosition_Local;
        [NMS(Index = 186)]
        /* 0x71050 */ public Vector4f PortalMarkerPosition_Offset;
        [NMS(Index = 176)]
        /* 0x71060 */ public Vector4f StartGameShipPosition;
        [NMS(Index = 15, Size = 0x1E)]
        /* 0x71070 */ public GcPetData[] Pets;
        [NMS(Index = 16, Size = 0x12)]
        /* 0x76980 */ public GcPetData[] Eggs;
        [NMS(Index = 17, Size = 0x1E)]
        /* 0x79EF0 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 249)]
        /* 0x7C380 */ public GcFishingRecord FishingRecord;
        [NMS(Index = 261, Size = 0x100)]
        /* 0x7DB80 */ public GcSpacePoiDiscoverySaveData[] SpacePoiDiscoveries;
        [NMS(Index = 189, Size = 0x1A, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x7F380 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Index = 210, Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x7FE10 */ public GcHotActionsSaveData[] HotActions;
        [NMS(Index = 122, Size = 0x4)]
        /* 0x801D0 */ public GcSquadronPilotData[] SquadronPilots;
        [NMS(Index = 193, Size = 0x6)]
        /* 0x80450 */ public GcCharacterCustomisationData[] CustomTruckPresets;
        [NMS(Index = 191, Size = 0x6)]
        /* 0x80660 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Index = 238, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x80870 */ public GcWonderRecord[] WonderCreatureRecords;
        [NMS(Index = 148)]
        /* 0x809D8 */ public GcInventoryContainer Chest10Inventory;
        [NMS(Index = 130)]
        /* 0x80B38 */ public GcInventoryContainer Chest1Inventory;
        [NMS(Index = 132)]
        /* 0x80C98 */ public GcInventoryContainer Chest2Inventory;
        [NMS(Index = 134)]
        /* 0x80DF8 */ public GcInventoryContainer Chest3Inventory;
        [NMS(Index = 136)]
        /* 0x80F58 */ public GcInventoryContainer Chest4Inventory;
        [NMS(Index = 138)]
        /* 0x810B8 */ public GcInventoryContainer Chest5Inventory;
        [NMS(Index = 140)]
        /* 0x81218 */ public GcInventoryContainer Chest6Inventory;
        [NMS(Index = 142)]
        /* 0x81378 */ public GcInventoryContainer Chest7Inventory;
        [NMS(Index = 144)]
        /* 0x814D8 */ public GcInventoryContainer Chest8Inventory;
        [NMS(Index = 146)]
        /* 0x81638 */ public GcInventoryContainer Chest9Inventory;
        [NMS(Index = 152)]
        /* 0x81798 */ public GcInventoryContainer ChestMagic2Inventory;
        [NMS(Index = 150)]
        /* 0x818F8 */ public GcInventoryContainer ChestMagicInventory;
        [NMS(Index = 154)]
        /* 0x81A58 */ public GcInventoryContainer CookingIngredientsInventory;
        [NMS(Index = 164)]
        /* 0x81BB8 */ public GcInventoryContainer CorvetteStorageInventory;
        [NMS(Index = 160)]
        /* 0x81D18 */ public GcInventoryContainer FishBaitBoxInventory;
        [NMS(Index = 158)]
        /* 0x81E78 */ public GcInventoryContainer FishPlatformInventory;
        [NMS(Index = 162)]
        /* 0x81FD8 */ public GcInventoryContainer FoodUnitInventory;
        [NMS(Index = 111)]
        /* 0x82138 */ public GcInventoryContainer FreighterInventory;
        [NMS(Index = 113)]
        /* 0x82298 */ public GcInventoryContainer FreighterInventory_Cargo;
        [NMS(Index = 112)]
        /* 0x823F8 */ public GcInventoryContainer FreighterInventory_TechOnly;
        [NMS(Index = 20)]
        /* 0x82558 */ public GcInventoryContainer GraveInventory;
        [NMS(Index = 6)]
        /* 0x826B8 */ public GcInventoryContainer Inventory;
        [NMS(Index = 8)]
        /* 0x82818 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 7)]
        /* 0x82978 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 156)]
        /* 0x82AD8 */ public GcInventoryContainer RocketLockerInventory;
        [NMS(Index = 9)]
        /* 0x82C38 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 10)]
        /* 0x82D98 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 241, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x82EF8 */ public GcWonderRecord[] WonderTreasureRecords;
        [NMS(Index = 232, Size = 0x4)]
        /* 0x83030 */ public GcSettlementHistory[] SettlementHistory;
        [NMS(Index = 243, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x83150 */ public GcWonderRecord[] WonderCustomRecords;
        [NMS(Index = 64, Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x83270 */ public GcInteractionBuffer[] StoredInteractions;
        [NMS(Index = 237, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x83378 */ public GcWonderRecord[] WonderPlanetRecords;
        [NMS(Index = 242, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x83480 */ public GcWonderRecord[] WonderWeirdBasePartRecords;
        [NMS(Index = 91, Size = 0x10)]
        /* 0x83588 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 239, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x83688 */ public GcWonderRecord[] WonderFloraRecords;
        [NMS(Index = 240, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x83748 */ public GcWonderRecord[] WonderMineralRecords;
        [NMS(Index = 234, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x83808 */ public GcStoryPageSeenDataArray[] SeenStories;
        [NMS(Index = 108)]
        /* 0x83898 */ public GcResourceElement CurrentFreighter;
        [NMS(Index = 165)]
        /* 0x838E0 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Index = 29)]
        /* 0x83928 */ public GcResourceElement CurrentShip;
        [NMS(Index = 245, Size = 0x4, EnumType = typeof(GcSynchronisedBufferType.SyncBufferTypeEnum))]
        /* 0x83970 */ public GcSyncBufferSaveDataArray[] SyncBuffersData;
        [NMS(Index = 30)]
        /* 0x839B0 */ public GcExactResource CurrentWeapon;
        [NMS(Index = 181)]
        /* 0x839D0 */ public GcPortalSaveData VisitedPortal;
        [NMS(Index = 147)]
        /* 0x839F0 */ public GcInventoryLayout Chest10Layout;
        [NMS(Index = 129)]
        /* 0x83A08 */ public GcInventoryLayout Chest1Layout;
        [NMS(Index = 131)]
        /* 0x83A20 */ public GcInventoryLayout Chest2Layout;
        [NMS(Index = 133)]
        /* 0x83A38 */ public GcInventoryLayout Chest3Layout;
        [NMS(Index = 135)]
        /* 0x83A50 */ public GcInventoryLayout Chest4Layout;
        [NMS(Index = 137)]
        /* 0x83A68 */ public GcInventoryLayout Chest5Layout;
        [NMS(Index = 139)]
        /* 0x83A80 */ public GcInventoryLayout Chest6Layout;
        [NMS(Index = 141)]
        /* 0x83A98 */ public GcInventoryLayout Chest7Layout;
        [NMS(Index = 143)]
        /* 0x83AB0 */ public GcInventoryLayout Chest8Layout;
        [NMS(Index = 145)]
        /* 0x83AC8 */ public GcInventoryLayout Chest9Layout;
        [NMS(Index = 151)]
        /* 0x83AE0 */ public GcInventoryLayout ChestMagic2Layout;
        [NMS(Index = 149)]
        /* 0x83AF8 */ public GcInventoryLayout ChestMagicLayout;
        [NMS(Index = 153)]
        /* 0x83B10 */ public GcInventoryLayout CookingIngredientsLayout;
        [NMS(Index = 163)]
        /* 0x83B28 */ public GcInventoryLayout CorvetteStorageLayout;
        [NMS(Index = 159)]
        /* 0x83B40 */ public GcInventoryLayout FishBaitBoxLayout;
        [NMS(Index = 157)]
        /* 0x83B58 */ public GcInventoryLayout FishPlatformLayout;
        [NMS(Index = 161)]
        /* 0x83B70 */ public GcInventoryLayout FoodUnitLayout;
        [NMS(Index = 110)]
        /* 0x83B88 */ public GcInventoryLayout FreighterCargoLayout;
        [NMS(Index = 109)]
        /* 0x83BA0 */ public GcInventoryLayout FreighterLayout;
        [NMS(Index = 155)]
        /* 0x83BB8 */ public GcInventoryLayout RocketLockerLayout;
        [NMS(Index = 27)]
        /* 0x83BD0 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 28)]
        /* 0x83BE8 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 223)]
        /* 0x83C00 */ public NMSString0x10 BannerTitleId;
        [NMS(Index = 124)]
        /* 0x83C10 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Index = 107)]
        /* 0x83C20 */ public GcSeed CurrentFreighterHomeSystemSeed;
        [NMS(Index = 39)]
        /* 0x83C30 */ public NMSString0x10 CurrentMissionID;
        [NMS(Index = 255)]
        /* 0x83C40 */ public List<GcDrainedTerrainResourceDeposit> DrainedTerrainResourceDeposits;
        [NMS(Index = 200)]
        /* 0x83C50 */ public List<ulong> ExpeditionSeedsSelectedToday;
        [NMS(Index = 199)]
        /* 0x83C60 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        [NMS(Index = 198)]
        /* 0x83C70 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        [NMS(Index = 197)]
        /* 0x83C80 */ public GcSeed FleetSeed;
        [NMS(Index = 204)]
        /* 0x83C90 */ public NMSString0x10 FoodUnitItem;
        [NMS(Index = 196)]
        /* 0x83CA0 */ public NMSString0x10 FreighterEngineEffect;
        [NMS(Index = 248)]
        /* 0x83CB0 */ public List<GcGalaxyWaypoint> GalaxyWaypoints;
        [NMS(Index = 76)]
        /* 0x83CC0 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Index = 195)]
        /* 0x83CD0 */ public NMSString0x10 JetpackEffect;
        [NMS(Index = 32)]
        /* 0x83CE0 */ public List<NMSString0x10> KnownProducts;
        [NMS(Index = 34)]
        /* 0x83CF0 */ public List<NMSString0x20A> KnownRefinerRecipes;
        [NMS(Index = 33)]
        /* 0x83D00 */ public List<NMSString0x10> KnownSpecials;
        [NMS(Index = 31)]
        /* 0x83D10 */ public List<NMSString0x10> KnownTech;
        [NMS(Index = 36)]
        /* 0x83D20 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        [NMS(Index = 35)]
        /* 0x83D30 */ public List<GcWordKnowledge> KnownWords;
        [NMS(Index = 180)]
        /* 0x83D40 */ public List<GcPortalSaveData> LastPortal;
        [NMS(Index = 65)]
        /* 0x83D50 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        [NMS(Index = 57)]
        /* 0x83D60 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Index = 37)]
        /* 0x83D70 */ public List<GcPlayerMissionProgress> MissionProgress;
        [NMS(Index = 44)]
        /* 0x83D80 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Index = 58)]
        /* 0x83D90 */ public List<GcScanEventSave> NewMPMarkerStack;
        [NMS(Index = 127)]
        /* 0x83DA0 */ public List<GcPersistentBase> PersistentPlayerBases;
        [NMS(Index = 66)]
        /* 0x83DB0 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        [NMS(Index = 41)]
        /* 0x83DC0 */ public NMSString0x10 PreviousMissionID;
        [NMS(Index = 229)]
        /* 0x83DD0 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Index = 227)]
        /* 0x83DE0 */ public List<NMSString0x10> RedeemedSeasonRewards;
        [NMS(Index = 228)]
        /* 0x83DF0 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Index = 247)]
        /* 0x83E00 */ public List<GcMaintenanceContainer> RefinerBufferData;
        [NMS(Index = 246)]
        /* 0x83E10 */ public List<GcMaintenanceSaveKey> RefinerBufferKeys;
        [NMS(Index = 208)]
        /* 0x83E20 */ public List<GcRepairTechData> RepairTechBuffer;
        [NMS(Index = 75)]
        /* 0x83E30 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        [NMS(Index = 123)]
        /* 0x83E40 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        [NMS(Index = 256)]
        /* 0x83E50 */ public List<GcSettlementLocalSaveData> SettlementLocalSaveData;
        [NMS(Index = 172)]
        /* 0x83E60 */ public List<GcVehicleCargoData> ShipMoveableContents;
        [NMS(Index = 62)]
        /* 0x83E70 */ public List<GcPlayerStatsGroup> Stats;
        [NMS(Index = 59)]
        /* 0x83E80 */ public List<Vector3f> SurveyedEventPositions;
        [NMS(Index = 63)]
        /* 0x83E90 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Index = 128)]
        /* 0x83EA0 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Index = 179)]
        /* 0x83EB0 */ public List<GcTradingSupplyData> TradingSupplyData;
        [NMS(Index = 89)]
        /* 0x83EC0 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Index = 79)]
        /* 0x83ED0 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        [NMS(Index = 67)]
        /* 0x83EE0 */ public List<ulong> VisitedSystems;
        [NMS(Index = 11)]
        /* 0x83EF0 */ public List<GcInWorldUIScreenData> WristScreenData;
        [NMS(Index = 95)]
        /* 0x83F00 */ public ulong ActiveSpaceBattleUA;
        [NMS(Index = 259)]
        /* 0x83F08 */ public ulong CorvetteDraftShipSeed;
        [NMS(Index = 40)]
        /* 0x83F10 */ public ulong CurrentMissionSeed;
        [NMS(Index = 251)]
        /* 0x83F18 */ public ulong FirstPurpleSystemUA;
        [NMS(Index = 114)]
        /* 0x83F20 */ public ulong FreighterLastSpawnTime;
        [NMS(Index = 105)]
        /* 0x83F28 */ public ulong HazardTimeAlive;
        [NMS(Index = 61)]
        /* 0x83F30 */ public ulong LastCheckedForStatResetsTime;
        [NMS(Index = 201)]
        /* 0x83F38 */ public ulong LastKnownDay;
        [NMS(Index = 211)]
        /* 0x83F40 */ public ulong LastUABeforePortalWarp;
        [NMS(Index = 99)]
        /* 0x83F48 */ public ulong MiniStationUA;
        [NMS(Index = 205)]
        /* 0x83F50 */ public ulong MultiplayerLobbyID;
        [NMS(Index = 209)]
        /* 0x83F58 */ public ulong MultiplayerPrivileges;
        [NMS(Index = 42)]
        /* 0x83F60 */ public ulong PreviousMissionSeed;
        [NMS(Index = 212)]
        /* 0x83F68 */ public ulong StoryPortalSeed;
        [NMS(Index = 202)]
        /* 0x83F70 */ public ulong SunTimer;
        [NMS(Index = 260)]
        /* 0x83F78 */ public ulong SwarmPreMissionUA;
        [NMS(Index = 254)]
        /* 0x83F80 */ public ulong TaggedPlanetUA;
        [NMS(Index = 56)]
        /* 0x83F88 */ public ulong TimeAlive;
        [NMS(Index = 97)]
        /* 0x83F90 */ public ulong TimeLastMiniStation;
        [NMS(Index = 93)]
        /* 0x83F98 */ public ulong TimeLastSpaceBattle;
        [NMS(Index = 5)]
        /* 0x83FA0 */ public ulong TimeStamp;
        [NMS(Index = 74, Size = 0xA2, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x83FA8 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        [NMS(Index = 244, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x85E08 */ public GcWonderRecordCustomData[] WonderCustomRecordsExtraData;
        [NMS(Index = 81, Size = 0xB)]
        /* 0x86138 */ public GcUniverseAddressData[] CompletedAtlasAddresses;
        [NMS(Index = 78, Size = 0xB)]
        /* 0x86240 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        [NMS(Index = 77, Size = 0xA)]
        /* 0x86348 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Index = 82, Size = 0xA)]
        /* 0x86438 */ public GcUniverseAddressData[] DestroyedAtlasAddresses;
        [NMS(Index = 4)]
        /* 0x86528 */ public GcDifficultyStateData DifficultyState;
        [NMS(Index = 68, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x86594 */ public float[] Hazard;
        [NMS(Index = 115)]
        /* 0x865B0 */ public GcUniverseAddressData FreighterUniverseAddress;
        [NMS(Index = 101)]
        /* 0x865C8 */ public GcUniverseAddressData GameStartAddress1;
        [NMS(Index = 102)]
        /* 0x865E0 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Index = 23)]
        /* 0x865F8 */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Index = 206)]
        /* 0x86610 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Index = 216)]
        /* 0x86628 */ public GcUniverseAddressData NexusUniverseAddress;
        [NMS(Index = 1)]
        /* 0x86640 */ public GcUniverseAddressData PreviousUniverseAddress;
        [NMS(Index = 0)]
        /* 0x86658 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 19)]
        /* 0x86670 */ public GcPetBattleTeamData PetBattleTeam;
        [NMS(Index = 13)]
        /* 0x8667C */ public int ActiveMultioolIndex;
        [NMS(Index = 96)]
        /* 0x86680 */ public GcSpaceBattleType ActiveSpaceBattleType;
        [NMS(Index = 222)]
        /* 0x86684 */ public int BannerBackgroundColour;
        [NMS(Index = 220)]
        /* 0x86688 */ public int BannerIcon;
        [NMS(Index = 221)]
        /* 0x8668C */ public int BannerMainColour;
        [NMS(Index = 69)]
        /* 0x86690 */ public int BoltAmmo;
        [NMS(Index = 257)]
        /* 0x86694 */ public int CorvetteEditAssociatedShipIndex;
        [NMS(Index = 52)]
        /* 0x86698 */ public int Energy;
        [NMS(Index = 203)]
        /* 0x8669C */ public float FoodUnitAccumulator;
        [NMS(Index = 48)]
        /* 0x866A0 */ public int Health;
        [NMS(Index = 2)]
        /* 0x866A4 */ public int HomeRealityIteration;
        [NMS(Index = 182)]
        /* 0x866A8 */ public int KnownPortalRunes;
        [NMS(Index = 72)]
        /* 0x866AC */ public int LaserAmmo;
        [NMS(Index = 43)]
        /* 0x866B0 */ public int MissionVersion;
        [NMS(Index = 83)]
        /* 0x866B4 */ public int MostRecentDestroyedAtlasIndex;
        [NMS(Index = 54)]
        /* 0x866B8 */ public int Nanites;
        [NMS(Index = 60)]
        /* 0x866BC */ public int NextSurveyedEventPositionIndex;
        [NMS(Index = 38)]
        /* 0x866C0 */ public int PostMissionIndex;
        [NMS(Index = 92)]
        /* 0x866C4 */ public int PrimaryPlanet;
        [NMS(Index = 171)]
        /* 0x866C8 */ public int PrimaryShip;
        [NMS(Index = 167)]
        /* 0x866CC */ public int PrimaryVehicle;
        [NMS(Index = 85)]
        /* 0x866D0 */ public int ProcTechIndex;
        [NMS(Index = 84)]
        /* 0x866D4 */ public int ProgressionLevel;
        [NMS(Index = 71)]
        /* 0x866D8 */ public int PulseAmmo;
        [NMS(Index = 70)]
        /* 0x866DC */ public int ScatterAmmo;
        [NMS(Index = 231)]
        /* 0x866E0 */ public int SettlementStateRingBufferIndexV2;
        [NMS(Index = 50)]
        /* 0x866E4 */ public int Shield;
        [NMS(Index = 49)]
        /* 0x866E8 */ public int ShipHealth;
        [NMS(Index = 51)]
        /* 0x866EC */ public int ShipShield;
        [NMS(Index = 262)]
        /* 0x866F0 */ public int SpacePoiDiscoveryNextIndex;
        [NMS(Index = 55)]
        /* 0x866F4 */ public int Specials;
        [NMS(Index = 187)]
        /* 0x866F8 */ public GcPlayerWeapons StartingPrimaryWeapon;
        [NMS(Index = 236)]
        /* 0x866FC */ public int StartingSeasonNumber;
        [NMS(Index = 188)]
        /* 0x86700 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Index = 224)]
        /* 0x86704 */ public int TelemetryUploadVersion;
        [NMS(Index = 178)]
        /* 0x86708 */ public int TradingSupplyDataIndex;
        [NMS(Index = 53)]
        /* 0x8670C */ public int Units;
        [NMS(Index = 225)]
        /* 0x86710 */ public float VRCameraOffset;
        [NMS(Index = 98)]
        /* 0x86714 */ public int WarpsLastMiniStation;
        [NMS(Index = 94)]
        /* 0x86718 */ public int WarpsLastSpaceBattle;
        [NMS(Index = 213)]
        /* 0x8671C */ public ushort ShopNumber;
        [NMS(Index = 214)]
        /* 0x8671E */ public ushort ShopTier;
        [NMS(Index = 194, Size = 0x6)]
        /* 0x86720 */ public NMSString0x20[] CustomTruckPresetNames;
        [NMS(Index = 192, Size = 0x6)]
        /* 0x867E0 */ public NMSString0x20[] OutfitNames;
        [NMS(Index = 258)]
        /* 0x868A0 */ public NMSString0x80 CorvetteEditShipName;
        [NMS(Index = 3)]
        /* 0x86920 */ public NMSString0x80 SaveSummary;
        [NMS(Index = 175)]
        /* 0x869A0 */ public NMSString0x20 PlayerFreighterName;
        [NMS(Index = 18, Size = 0x1E)]
        /* 0x869C0 */ public bool[] UnlockedPetSlots;
        [NMS(Index = 103, Size = 0x10)]
        /* 0x869DE */ public bool[] GalacticMapRequests;
        [NMS(Index = 190, Size = 0xC)]
        /* 0x869EE */ public bool[] ShipUsesLegacyColours;
        [NMS(Index = 121, Size = 0x4)]
        /* 0x869FA */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Index = 235)]
        /* 0x869FE */ public bool BuildersKnown;
        [NMS(Index = 80)]
        /* 0x869FF */ public bool FirstAtlasStationDiscovered;
        [NMS(Index = 116)]
        /* 0x86A00 */ public bool FreighterDismissed;
        [NMS(Index = 215)]
        /* 0x86A01 */ public bool HasAccessToNexus;
        [NMS(Index = 250)]
        /* 0x86A02 */ public bool HasDiscoveredPurpleSystems;
        [NMS(Index = 252)]
        /* 0x86A03 */ public bool HasGalacticMapRequestAllPurples;
        [NMS(Index = 253)]
        /* 0x86A04 */ public bool HasGalacticMapRequestFirstPurple;
        [NMS(Index = 86)]
        /* 0x86A05 */ public bool IsNew;
        [NMS(Index = 173)]
        /* 0x86A06 */ public bool MultiShipEnabled;
        [NMS(Index = 233)]
        /* 0x86A07 */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Index = 183)]
        /* 0x86A08 */ public bool OnOtherSideOfPortal;
        [NMS(Index = 88)]
        /* 0x86A09 */ public bool OrbPlayer;
        [NMS(Index = 226)]
        /* 0x86A0A */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Index = 106)]
        /* 0x86A0B */ public bool RevealBlackHoles;
        [NMS(Index = 177)]
        /* 0x86A0C */ public bool ShipNeedsTerrainPositioning;
        [NMS(Index = 22)]
        /* 0x86A0D */ public bool SpaceGrave;
        [NMS(Index = 21)]
        /* 0x86A0E */ public bool SpawnGrave;
        [NMS(Index = 87)]
        /* 0x86A0F */ public bool UseSmallerBlackholeJumps;
        [NMS(Index = 174)]
        /* 0x86A10 */ public bool VehicleAIControlEnabled;
    }
}
