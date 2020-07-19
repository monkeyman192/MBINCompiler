using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x29F80, GUID = 0x65813716076EAFD1, NameHash = 0x6C4510BB243EFA64)]
    public class GcPlayerStateData : NMSTemplate
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;
        /* 0x00018 */ public int HomeRealityIteration;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0001C */ public byte[] Padding1C;

        /* 0x00020 */ public GcInventoryContainer Inventory;
        /* 0x00180 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x002E0 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x00440 */ public GcInventoryContainer ShipInventory;
        /* 0x005A0 */ public GcInventoryContainer WeaponInventory;
        [NMS(Size = 0x3)]
        /* 0x00700 */ public GcMultitoolData[] MultiTools;
        /* 0x00C40 */ public int ActiveMultioolIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00C44 */ public byte[] PaddingC44;
        /* 0x00C48 */ public GcInventoryContainer GraveInventory;

        /* 0x00DA8 */ public bool SpawnGrave;
        /* 0x00DA9 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x00DAA */ public byte[] PaddingDAA;

        /* 0x00DAC */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x00DC4 */ public byte[] PaddingDC4;

        /* 0x00DD0 */ public Vector4f GravePosition;
        /* 0x00DE0 */ public Vector4f GraveMatrixLookAt;
        /* 0x00DF0 */ public Vector4f GraveMatrixUp;
        /* 0x00E00 */ public GcInventoryLayout ShipLayout;
        /* 0x00E20 */ public GcInventoryLayout WeaponLayout;
        /* 0x00E40 */ public GcResourceElement CurrentShip;
        /* 0x010E8 */ public GcExactResource CurrentWeapon;
        /* 0x01178 */ public List<NMSString0x10> KnownTech;
        /* 0x01188 */ public List<NMSString0x10> KnownProducts;
        /* 0x01198 */ public List<NMSString0x10> KnownSpecials;
        /* 0x011A8 */ public List<NMSString0x20> KnownRefinerRecipes;
        /* 0x011B8 */ public List<GcWordKnowledge> KnownWords;
        /* 0x011C8 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x011D8 */ public List<GcPlayerMissionProgress> MissionProgress;

        /* 0x011E8 */ public int PostMissionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x011EC */ public byte[] Padding11EC;
        [NMS(Size = 0x10)]
        /* 0x011F0 */ public string CurrentMissionID;
        /* 0x01200 */ public ulong CurrentMissionSeed;
        [NMS(Size = 0x10)]
        /* 0x01208 */ public string PreviousMissionID;
        /* 0x01218 */ public ulong PreviousMissionSeed;
        /* 0x01220 */ public int MissionVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x01224 */ public byte[] Padding1224;
        /* 0x01228 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x01238 */ public byte[] Padding1238;
        /* 0x01240 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x01260 */ public GcInteractionData HoloScepticInteraction;
        /* 0x01280 */ public GcInteractionData HoloNooneInteraction;
        /* 0x012A0 */ public int Health;
		/* 0x012A4 */ public int ShipHealth;
        /* 0x012A8 */ public int Shield;
		/* 0x012AC */ public int ShipShield;
		/* 0x012B0 */ public int Energy;
        /* 0x012B4 */ public int Units;
        /* 0x012B8 */ public int Nanites;
        /* 0x012BC */ public int Specials;
        /* 0x012C0 */ public bool ThirdPersonShip;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x012C1 */ public byte[] Padding12C1;
        /* 0x012C8 */ public ulong TimeAlive;
        /* 0x012D0 */ public ulong TotalPlayTime;

        /* 0x012D8 */ public List<GcScanEventSave> MarkerStack;
        /* 0x012E8 */ public List<GcScanEventSave> NewMPMarkerStack;

        /* 0x012F8 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x01308 */ public List<GcTelemetryStat> TelemetryStats;

        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InterationBufferTypeEnum))]
        /* 0x01318 */ public GcInteractionBuffer[] StoredInteractions;

        /* 0x01420 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x01430 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x01440 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...

        [NMS(Size = 6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x01450 */ public float[] Hazard;

        /* 0x01468 */ public int BoltAmmo;
        /* 0x0146C */ public int ScatterAmmo;
        /* 0x01470 */ public int PulseAmmo;
        /* 0x01474 */ public int LaserAmmo;

        /* 0x01480 */ public Vector4f FirstSpawnPosition;

        [NMS(Size = 0x6C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x01490 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        /* 0x02210 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x02220 */ public List<NMSString0x20> InteractionProgressTable;

        [NMS(Size = 0xA)]
        /* 0x02230 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x02320 */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        /* 0x02428 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;

        /* 0x02438 */ public bool FirstAtlasStationDiscovered;
        /* 0x02439 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0243C */ public int ProgressionLevel;
        /* 0x02440 */ public int ProcTechIndex;
        /* 0x02444 */ public bool IsNew;
        /* 0x02445 */ public bool UseSmallerBlackholeJumps;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x02446 */ public byte[] Padding2446;

        /* 0x02448 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x10)]
        /* 0x02460 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x02560 */ public GcSeed[] PlanetSeeds;

        /* 0x02660 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02664 */ public byte[] Padding2664;

        /* 0x02668 */ public ulong TimeLastSpaceBattle;
        /* 0x02670 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02674 */ public byte[] Padding2674;

        /* 0x02678 */ public ulong ActiveSpaceBattleUA;
        /* 0x02680 */ public ulong TimeLastMiniStation;
        /* 0x02688 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x0268C */ public byte[] Padding268C;

        /* 0x02690 */ public ulong MiniStationUA;
        [NMS(Size = 8, Ignore = true)]
        /* 0x02698 */ public byte[] Padding2698;
        /* 0x026A0 */ public Vector4f AnomalyPositionOverride;

        /* 0x026B0 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x026C8 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x026E0 */ public bool[] GalacticMapRequests;

        /* 0x026F0 */ public Vector4f FirstShipPosition;

        /* 0x02700 */ public ulong HazardTimeAlive;

        /* 0x02708 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x02709 */ public byte[] Padding2709;
        /* 0x02710 */ public GcSeed CurrentFreighterHomeSystemSeed;

        /* 0x02720 */ public GcResourceElement CurrentFreighter;
        /* 0x029C8 */ public GcInventoryLayout FreighterLayout;
        /* 0x029E8 */ public GcInventoryContainer FreighterInventory;
        /* 0x02B48 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x02CA8 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x02CC0 */ public Vector3f FreighterMatrixAt;
        /* 0x02CD0 */ public Vector3f FreighterMatrixUp;
        /* 0x02CE0 */ public Vector3f FreighterMatrixPos;
        /* 0x02CF0 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x02D00 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x21FC0 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x22E20 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x22E30 */ public List<GcTeleportEndpoint> TeleportEndpoints;

        /* 0x22E40 */ public GcInventoryLayout Chest1Layout;
        /* 0x22E60 */ public GcInventoryContainer Chest1Inventory;
        /* 0x22FC0 */ public GcInventoryLayout Chest2Layout;
        /* 0x22FE0 */ public GcInventoryContainer Chest2Inventory;
        /* 0x23140 */ public GcInventoryLayout Chest3Layout;
        /* 0x23160 */ public GcInventoryContainer Chest3Inventory;
        /* 0x232C0 */ public GcInventoryLayout Chest4Layout;
        /* 0x232E0 */ public GcInventoryContainer Chest4Inventory;
        /* 0x23440 */ public GcInventoryLayout Chest5Layout;
        /* 0x23460 */ public GcInventoryContainer Chest5Inventory;
        /* 0x235C0 */ public GcInventoryLayout Chest6Layout;
        /* 0x235E0 */ public GcInventoryContainer Chest6Inventory;
        /* 0x23740 */ public GcInventoryLayout Chest7Layout;
        /* 0x23760 */ public GcInventoryContainer Chest7Inventory;
        /* 0x238C0 */ public GcInventoryLayout Chest8Layout;
        /* 0x238E0 */ public GcInventoryContainer Chest8Inventory;
        /* 0x23A40 */ public GcInventoryLayout Chest9Layout;
        /* 0x23A60 */ public GcInventoryContainer Chest9Inventory;
        /* 0x23BC0 */ public GcInventoryLayout Chest10Layout;
        /* 0x23BE0 */ public GcInventoryContainer Chest10Inventory;
        /* 0x23D40 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x23D60 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x23EC0 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x23EE0 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x24040 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x24060 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x241C0 */ public GcResourceElement CurrentFreighterNPC;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x24468 */ public byte[] Padding24468;

        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x24470 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x26D20 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x26D24 */ public byte[] Padding26D24;
        [NMS(Size = 0x6)]
        /* 0x26D30 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x29010 */ public int PrimaryShip;

        /* 0x29014 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x29015 */ public string PlayerFreighterName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x29035 */ public byte[] Padding29035;
        /* 0x29040 */ public Vector4f StartGameShipPosition;
        /* 0x29050 */ public bool ShipNeedsTerrainPositioning;
        /* 0x29054 */ public int TradingSupplyDataIndex;
        /* 0x29058 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x29068 */ public List<GcPortalData> LastPortal;
        /* 0x29078 */ public GcPortalSaveData VisitedPortal;
        /* 0x29090 */ public int KnownPortalRunes;
        /* 0x29094 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x29095 */ public byte[] Padding29095;
        /* 0x290A0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x29130 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x29140 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x29150 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x29154 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x10, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x29158 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x296D8 */ public bool[] ShipUsesLegacyColours;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x296DE */ public byte[] Padding296DE;

        [NMS(Size = 0x3)]
        /* 0x296E0 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Size = 0x10)]
        /* 0x297B8 */ public string JetpackEffect;
        /* 0x297C8 */ public GcSeed FleetSeed;
        /* 0x297D8 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x297E8 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x297F8 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x29808 */ public ulong LastKnownDay;
        /* 0x29810 */ public ulong SunTimer;
        /* 0x29818 */ public ulong MultiplayerLobbyID;
        /* 0x29820 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x29838 */ public byte[] Padding29838;
        /* 0x29840 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x298F0 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x29900 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x29908 */ public GcHotActionsSaveData[] HotActions;
        /* 0x29DB8 */ public ulong LastUABeforePortalWarp;
        /* 0x29DC0 */ public ulong StoryPortalSeed;
        /* 0x29DC8 */ public ushort ShopNumber;
        /* 0x29DCA */ public ushort ShopTier;
        /* 0x29DCC */ public bool HasAccessToNexus;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x29DCD */ public byte[] Padding29DCD;
        /* 0x29DD0 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x29DF0 */ public Vector3f NexusMatrixAt;
        /* 0x29E00 */ public Vector3f NexusMatrixUp;
        /* 0x29E10 */ public Vector3f NexusMatrixPos;
        /* 0x29E20 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x29E60 */ public int BannerIcon;
        /* 0x29E64 */ public int BannerMainColour;
        /* 0x29E68 */ public int BannerBackgroundColour;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x29E6C */ public byte[] Padding29E6C;
        [NMS(Size = 0x10)]
        /* 0x29E70 */ public string BannerTitleId;
        /* 0x29E80 */ public int TelemetryUploadVersion;
        /* 0x29E84 */ public bool UsesThirdPersonVehicleCam;
        /* 0x29E88 */ public float VRCameraOffset;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x29E8C */ public byte[] Padding29E8C;
        /* 0x29E90 */ public GcSeasonalGameModeData SeasonalData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x29F78 */ public byte[] EndPadding;
    }
}
