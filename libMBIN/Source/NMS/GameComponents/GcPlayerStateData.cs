using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2DD30, GUID = 0x5C97DAEA9F15E300, NameHash = 0x6C4510BB243EFA64)]
    public class GcPlayerStateData : NMSTemplate
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;
        /* 0x00018 */ public GcUniverseAddressData PreviousUniverseAddress;
        /* 0x00030 */ public int HomeRealityIteration;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00034 */ public byte[] Padding34;
        /* 0x00038 */ public GcInventoryContainer Inventory;
        /* 0x00198 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x002F8 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x00458 */ public GcInventoryContainer ShipInventory;
        /* 0x005B8 */ public GcInventoryContainer WeaponInventory;
        [NMS(Size = 0x3)]
        /* 0x00718 */ public GcMultitoolData[] MultiTools;
        /* 0x00C58 */ public int ActiveMultioolIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00C5C */ public byte[] PaddingC5C;
        /* 0x006C0 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Size = 0x6)]
        /* 0x02668 */ public GcPetData[] Pets;
        [NMS(Size = 0x6)]
        /* 0x03238 */ public GcPetData[] Eggs;
        [NMS(Size = 0x6)]
        /* 0x03E08 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Size = 0x6)]
        /* 0x04438 */ public bool[] UnlockedPetSlots;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x0443E */ public byte[] Padding443E;
        /* 0x04440 */ public GcInventoryContainer GraveInventory;
        /* 0x045A0 */ public bool SpawnGrave;
        /* 0x045A1 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x045A2 */ public byte[] Padding45A2;
        /* 0x045A4 */ public GcUniverseAddressData GraveUniverseAddress;
        /* 0x045C0 */ public Vector4f GravePosition;
        /* 0x045D0 */ public Vector4f GraveMatrixLookAt;
        /* 0x045E0 */ public Vector4f GraveMatrixUp;
        /* 0x045F0 */ public GcInventoryLayout ShipLayout;
        /* 0x04610 */ public GcInventoryLayout WeaponLayout;
        /* 0x04630 */ public GcResourceElement CurrentShip;
        /* 0x048D8 */ public GcExactResource CurrentWeapon;
        /* 0x04968 */ public List<NMSString0x10> KnownTech;
        /* 0x04978 */ public List<NMSString0x10> KnownProducts;
        /* 0x04988 */ public List<NMSString0x10> KnownSpecials;
        /* 0x04998 */ public List<NMSString0x20A> KnownRefinerRecipes;
        /* 0x049A8 */ public List<GcWordKnowledge> KnownWords;
        /* 0x049B8 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x049C8 */ public List<GcPlayerMissionProgress> MissionProgress;
        /* 0x049D8 */ public int PostMissionIndex;
        /* 0x049E0 */ public NMSString0x10 CurrentMissionID;
        /* 0x049F0 */ public ulong CurrentMissionSeed;
        /* 0x049F8 */ public NMSString0x10 PreviousMissionID;
        /* 0x04A08 */ public ulong PreviousMissionSeed;
        /* 0x04A10 */ public int MissionVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04A14 */ public byte[] Padding4A14;
        /* 0x04A18 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x04A28 */ public byte[] Padding4A28;
        /* 0x04A30 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x04A50 */ public GcInteractionData HoloScepticInteraction;
        /* 0x04A70 */ public GcInteractionData HoloNooneInteraction;
        /* 0x04A90 */ public int Health;
		/* 0x04A94 */ public int ShipHealth;
        /* 0x04A98 */ public int Shield;
		/* 0x04A9C */ public int ShipShield;
		/* 0x04AA0 */ public int Energy;
        /* 0x04AA4 */ public int Units;
        /* 0x04AA8 */ public int Nanites;
        /* 0x04AAC */ public int Specials;
        /* 0x04AB0 */ public bool ThirdPersonShip;
        /* 0x04AB8 */ public ulong TimeAlive;
        /* 0x04AC0 */ public ulong TotalPlayTime;
        /* 0x04AC8 */ public List<GcScanEventSave> MarkerStack;
        /* 0x04AD8 */ public List<GcScanEventSave> NewMPMarkerStack;
        /* 0x04AE8 */ public List<Vector4f> SurveyedEventPositions;
        /* 0x04AF8 */ public int NextSurveyedEventPositionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04AFC */ public byte[] Padding4AFC;
        /* 0x04B00 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x04B10 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InterationBufferTypeEnum))]
        /* 0x04B20 */ public GcInteractionBuffer[] StoredInteractions;
        /* 0x04C28 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x04C38 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x04C48 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...
        [NMS(Size = 6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x04C58 */ public float[] Hazard;
        /* 0x04C70 */ public int BoltAmmo;
        /* 0x04C74 */ public int ScatterAmmo;
        /* 0x04C78 */ public int PulseAmmo;
        /* 0x04C7C */ public int LaserAmmo;
        /* 0x04C80 */ public Vector4f FirstSpawnPosition;
        [NMS(Size = 0x75, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x04C90 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x05B30 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x05B40 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x05B50 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x05C40 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x05D48 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x05D58 */ public bool FirstAtlasStationDiscovered;
        /* 0x05D59 */ public bool UsesThirdPersonCharacterCam;
        /* 0x05D5C */ public int ProgressionLevel;
        /* 0x05D60 */ public int ProcTechIndex;
        /* 0x05D64 */ public bool IsNew;
        /* 0x05D65 */ public bool UseSmallerBlackholeJumps;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x05D66 */ public byte[] Padding5D66;
        /* 0x05D68 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x05D80 */ public Vector4f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x05E80 */ public GcSeed[] PlanetSeeds;
        /* 0x05F80 */ public int PrimaryPlanet;
        /* 0x05F88 */ public ulong TimeLastSpaceBattle;
        /* 0x05F90 */ public int WarpsLastSpaceBattle;
        /* 0x05F98 */ public ulong ActiveSpaceBattleUA;
        /* 0x05FA0 */ public ulong TimeLastMiniStation;
        /* 0x05FA8 */ public int WarpsLastMiniStation;
        /* 0x05FB0 */ public ulong MiniStationUA;
        /* 0x05FC0 */ public Vector4f AnomalyPositionOverride;
        /* 0x05FD0 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x05FE8 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x06000 */ public bool[] GalacticMapRequests;
        /* 0x06010 */ public Vector4f FirstShipPosition;
        /* 0x06020 */ public ulong HazardTimeAlive;
        /* 0x06028 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x06029 */ public byte[] Padding6029;
        /* 0x06030 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x06040 */ public GcResourceElement CurrentFreighter;
        /* 0x062E8 */ public GcInventoryLayout FreighterLayout;
        /* 0x06308 */ public GcInventoryContainer FreighterInventory;
        /* 0x06468 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x065C8 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x065E0 */ public Vector3f FreighterMatrixAt;
        /* 0x065F0 */ public Vector3f FreighterMatrixUp;
        /* 0x06600 */ public Vector3f FreighterMatrixPos;
        /* 0x06610 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x06620 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x258E0 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x26740 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x26750 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x26760 */ public GcInventoryLayout Chest1Layout;
        /* 0x26780 */ public GcInventoryContainer Chest1Inventory;
        /* 0x268E0 */ public GcInventoryLayout Chest2Layout;
        /* 0x26900 */ public GcInventoryContainer Chest2Inventory;
        /* 0x26A60 */ public GcInventoryLayout Chest3Layout;
        /* 0x26A80 */ public GcInventoryContainer Chest3Inventory;
        /* 0x26BE0 */ public GcInventoryLayout Chest4Layout;
        /* 0x26C00 */ public GcInventoryContainer Chest4Inventory;
        /* 0x26D60 */ public GcInventoryLayout Chest5Layout;
        /* 0x26D80 */ public GcInventoryContainer Chest5Inventory;
        /* 0x26EE0 */ public GcInventoryLayout Chest6Layout;
        /* 0x26F00 */ public GcInventoryContainer Chest6Inventory;
        /* 0x27060 */ public GcInventoryLayout Chest7Layout;
        /* 0x27080 */ public GcInventoryContainer Chest7Inventory;
        /* 0x271E0 */ public GcInventoryLayout Chest8Layout;
        /* 0x27200 */ public GcInventoryContainer Chest8Inventory;
        /* 0x27360 */ public GcInventoryLayout Chest9Layout;
        /* 0x27380 */ public GcInventoryContainer Chest9Inventory;
        /* 0x274E0 */ public GcInventoryLayout Chest10Layout;
        /* 0x27500 */ public GcInventoryContainer Chest10Inventory;
        /* 0x27660 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x27680 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x277E0 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x27800 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x27960 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x27980 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x27AE0 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x27D88 */ public byte[] Padding27D88;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x27D90 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x2A640 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x2A644 */ public byte[] Padding2A644;
        [NMS(Size = 0x6)]
        /* 0x2A650 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x2C930 */ public int PrimaryShip;
        /* 0x2C934 */ public bool MultiShipEnabled;
        /* 0x2C935 */ public NMSString0x20 PlayerFreighterName;
        /* 0x2C960 */ public Vector4f StartGameShipPosition;
        /* 0x2C970 */ public bool ShipNeedsTerrainPositioning;
        /* 0x2C974 */ public int TradingSupplyDataIndex;
        /* 0x2C978 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x2C988 */ public List<GcPortalData> LastPortal;
        /* 0x2C998 */ public GcPortalSaveData VisitedPortal;
        /* 0x2C9B0 */ public int KnownPortalRunes;
        /* 0x2C9B4 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x2C9B5 */ public byte[] Padding2C9B5;
        /* 0x2C9C0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x2CA50 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x2CA60 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x2CA70 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x2CA74 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x11, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x2CA78 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x2D050 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x2D056 */ public byte[] Padding2D056;
        [NMS(Size = 0x3)]
        /* 0x2D058 */ public GcCharacterCustomisationData[] Outfits;
        /* 0x2D130 */ public NMSString0x10 JetpackEffect;
        /* 0x2D140 */ public GcSeed FleetSeed;
        /* 0x2D150 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x2D160 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x2D170 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x2D180 */ public ulong LastKnownDay;
        /* 0x2D188 */ public ulong SunTimer;
        /* 0x2D190 */ public ulong MultiplayerLobbyID;
        /* 0x2D198 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x2D1B0 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x2D260 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x2D270 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x2D278 */ public GcHotActionsSaveData[] HotActions;
        /* 0x2D728 */ public ulong LastUABeforePortalWarp;
        /* 0x2D730 */ public ulong StoryPortalSeed;
        /* 0x2D738 */ public ushort ShopNumber;
        /* 0x2D73A */ public ushort ShopTier;
        /* 0x2D73C */ public bool HasAccessToNexus;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x2D73D */ public byte[] Padding2D73D;
        /* 0x2D740 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x2D760 */ public Vector3f NexusMatrixAt;
        /* 0x2D770 */ public Vector3f NexusMatrixUp;
        /* 0x2D780 */ public Vector3f NexusMatrixPos;
        /* 0x2D790 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x2D7F0 */ public int BannerIcon;
        /* 0x2D7F4 */ public int BannerMainColour;
        /* 0x2D7F8 */ public int BannerBackgroundColour;
        /* 0x2D800 */ public NMSString0x10 BannerTitleId;
        /* 0x2D810 */ public int TelemetryUploadVersion;
        /* 0x2D814 */ public bool UsesThirdPersonVehicleCam;
        /* 0x2D818 */ public float VRCameraOffset;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2D81C */ public byte[] Padding2D81C;
        /* 0x2D820 */ public GcSeasonalGameModeData SeasonalData;
        /* 0x2DCB8 */ public GcSeasonStateData SeasonState;
        /* 0x2DD08 */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x2DD09 */ public byte[] Padding2DD09;
        /* 0x2DD10 */ public List<NMSString0x10> RedeemedSeasonRewards;
        /* 0x2DD20 */ public List<NMSString0x10> RedeemedTwitchRewards;
    }
}
