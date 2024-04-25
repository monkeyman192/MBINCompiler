using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83A1D26BBD56747F, NameHash = 0x6C4510BB243EFA64)]
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
        /* 0x65980 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Index = 85, Size = 0x10)]
        /* 0x667E0 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 185)]
        /* 0x668E0 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        [NMS(Index = 167)]
        /* 0x669B0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        [NMS(Index = 43)]
        /* 0x66A30 */ public GcInteractionData HoloExplorerInteraction;
        [NMS(Index = 45)]
        /* 0x66A50 */ public GcInteractionData HoloNooneInteraction;
        [NMS(Index = 44)]
        /* 0x66A70 */ public GcInteractionData HoloScepticInteraction;
        [NMS(Index = 95)]
        /* 0x66A90 */ public Vector4f AnomalyPositionOverride;
        [NMS(Index = 99)]
        /* 0x66AA0 */ public Vector4f FirstShipPosition;
        [NMS(Index = 71)]
        /* 0x66AB0 */ public Vector4f FirstSpawnPosition;
        [NMS(Index = 112)]
        /* 0x66AC0 */ public Vector3f FreighterMatrixAt;
        [NMS(Index = 114)]
        /* 0x66AD0 */ public Vector3f FreighterMatrixPos;
        [NMS(Index = 113)]
        /* 0x66AE0 */ public Vector3f FreighterMatrixUp;
        [NMS(Index = 23)]
        /* 0x66AF0 */ public Vector4f GraveMatrixLookAt;
        [NMS(Index = 24)]
        /* 0x66B00 */ public Vector4f GraveMatrixUp;
        [NMS(Index = 22)]
        /* 0x66B10 */ public Vector4f GravePosition;
        [NMS(Index = 195)]
        /* 0x66B20 */ public Vector3f NexusMatrixAt;
        [NMS(Index = 197)]
        /* 0x66B30 */ public Vector3f NexusMatrixPos;
        [NMS(Index = 196)]
        /* 0x66B40 */ public Vector3f NexusMatrixUp;
        [NMS(Index = 168)]
        /* 0x66B50 */ public Vector4f PortalMarkerPosition_Local;
        [NMS(Index = 169)]
        /* 0x66B60 */ public Vector4f PortalMarkerPosition_Offset;
        [NMS(Index = 159)]
        /* 0x66B70 */ public Vector4f StartGameShipPosition;
        [NMS(Index = 15, Size = 0x12)]
        /* 0x66B80 */ public GcPetData[] Eggs;
        [NMS(Index = 14, Size = 0x12)]
        /* 0x69010 */ public GcPetData[] Pets;
        [NMS(Index = 116, Size = 0x4)]
        /* 0x6B4A0 */ public GcSquadronPilotData[] SquadronPilots;
        [NMS(Index = 16, Size = 0x12)]
        /* 0x6CA20 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 172, Size = 0x18, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x6DCB0 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Index = 188, Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x6E4F0 */ public GcHotActionsSaveData[] HotActions;
        [NMS(Index = 103)]
        /* 0x6E8B0 */ public GcResourceElement CurrentFreighter;
        [NMS(Index = 151)]
        /* 0x6EB58 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Index = 27)]
        /* 0x6EE00 */ public GcResourceElement CurrentShip;
        [NMS(Index = 215, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x6F0A8 */ public GcWonderRecord[] WonderCreatureRecords;
        [NMS(Index = 142)]
        /* 0x6F210 */ public GcInventoryContainer Chest10Inventory;
        [NMS(Index = 124)]
        /* 0x6F368 */ public GcInventoryContainer Chest1Inventory;
        [NMS(Index = 126)]
        /* 0x6F4C0 */ public GcInventoryContainer Chest2Inventory;
        [NMS(Index = 128)]
        /* 0x6F618 */ public GcInventoryContainer Chest3Inventory;
        [NMS(Index = 130)]
        /* 0x6F770 */ public GcInventoryContainer Chest4Inventory;
        [NMS(Index = 132)]
        /* 0x6F8C8 */ public GcInventoryContainer Chest5Inventory;
        [NMS(Index = 134)]
        /* 0x6FA20 */ public GcInventoryContainer Chest6Inventory;
        [NMS(Index = 136)]
        /* 0x6FB78 */ public GcInventoryContainer Chest7Inventory;
        [NMS(Index = 138)]
        /* 0x6FCD0 */ public GcInventoryContainer Chest8Inventory;
        [NMS(Index = 140)]
        /* 0x6FE28 */ public GcInventoryContainer Chest9Inventory;
        [NMS(Index = 146)]
        /* 0x6FF80 */ public GcInventoryContainer ChestMagic2Inventory;
        [NMS(Index = 144)]
        /* 0x700D8 */ public GcInventoryContainer ChestMagicInventory;
        [NMS(Index = 148)]
        /* 0x70230 */ public GcInventoryContainer CookingIngredientsInventory;
        [NMS(Index = 106)]
        /* 0x70388 */ public GcInventoryContainer FreighterInventory;
        [NMS(Index = 108)]
        /* 0x704E0 */ public GcInventoryContainer FreighterInventory_Cargo;
        [NMS(Index = 107)]
        /* 0x70638 */ public GcInventoryContainer FreighterInventory_TechOnly;
        [NMS(Index = 18)]
        /* 0x70790 */ public GcInventoryContainer GraveInventory;
        [NMS(Index = 6)]
        /* 0x708E8 */ public GcInventoryContainer Inventory;
        [NMS(Index = 8)]
        /* 0x70A40 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 7)]
        /* 0x70B98 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 150)]
        /* 0x70CF0 */ public GcInventoryContainer RocketLockerInventory;
        [NMS(Index = 9)]
        /* 0x70E48 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 10)]
        /* 0x70FA0 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 218, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x710F8 */ public GcWonderRecord[] WonderTreasureRecords;
        [NMS(Index = 220, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x71230 */ public GcWonderRecord[] WonderCustomRecords;
        [NMS(Index = 62, Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x71350 */ public GcInteractionBuffer[] StoredInteractions;
        [NMS(Index = 214, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x71458 */ public GcWonderRecord[] WonderPlanetRecords;
        [NMS(Index = 219, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x71560 */ public GcWonderRecord[] WonderWeirdBasePartRecords;
        [NMS(Index = 86, Size = 0x10)]
        /* 0x71668 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 174, Size = 0x3)]
        /* 0x71768 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Index = 216, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x71840 */ public GcWonderRecord[] WonderFloraRecords;
        [NMS(Index = 217, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x71900 */ public GcWonderRecord[] WonderMineralRecords;
        [NMS(Index = 28)]
        /* 0x719C0 */ public GcExactResource CurrentWeapon;
        [NMS(Index = 211, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x71A50 */ public GcStoryPageSeenDataArray[] SeenStories;
        [NMS(Index = 222, Size = 0x4, EnumType = typeof(GcSynchronisedBufferType.SyncBufferTypeEnum))]
        /* 0x71AE0 */ public GcSyncBufferSaveDataArray[] SyncBuffersData;
        [NMS(Index = 164)]
        /* 0x71B20 */ public GcPortalSaveData VisitedPortal;
        [NMS(Index = 141)]
        /* 0x71B40 */ public GcInventoryLayout Chest10Layout;
        [NMS(Index = 123)]
        /* 0x71B58 */ public GcInventoryLayout Chest1Layout;
        [NMS(Index = 125)]
        /* 0x71B70 */ public GcInventoryLayout Chest2Layout;
        [NMS(Index = 127)]
        /* 0x71B88 */ public GcInventoryLayout Chest3Layout;
        [NMS(Index = 129)]
        /* 0x71BA0 */ public GcInventoryLayout Chest4Layout;
        [NMS(Index = 131)]
        /* 0x71BB8 */ public GcInventoryLayout Chest5Layout;
        [NMS(Index = 133)]
        /* 0x71BD0 */ public GcInventoryLayout Chest6Layout;
        [NMS(Index = 135)]
        /* 0x71BE8 */ public GcInventoryLayout Chest7Layout;
        [NMS(Index = 137)]
        /* 0x71C00 */ public GcInventoryLayout Chest8Layout;
        [NMS(Index = 139)]
        /* 0x71C18 */ public GcInventoryLayout Chest9Layout;
        [NMS(Index = 145)]
        /* 0x71C30 */ public GcInventoryLayout ChestMagic2Layout;
        [NMS(Index = 143)]
        /* 0x71C48 */ public GcInventoryLayout ChestMagicLayout;
        [NMS(Index = 147)]
        /* 0x71C60 */ public GcInventoryLayout CookingIngredientsLayout;
        [NMS(Index = 105)]
        /* 0x71C78 */ public GcInventoryLayout FreighterCargoLayout;
        [NMS(Index = 104)]
        /* 0x71C90 */ public GcInventoryLayout FreighterLayout;
        [NMS(Index = 149)]
        /* 0x71CA8 */ public GcInventoryLayout RocketLockerLayout;
        [NMS(Index = 25)]
        /* 0x71CC0 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 26)]
        /* 0x71CD8 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 201)]
        /* 0x71CF0 */ public NMSString0x10 BannerTitleId;
        [NMS(Index = 118)]
        /* 0x71D00 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Index = 102)]
        /* 0x71D10 */ public GcSeed CurrentFreighterHomeSystemSeed;
        [NMS(Index = 37)]
        /* 0x71D20 */ public NMSString0x10 CurrentMissionID;
        [NMS(Index = 180)]
        /* 0x71D30 */ public List<ulong> ExpeditionSeedsSelectedToday;
        [NMS(Index = 179)]
        /* 0x71D40 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        [NMS(Index = 178)]
        /* 0x71D50 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        [NMS(Index = 177)]
        /* 0x71D60 */ public GcSeed FleetSeed;
        [NMS(Index = 176)]
        /* 0x71D70 */ public NMSString0x10 FreighterEngineEffect;
        [NMS(Index = 225)]
        /* 0x71D80 */ public List<GcGalaxyWaypoint> GalaxyWaypoints;
        [NMS(Index = 74)]
        /* 0x71D90 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Index = 175)]
        /* 0x71DA0 */ public NMSString0x10 JetpackEffect;
        [NMS(Index = 30)]
        /* 0x71DB0 */ public List<NMSString0x10> KnownProducts;
        [NMS(Index = 32)]
        /* 0x71DC0 */ public List<NMSString0x20A> KnownRefinerRecipes;
        [NMS(Index = 31)]
        /* 0x71DD0 */ public List<NMSString0x10> KnownSpecials;
        [NMS(Index = 29)]
        /* 0x71DE0 */ public List<NMSString0x10> KnownTech;
        [NMS(Index = 34)]
        /* 0x71DF0 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        [NMS(Index = 33)]
        /* 0x71E00 */ public List<GcWordKnowledge> KnownWords;
        [NMS(Index = 163)]
        /* 0x71E10 */ public List<GcPortalSaveData> LastPortal;
        [NMS(Index = 63)]
        /* 0x71E20 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        [NMS(Index = 55)]
        /* 0x71E30 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Index = 35)]
        /* 0x71E40 */ public List<GcPlayerMissionProgress> MissionProgress;
        [NMS(Index = 42)]
        /* 0x71E50 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Index = 56)]
        /* 0x71E60 */ public List<GcScanEventSave> NewMPMarkerStack;
        [NMS(Index = 121)]
        /* 0x71E70 */ public List<GcPersistentBase> PersistentPlayerBases;
        [NMS(Index = 64)]
        /* 0x71E80 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        [NMS(Index = 39)]
        /* 0x71E90 */ public NMSString0x10 PreviousMissionID;
        [NMS(Index = 207)]
        /* 0x71EA0 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Index = 205)]
        /* 0x71EB0 */ public List<NMSString0x10> RedeemedSeasonRewards;
        [NMS(Index = 206)]
        /* 0x71EC0 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Index = 224)]
        /* 0x71ED0 */ public List<GcMaintenanceContainer> RefinerBufferData;
        [NMS(Index = 223)]
        /* 0x71EE0 */ public List<GcMaintenanceSaveKey> RefinerBufferKeys;
        [NMS(Index = 186)]
        /* 0x71EF0 */ public List<GcRepairTechData> RepairTechBuffer;
        [NMS(Index = 73)]
        /* 0x71F00 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        [NMS(Index = 117)]
        /* 0x71F10 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        [NMS(Index = 60)]
        /* 0x71F20 */ public List<GcPlayerStatsGroup> Stats;
        [NMS(Index = 57)]
        /* 0x71F30 */ public List<Vector3f> SurveyedEventPositions;
        [NMS(Index = 61)]
        /* 0x71F40 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Index = 122)]
        /* 0x71F50 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Index = 162)]
        /* 0x71F60 */ public List<GcTradingSupplyData> TradingSupplyData;
        [NMS(Index = 84)]
        /* 0x71F70 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Index = 77)]
        /* 0x71F80 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        [NMS(Index = 65)]
        /* 0x71F90 */ public List<ulong> VisitedSystems;
        [NMS(Index = 11)]
        /* 0x71FA0 */ public List<GcInWorldUIScreenData> WristScreenData;
        [NMS(Index = 90)]
        /* 0x71FB0 */ public ulong ActiveSpaceBattleUA;
        [NMS(Index = 38)]
        /* 0x71FB8 */ public ulong CurrentMissionSeed;
        [NMS(Index = 109)]
        /* 0x71FC0 */ public ulong FreighterLastSpawnTime;
        [NMS(Index = 100)]
        /* 0x71FC8 */ public ulong HazardTimeAlive;
        [NMS(Index = 59)]
        /* 0x71FD0 */ public ulong LastCheckedForStatResetsTime;
        [NMS(Index = 181)]
        /* 0x71FD8 */ public ulong LastKnownDay;
        [NMS(Index = 189)]
        /* 0x71FE0 */ public ulong LastUABeforePortalWarp;
        [NMS(Index = 94)]
        /* 0x71FE8 */ public ulong MiniStationUA;
        [NMS(Index = 183)]
        /* 0x71FF0 */ public ulong MultiplayerLobbyID;
        [NMS(Index = 187)]
        /* 0x71FF8 */ public ulong MultiplayerPrivileges;
        [NMS(Index = 40)]
        /* 0x72000 */ public ulong PreviousMissionSeed;
        [NMS(Index = 190)]
        /* 0x72008 */ public ulong StoryPortalSeed;
        [NMS(Index = 182)]
        /* 0x72010 */ public ulong SunTimer;
        [NMS(Index = 54)]
        /* 0x72018 */ public ulong TimeAlive;
        [NMS(Index = 92)]
        /* 0x72020 */ public ulong TimeLastMiniStation;
        [NMS(Index = 88)]
        /* 0x72028 */ public ulong TimeLastSpaceBattle;
        [NMS(Index = 5)]
        /* 0x72030 */ public ulong TimeStamp;
        [NMS(Index = 72, Size = 0x8C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x72038 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        [NMS(Index = 221, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x73A78 */ public GcWonderRecordCustomData[] WonderCustomRecordsExtraData;
        [NMS(Index = 79, Size = 0xB)]
        /* 0x73DA8 */ public GcUniverseAddressData[] CompletedAtlasAddresses;
        [NMS(Index = 76, Size = 0xB)]
        /* 0x73EB0 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        [NMS(Index = 75, Size = 0xA)]
        /* 0x73FB8 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Index = 4)]
        /* 0x740A8 */ public GcDifficultyStateData DifficultyState;
        [NMS(Index = 110)]
        /* 0x7410C */ public GcUniverseAddressData FreighterUniverseAddress;
        [NMS(Index = 96)]
        /* 0x74124 */ public GcUniverseAddressData GameStartAddress1;
        [NMS(Index = 97)]
        /* 0x7413C */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Index = 21)]
        /* 0x74154 */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Index = 66, Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x7416C */ public float[] Hazard;
        [NMS(Index = 184)]
        /* 0x74184 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Index = 194)]
        /* 0x7419C */ public GcUniverseAddressData NexusUniverseAddress;
        [NMS(Index = 1)]
        /* 0x741B4 */ public GcUniverseAddressData PreviousUniverseAddress;
        [NMS(Index = 0)]
        /* 0x741CC */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 13)]
        /* 0x741E4 */ public int ActiveMultioolIndex;
        [NMS(Index = 91)]
        /* 0x741E8 */ public int ActiveSpaceBattleLevel;
        [NMS(Index = 200)]
        /* 0x741EC */ public int BannerBackgroundColour;
        [NMS(Index = 198)]
        /* 0x741F0 */ public int BannerIcon;
        [NMS(Index = 199)]
        /* 0x741F4 */ public int BannerMainColour;
        [NMS(Index = 67)]
        /* 0x741F8 */ public int BoltAmmo;
        [NMS(Index = 50)]
        /* 0x741FC */ public int Energy;
        [NMS(Index = 46)]
        /* 0x74200 */ public int Health;
        [NMS(Index = 2)]
        /* 0x74204 */ public int HomeRealityIteration;
        [NMS(Index = 165)]
        /* 0x74208 */ public int KnownPortalRunes;
        [NMS(Index = 70)]
        /* 0x7420C */ public int LaserAmmo;
        [NMS(Index = 41)]
        /* 0x74210 */ public int MissionVersion;
        [NMS(Index = 52)]
        /* 0x74214 */ public int Nanites;
        [NMS(Index = 58)]
        /* 0x74218 */ public int NextSurveyedEventPositionIndex;
        [NMS(Index = 36)]
        /* 0x7421C */ public int PostMissionIndex;
        [NMS(Index = 87)]
        /* 0x74220 */ public int PrimaryPlanet;
        [NMS(Index = 155)]
        /* 0x74224 */ public int PrimaryShip;
        [NMS(Index = 153)]
        /* 0x74228 */ public int PrimaryVehicle;
        [NMS(Index = 81)]
        /* 0x7422C */ public int ProcTechIndex;
        [NMS(Index = 80)]
        /* 0x74230 */ public int ProgressionLevel;
        [NMS(Index = 69)]
        /* 0x74234 */ public int PulseAmmo;
        [NMS(Index = 68)]
        /* 0x74238 */ public int ScatterAmmo;
        [NMS(Index = 209)]
        /* 0x7423C */ public int SettlementStateRingBufferIndexV2;
        [NMS(Index = 48)]
        /* 0x74240 */ public int Shield;
        [NMS(Index = 47)]
        /* 0x74244 */ public int ShipHealth;
        [NMS(Index = 49)]
        /* 0x74248 */ public int ShipShield;
        [NMS(Index = 53)]
        /* 0x7424C */ public int Specials;
        [NMS(Index = 170)]
        /* 0x74250 */ public GcPlayerWeapons StartingPrimaryWeapon;
        [NMS(Index = 213)]
        /* 0x74254 */ public int StartingSeasonNumber;
        [NMS(Index = 171)]
        /* 0x74258 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Index = 202)]
        /* 0x7425C */ public int TelemetryUploadVersion;
        [NMS(Index = 161)]
        /* 0x74260 */ public int TradingSupplyDataIndex;
        [NMS(Index = 51)]
        /* 0x74264 */ public int Units;
        [NMS(Index = 203)]
        /* 0x74268 */ public float VRCameraOffset;
        [NMS(Index = 93)]
        /* 0x7426C */ public int WarpsLastMiniStation;
        [NMS(Index = 89)]
        /* 0x74270 */ public int WarpsLastSpaceBattle;
        [NMS(Index = 191)]
        /* 0x74274 */ public ushort ShopNumber;
        [NMS(Index = 192)]
        /* 0x74276 */ public ushort ShopTier;
        [NMS(Index = 3)]
        /* 0x74278 */ public NMSString0x80 SaveSummary;
        [NMS(Index = 158)]
        /* 0x742F8 */ public NMSString0x20 PlayerFreighterName;
        [NMS(Index = 17, Size = 0x12)]
        /* 0x74318 */ public bool[] UnlockedPetSlots;
        [NMS(Index = 98, Size = 0x10)]
        /* 0x7432A */ public bool[] GalacticMapRequests;
        [NMS(Index = 173, Size = 0xC)]
        /* 0x7433A */ public bool[] ShipUsesLegacyColours;
        [NMS(Index = 115, Size = 0x4)]
        /* 0x74346 */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Index = 212)]
        /* 0x7434A */ public bool BuildersKnown;
        [NMS(Index = 78)]
        /* 0x7434B */ public bool FirstAtlasStationDiscovered;
        [NMS(Index = 111)]
        /* 0x7434C */ public bool FreighterDismissed;
        [NMS(Index = 193)]
        /* 0x7434D */ public bool HasAccessToNexus;
        [NMS(Index = 82)]
        /* 0x7434E */ public bool IsNew;
        [NMS(Index = 156)]
        /* 0x7434F */ public bool MultiShipEnabled;
        [NMS(Index = 210)]
        /* 0x74350 */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Index = 166)]
        /* 0x74351 */ public bool OnOtherSideOfPortal;
        [NMS(Index = 204)]
        /* 0x74352 */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Index = 101)]
        /* 0x74353 */ public bool RevealBlackHoles;
        [NMS(Index = 160)]
        /* 0x74354 */ public bool ShipNeedsTerrainPositioning;
        [NMS(Index = 20)]
        /* 0x74355 */ public bool SpaceGrave;
        [NMS(Index = 19)]
        /* 0x74356 */ public bool SpawnGrave;
        [NMS(Index = 83)]
        /* 0x74357 */ public bool UseSmallerBlackholeJumps;
        [NMS(Index = 157)]
        /* 0x74358 */ public bool VehicleAIControlEnabled;
    }
}
