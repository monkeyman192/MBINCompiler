using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA5B5B866F1520EB, NameHash = 0x6C4510BB243EFA64)]
    public class GcPlayerStateData : NMSTemplate
    {
        [NMS(Index = 119)]
        /* 0x00000 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Index = 208, Size = 0x64)]
        /* 0x3C780 */ public GcSettlementState[] SettlementStatesV2;
        [NMS(Index = 154, Size = 0xC)]
        /* 0x5B540 */ public GcPlayerOwnershipData[] ShipOwnership;
        [NMS(Index = 152, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x60AC0 */ public GcPlayerOwnershipData[] VehicleOwnership;
        [NMS(Index = 12, Size = 0x6)]
        /* 0x63CA0 */ public GcMultitoolData[] Multitools;
        [NMS(Index = 120, Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x659E0 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Index = 85, Size = 0x10)]
        /* 0x66840 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 185)]
        /* 0x66940 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        [NMS(Index = 167)]
        /* 0x66A10 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        [NMS(Index = 43)]
        /* 0x66A90 */ public GcInteractionData HoloExplorerInteraction;
        [NMS(Index = 45)]
        /* 0x66AB0 */ public GcInteractionData HoloNooneInteraction;
        [NMS(Index = 44)]
        /* 0x66AD0 */ public GcInteractionData HoloScepticInteraction;
        [NMS(Index = 95)]
        /* 0x66AF0 */ public Vector4f AnomalyPositionOverride;
        [NMS(Index = 99)]
        /* 0x66B00 */ public Vector4f FirstShipPosition;
        [NMS(Index = 71)]
        /* 0x66B10 */ public Vector4f FirstSpawnPosition;
        [NMS(Index = 112)]
        /* 0x66B20 */ public Vector3f FreighterMatrixAt;
        [NMS(Index = 114)]
        /* 0x66B30 */ public Vector3f FreighterMatrixPos;
        [NMS(Index = 113)]
        /* 0x66B40 */ public Vector3f FreighterMatrixUp;
        [NMS(Index = 23)]
        /* 0x66B50 */ public Vector4f GraveMatrixLookAt;
        [NMS(Index = 24)]
        /* 0x66B60 */ public Vector4f GraveMatrixUp;
        [NMS(Index = 22)]
        /* 0x66B70 */ public Vector4f GravePosition;
        [NMS(Index = 195)]
        /* 0x66B80 */ public Vector3f NexusMatrixAt;
        [NMS(Index = 197)]
        /* 0x66B90 */ public Vector3f NexusMatrixPos;
        [NMS(Index = 196)]
        /* 0x66BA0 */ public Vector3f NexusMatrixUp;
        [NMS(Index = 168)]
        /* 0x66BB0 */ public Vector4f PortalMarkerPosition_Local;
        [NMS(Index = 169)]
        /* 0x66BC0 */ public Vector4f PortalMarkerPosition_Offset;
        [NMS(Index = 159)]
        /* 0x66BD0 */ public Vector4f StartGameShipPosition;
        [NMS(Index = 15, Size = 0x12)]
        /* 0x66BE0 */ public GcPetData[] Eggs;
        [NMS(Index = 14, Size = 0x12)]
        /* 0x69070 */ public GcPetData[] Pets;
        [NMS(Index = 16, Size = 0x12)]
        /* 0x6B500 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 116, Size = 0x4)]
        /* 0x6CAF0 */ public GcSquadronPilotData[] SquadronPilots;
        [NMS(Index = 172, Size = 0x18, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x6E070 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Index = 188, Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x6EA30 */ public GcHotActionsSaveData[] HotActions;
        [NMS(Index = 103)]
        /* 0x6EDF0 */ public GcResourceElement CurrentFreighter;
        [NMS(Index = 151)]
        /* 0x6F098 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Index = 27)]
        /* 0x6F340 */ public GcResourceElement CurrentShip;
        [NMS(Index = 215, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x6F5E8 */ public GcWonderRecord[] WonderCreatureRecords;
        [NMS(Index = 142)]
        /* 0x6F750 */ public GcInventoryContainer Chest10Inventory;
        [NMS(Index = 124)]
        /* 0x6F8A8 */ public GcInventoryContainer Chest1Inventory;
        [NMS(Index = 126)]
        /* 0x6FA00 */ public GcInventoryContainer Chest2Inventory;
        [NMS(Index = 128)]
        /* 0x6FB58 */ public GcInventoryContainer Chest3Inventory;
        [NMS(Index = 130)]
        /* 0x6FCB0 */ public GcInventoryContainer Chest4Inventory;
        [NMS(Index = 132)]
        /* 0x6FE08 */ public GcInventoryContainer Chest5Inventory;
        [NMS(Index = 134)]
        /* 0x6FF60 */ public GcInventoryContainer Chest6Inventory;
        [NMS(Index = 136)]
        /* 0x700B8 */ public GcInventoryContainer Chest7Inventory;
        [NMS(Index = 138)]
        /* 0x70210 */ public GcInventoryContainer Chest8Inventory;
        [NMS(Index = 140)]
        /* 0x70368 */ public GcInventoryContainer Chest9Inventory;
        [NMS(Index = 146)]
        /* 0x704C0 */ public GcInventoryContainer ChestMagic2Inventory;
        [NMS(Index = 144)]
        /* 0x70618 */ public GcInventoryContainer ChestMagicInventory;
        [NMS(Index = 148)]
        /* 0x70770 */ public GcInventoryContainer CookingIngredientsInventory;
        [NMS(Index = 106)]
        /* 0x708C8 */ public GcInventoryContainer FreighterInventory;
        [NMS(Index = 108)]
        /* 0x70A20 */ public GcInventoryContainer FreighterInventory_Cargo;
        [NMS(Index = 107)]
        /* 0x70B78 */ public GcInventoryContainer FreighterInventory_TechOnly;
        [NMS(Index = 18)]
        /* 0x70CD0 */ public GcInventoryContainer GraveInventory;
        [NMS(Index = 6)]
        /* 0x70E28 */ public GcInventoryContainer Inventory;
        [NMS(Index = 8)]
        /* 0x70F80 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 7)]
        /* 0x710D8 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 150)]
        /* 0x71230 */ public GcInventoryContainer RocketLockerInventory;
        [NMS(Index = 9)]
        /* 0x71388 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 10)]
        /* 0x714E0 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 218, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x71638 */ public GcWonderRecord[] WonderTreasureRecords;
        [NMS(Index = 220, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x71770 */ public GcWonderRecord[] WonderCustomRecords;
        [NMS(Index = 174, Size = 0x3)]
        /* 0x71890 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Index = 62, Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x71998 */ public GcInteractionBuffer[] StoredInteractions;
        [NMS(Index = 214, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x71AA0 */ public GcWonderRecord[] WonderPlanetRecords;
        [NMS(Index = 219, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x71BA8 */ public GcWonderRecord[] WonderWeirdBasePartRecords;
        [NMS(Index = 86, Size = 0x10)]
        /* 0x71CB0 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 216, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x71DB0 */ public GcWonderRecord[] WonderFloraRecords;
        [NMS(Index = 217, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x71E70 */ public GcWonderRecord[] WonderMineralRecords;
        [NMS(Index = 28)]
        /* 0x71F30 */ public GcExactResource CurrentWeapon;
        [NMS(Index = 211, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x71FC0 */ public GcStoryPageSeenDataArray[] SeenStories;
        [NMS(Index = 222, Size = 0x4, EnumType = typeof(GcSynchronisedBufferType.SyncBufferTypeEnum))]
        /* 0x72050 */ public GcSyncBufferSaveDataArray[] SyncBuffersData;
        [NMS(Index = 164)]
        /* 0x72090 */ public GcPortalSaveData VisitedPortal;
        [NMS(Index = 141)]
        /* 0x720B0 */ public GcInventoryLayout Chest10Layout;
        [NMS(Index = 123)]
        /* 0x720C8 */ public GcInventoryLayout Chest1Layout;
        [NMS(Index = 125)]
        /* 0x720E0 */ public GcInventoryLayout Chest2Layout;
        [NMS(Index = 127)]
        /* 0x720F8 */ public GcInventoryLayout Chest3Layout;
        [NMS(Index = 129)]
        /* 0x72110 */ public GcInventoryLayout Chest4Layout;
        [NMS(Index = 131)]
        /* 0x72128 */ public GcInventoryLayout Chest5Layout;
        [NMS(Index = 133)]
        /* 0x72140 */ public GcInventoryLayout Chest6Layout;
        [NMS(Index = 135)]
        /* 0x72158 */ public GcInventoryLayout Chest7Layout;
        [NMS(Index = 137)]
        /* 0x72170 */ public GcInventoryLayout Chest8Layout;
        [NMS(Index = 139)]
        /* 0x72188 */ public GcInventoryLayout Chest9Layout;
        [NMS(Index = 145)]
        /* 0x721A0 */ public GcInventoryLayout ChestMagic2Layout;
        [NMS(Index = 143)]
        /* 0x721B8 */ public GcInventoryLayout ChestMagicLayout;
        [NMS(Index = 147)]
        /* 0x721D0 */ public GcInventoryLayout CookingIngredientsLayout;
        [NMS(Index = 105)]
        /* 0x721E8 */ public GcInventoryLayout FreighterCargoLayout;
        [NMS(Index = 104)]
        /* 0x72200 */ public GcInventoryLayout FreighterLayout;
        [NMS(Index = 149)]
        /* 0x72218 */ public GcInventoryLayout RocketLockerLayout;
        [NMS(Index = 25)]
        /* 0x72230 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 26)]
        /* 0x72248 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 201)]
        /* 0x72260 */ public NMSString0x10 BannerTitleId;
        [NMS(Index = 118)]
        /* 0x72270 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Index = 102)]
        /* 0x72280 */ public GcSeed CurrentFreighterHomeSystemSeed;
        [NMS(Index = 37)]
        /* 0x72290 */ public NMSString0x10 CurrentMissionID;
        [NMS(Index = 180)]
        /* 0x722A0 */ public List<ulong> ExpeditionSeedsSelectedToday;
        [NMS(Index = 179)]
        /* 0x722B0 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        [NMS(Index = 178)]
        /* 0x722C0 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        [NMS(Index = 177)]
        /* 0x722D0 */ public GcSeed FleetSeed;
        [NMS(Index = 176)]
        /* 0x722E0 */ public NMSString0x10 FreighterEngineEffect;
        [NMS(Index = 225)]
        /* 0x722F0 */ public List<GcGalaxyWaypoint> GalaxyWaypoints;
        [NMS(Index = 74)]
        /* 0x72300 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Index = 175)]
        /* 0x72310 */ public NMSString0x10 JetpackEffect;
        [NMS(Index = 30)]
        /* 0x72320 */ public List<NMSString0x10> KnownProducts;
        [NMS(Index = 32)]
        /* 0x72330 */ public List<NMSString0x20A> KnownRefinerRecipes;
        [NMS(Index = 31)]
        /* 0x72340 */ public List<NMSString0x10> KnownSpecials;
        [NMS(Index = 29)]
        /* 0x72350 */ public List<NMSString0x10> KnownTech;
        [NMS(Index = 34)]
        /* 0x72360 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        [NMS(Index = 33)]
        /* 0x72370 */ public List<GcWordKnowledge> KnownWords;
        [NMS(Index = 163)]
        /* 0x72380 */ public List<GcPortalSaveData> LastPortal;
        [NMS(Index = 63)]
        /* 0x72390 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        [NMS(Index = 55)]
        /* 0x723A0 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Index = 35)]
        /* 0x723B0 */ public List<GcPlayerMissionProgress> MissionProgress;
        [NMS(Index = 42)]
        /* 0x723C0 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Index = 56)]
        /* 0x723D0 */ public List<GcScanEventSave> NewMPMarkerStack;
        [NMS(Index = 121)]
        /* 0x723E0 */ public List<GcPersistentBase> PersistentPlayerBases;
        [NMS(Index = 64)]
        /* 0x723F0 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        [NMS(Index = 39)]
        /* 0x72400 */ public NMSString0x10 PreviousMissionID;
        [NMS(Index = 207)]
        /* 0x72410 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Index = 205)]
        /* 0x72420 */ public List<NMSString0x10> RedeemedSeasonRewards;
        [NMS(Index = 206)]
        /* 0x72430 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Index = 224)]
        /* 0x72440 */ public List<GcMaintenanceContainer> RefinerBufferData;
        [NMS(Index = 223)]
        /* 0x72450 */ public List<GcMaintenanceSaveKey> RefinerBufferKeys;
        [NMS(Index = 186)]
        /* 0x72460 */ public List<GcRepairTechData> RepairTechBuffer;
        [NMS(Index = 73)]
        /* 0x72470 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        [NMS(Index = 117)]
        /* 0x72480 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        [NMS(Index = 60)]
        /* 0x72490 */ public List<GcPlayerStatsGroup> Stats;
        [NMS(Index = 57)]
        /* 0x724A0 */ public List<Vector3f> SurveyedEventPositions;
        [NMS(Index = 61)]
        /* 0x724B0 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Index = 122)]
        /* 0x724C0 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Index = 162)]
        /* 0x724D0 */ public List<GcTradingSupplyData> TradingSupplyData;
        [NMS(Index = 84)]
        /* 0x724E0 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Index = 77)]
        /* 0x724F0 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        [NMS(Index = 65)]
        /* 0x72500 */ public List<ulong> VisitedSystems;
        [NMS(Index = 11)]
        /* 0x72510 */ public List<GcInWorldUIScreenData> WristScreenData;
        [NMS(Index = 90)]
        /* 0x72520 */ public ulong ActiveSpaceBattleUA;
        [NMS(Index = 38)]
        /* 0x72528 */ public ulong CurrentMissionSeed;
        [NMS(Index = 109)]
        /* 0x72530 */ public ulong FreighterLastSpawnTime;
        [NMS(Index = 100)]
        /* 0x72538 */ public ulong HazardTimeAlive;
        [NMS(Index = 59)]
        /* 0x72540 */ public ulong LastCheckedForStatResetsTime;
        [NMS(Index = 181)]
        /* 0x72548 */ public ulong LastKnownDay;
        [NMS(Index = 189)]
        /* 0x72550 */ public ulong LastUABeforePortalWarp;
        [NMS(Index = 94)]
        /* 0x72558 */ public ulong MiniStationUA;
        [NMS(Index = 183)]
        /* 0x72560 */ public ulong MultiplayerLobbyID;
        [NMS(Index = 187)]
        /* 0x72568 */ public ulong MultiplayerPrivileges;
        [NMS(Index = 40)]
        /* 0x72570 */ public ulong PreviousMissionSeed;
        [NMS(Index = 190)]
        /* 0x72578 */ public ulong StoryPortalSeed;
        [NMS(Index = 182)]
        /* 0x72580 */ public ulong SunTimer;
        [NMS(Index = 54)]
        /* 0x72588 */ public ulong TimeAlive;
        [NMS(Index = 92)]
        /* 0x72590 */ public ulong TimeLastMiniStation;
        [NMS(Index = 88)]
        /* 0x72598 */ public ulong TimeLastSpaceBattle;
        [NMS(Index = 5)]
        /* 0x725A0 */ public ulong TimeStamp;
        [NMS(Index = 72, Size = 0x8C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x725A8 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        [NMS(Index = 221, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x73FE8 */ public GcWonderRecordCustomData[] WonderCustomRecordsExtraData;
        [NMS(Index = 79, Size = 0xB)]
        /* 0x74318 */ public GcUniverseAddressData[] CompletedAtlasAddresses;
        [NMS(Index = 76, Size = 0xB)]
        /* 0x74420 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        [NMS(Index = 75, Size = 0xA)]
        /* 0x74528 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Index = 4)]
        /* 0x74618 */ public GcDifficultyStateData DifficultyState;
        [NMS(Index = 110)]
        /* 0x7467C */ public GcUniverseAddressData FreighterUniverseAddress;
        [NMS(Index = 96)]
        /* 0x74694 */ public GcUniverseAddressData GameStartAddress1;
        [NMS(Index = 97)]
        /* 0x746AC */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Index = 21)]
        /* 0x746C4 */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Index = 66, Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x746DC */ public float[] Hazard;
        [NMS(Index = 184)]
        /* 0x746F4 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Index = 194)]
        /* 0x7470C */ public GcUniverseAddressData NexusUniverseAddress;
        [NMS(Index = 1)]
        /* 0x74724 */ public GcUniverseAddressData PreviousUniverseAddress;
        [NMS(Index = 0)]
        /* 0x7473C */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 13)]
        /* 0x74754 */ public int ActiveMultioolIndex;
        [NMS(Index = 91)]
        /* 0x74758 */ public int ActiveSpaceBattleLevel;
        [NMS(Index = 200)]
        /* 0x7475C */ public int BannerBackgroundColour;
        [NMS(Index = 198)]
        /* 0x74760 */ public int BannerIcon;
        [NMS(Index = 199)]
        /* 0x74764 */ public int BannerMainColour;
        [NMS(Index = 67)]
        /* 0x74768 */ public int BoltAmmo;
        [NMS(Index = 50)]
        /* 0x7476C */ public int Energy;
        [NMS(Index = 46)]
        /* 0x74770 */ public int Health;
        [NMS(Index = 2)]
        /* 0x74774 */ public int HomeRealityIteration;
        [NMS(Index = 165)]
        /* 0x74778 */ public int KnownPortalRunes;
        [NMS(Index = 70)]
        /* 0x7477C */ public int LaserAmmo;
        [NMS(Index = 41)]
        /* 0x74780 */ public int MissionVersion;
        [NMS(Index = 52)]
        /* 0x74784 */ public int Nanites;
        [NMS(Index = 58)]
        /* 0x74788 */ public int NextSurveyedEventPositionIndex;
        [NMS(Index = 36)]
        /* 0x7478C */ public int PostMissionIndex;
        [NMS(Index = 87)]
        /* 0x74790 */ public int PrimaryPlanet;
        [NMS(Index = 155)]
        /* 0x74794 */ public int PrimaryShip;
        [NMS(Index = 153)]
        /* 0x74798 */ public int PrimaryVehicle;
        [NMS(Index = 81)]
        /* 0x7479C */ public int ProcTechIndex;
        [NMS(Index = 80)]
        /* 0x747A0 */ public int ProgressionLevel;
        [NMS(Index = 69)]
        /* 0x747A4 */ public int PulseAmmo;
        [NMS(Index = 68)]
        /* 0x747A8 */ public int ScatterAmmo;
        [NMS(Index = 209)]
        /* 0x747AC */ public int SettlementStateRingBufferIndexV2;
        [NMS(Index = 48)]
        /* 0x747B0 */ public int Shield;
        [NMS(Index = 47)]
        /* 0x747B4 */ public int ShipHealth;
        [NMS(Index = 49)]
        /* 0x747B8 */ public int ShipShield;
        [NMS(Index = 53)]
        /* 0x747BC */ public int Specials;
        [NMS(Index = 170)]
        /* 0x747C0 */ public GcPlayerWeapons StartingPrimaryWeapon;
        [NMS(Index = 213)]
        /* 0x747C4 */ public int StartingSeasonNumber;
        [NMS(Index = 171)]
        /* 0x747C8 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Index = 202)]
        /* 0x747CC */ public int TelemetryUploadVersion;
        [NMS(Index = 161)]
        /* 0x747D0 */ public int TradingSupplyDataIndex;
        [NMS(Index = 51)]
        /* 0x747D4 */ public int Units;
        [NMS(Index = 203)]
        /* 0x747D8 */ public float VRCameraOffset;
        [NMS(Index = 93)]
        /* 0x747DC */ public int WarpsLastMiniStation;
        [NMS(Index = 89)]
        /* 0x747E0 */ public int WarpsLastSpaceBattle;
        [NMS(Index = 191)]
        /* 0x747E4 */ public ushort ShopNumber;
        [NMS(Index = 192)]
        /* 0x747E6 */ public ushort ShopTier;
        [NMS(Index = 3)]
        /* 0x747E8 */ public NMSString0x80 SaveSummary;
        [NMS(Index = 158)]
        /* 0x74868 */ public NMSString0x20 PlayerFreighterName;
        [NMS(Index = 17, Size = 0x12)]
        /* 0x74888 */ public bool[] UnlockedPetSlots;
        [NMS(Index = 98, Size = 0x10)]
        /* 0x7489A */ public bool[] GalacticMapRequests;
        [NMS(Index = 173, Size = 0xC)]
        /* 0x748AA */ public bool[] ShipUsesLegacyColours;
        [NMS(Index = 115, Size = 0x4)]
        /* 0x748B6 */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Index = 212)]
        /* 0x748BA */ public bool BuildersKnown;
        [NMS(Index = 78)]
        /* 0x748BB */ public bool FirstAtlasStationDiscovered;
        [NMS(Index = 111)]
        /* 0x748BC */ public bool FreighterDismissed;
        [NMS(Index = 193)]
        /* 0x748BD */ public bool HasAccessToNexus;
        [NMS(Index = 82)]
        /* 0x748BE */ public bool IsNew;
        [NMS(Index = 156)]
        /* 0x748BF */ public bool MultiShipEnabled;
        [NMS(Index = 210)]
        /* 0x748C0 */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Index = 166)]
        /* 0x748C1 */ public bool OnOtherSideOfPortal;
        [NMS(Index = 204)]
        /* 0x748C2 */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Index = 101)]
        /* 0x748C3 */ public bool RevealBlackHoles;
        [NMS(Index = 160)]
        /* 0x748C4 */ public bool ShipNeedsTerrainPositioning;
        [NMS(Index = 20)]
        /* 0x748C5 */ public bool SpaceGrave;
        [NMS(Index = 19)]
        /* 0x748C6 */ public bool SpawnGrave;
        [NMS(Index = 83)]
        /* 0x748C7 */ public bool UseSmallerBlackholeJumps;
        [NMS(Index = 157)]
        /* 0x748C8 */ public bool VehicleAIControlEnabled;
    }
}
