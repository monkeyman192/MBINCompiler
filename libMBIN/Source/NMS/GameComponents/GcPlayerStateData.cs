using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x26220, GUID = 0xF1FA910C4B15D651, NameHash = 0x6C4510BB243EFA64)]
    public class GcPlayerStateData : NMSTemplate
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;
        /* 0x00018 */ public int HomeRealityIteration;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0001C */ public byte[] Padding1C;

        /* 0x00020 */ public GcInventoryContainer Inventory;
        /* 0x00080 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x000E0 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x00140 */ public GcInventoryContainer ShipInventory;
        /* 0x001A0 */ public GcInventoryContainer WeaponInventory;
        /* 0x00200 */ public GcInventoryContainer GraveInventory;

        /* 0x00260 */ public bool SpawnGrave;
        /* 0x00261 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x00262 */ public byte[] Padding262;

        /* 0x00264 */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0027C */ public byte[] Padding27C;

        /* 0x00280 */ public Vector4f GravePosition;
        /* 0x00290 */ public Vector4f GraveMatrixLookAt;
        /* 0x002A0 */ public Vector4f GraveMatrixUp;
        /* 0x002B0 */ public GcInventoryLayout ShipLayout;
        /* 0x002D0 */ public GcInventoryLayout WeaponLayout;
        /* 0x002F0 */ public GcResourceElement CurrentShip;
        /* 0x00598 */ public GcExactResource CurrentWeapon;
        /* 0x00628 */ public List<NMSString0x10> KnownTech;
        /* 0x00638 */ public List<NMSString0x10> KnownProducts;
        /* 0x00648 */ public List<NMSString0x10> KnownSpecials;
        /* 0x00658 */ public List<NMSString0x20> KnownRefinerRecipes;
        /* 0x00668 */ public List<GcWordKnowledge> KnownWords;
        /* 0x00678 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x00688 */ public List<GcPlayerMissionProgress> MissionProgress;

        /* 0x00698 */ public int PostMissionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0069C */ public byte[] Padding69C;
        [NMS(Size = 0x10)]
        /* 0x006A0 */ public string CurrentMissionID;
        /* 0x006B0 */ public ulong CurrentMissionSeed;
        [NMS(Size = 0x10)]
        /* 0x006B8 */ public string PreviousMissionID;
        /* 0x006C8 */ public ulong PreviousMissionSeed;
        /* 0x006D0 */ public int MissionVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x006D4 */ public byte[] Padding6D4;
        /* 0x006D8 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x006E8 */ public byte[] Padding6E8;
        /* 0x006F0 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x00710 */ public GcInteractionData HoloScepticInteraction;
        /* 0x00700 */ public GcInteractionData HoloNooneInteraction;
        /* 0x00750 */ public int Health;
		/* 0x00754 */ public int ShipHealth;
        /* 0x00758 */ public int Shield;
		/* 0x0075C */ public int ShipShield;
		/* 0x00760 */ public int Energy;
        /* 0x00764 */ public int Units;
        /* 0x00768 */ public int Nanites;
        /* 0x0076C */ public int Specials;
        /* 0x00770 */ public bool ThirdPersonShip;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x00771 */ public byte[] Padding771;
        /* 0x00778 */ public ulong TimeAlive;
        /* 0x00780 */ public ulong TotalPlayTime;

        /* 0x00788 */ public List<GcScanEventSave> MarkerStack;
        /* 0x00798 */ public List<GcScanEventSave> NewMPMarkerStack;

        /* 0x007A8 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x007B8 */ public List<GcTelemetryStat> TelemetryStats;

        [NMS(Size = 0xA, EnumType = typeof(GcInteractionBufferType.InterationBufferTypeEnum))]
        /* 0x007C8 */ public GcInteractionBuffer[] StoredInteractions;

        /* 0x00868 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x00878 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x00888 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...

        [NMS(Size = 6)]
        /* 0x00898 */ public float[] Hazard;

        /* 0x008B0 */ public int BoltAmmo;
        /* 0x008B4 */ public int ScatterAmmo;
        /* 0x008B8 */ public int PulseAmmo;
        /* 0x008BC */ public int LaserAmmo;

        /* 0x008C0 */ public Vector4f FirstSpawnPosition;

        [NMS(Size = 0x63, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x008D0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        /* 0x01530 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x01540 */ public List<NMSString0x20> InteractionProgressTable;

        [NMS(Size = 0xA)]
        /* 0x01550 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x01640 */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        /* 0x01748 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;

        /* 0x01758 */ public bool FirstAtlasStationDiscovered;
        /* 0x01759 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0175C */ public int ProgressionLevel;
        /* 0x01760 */ public int ProcTechIndex;
        /* 0x01764 */ public bool IsNew;
        /* 0x01765 */ public bool UseSmallerBlackholeJumps;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x01766 */ public byte[] Padding1766;

        /* 0x01768 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x10)]
        /* 0x01780 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x01880 */ public GcSeed[] PlanetSeeds;

        /* 0x01980 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x01984 */ public byte[] Padding1984;

        /* 0x01988 */ public ulong TimeLastSpaceBattle;
        /* 0x01990 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x01994 */ public byte[] Padding1994;

        /* 0x01998 */ public ulong ActiveSpaceBattleUA;
        /* 0x019A0 */ public ulong TimeLastMiniStation;
        /* 0x019A8 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x019AC */ public byte[] Padding19AC;

        /* 0x019B0 */ public ulong MiniStationUA;
        [NMS(Size = 8, Ignore = true)]
        /* 0x019B8 */ public byte[] Padding19B8;
        /* 0x019C0 */ public Vector4f AnomalyPositionOverride;

        /* 0x019D0 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x019E8 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x01A00 */ public bool[] GalacticMapRequests;

        /* 0x01A10 */ public Vector4f FirstShipPosition;

        /* 0x01A20 */ public ulong HazardTimeAlive;

        /* 0x01A28 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x01A29 */ public byte[] Padding1A29;
        /* 0x01A30 */ public GcSeed CurrentFreighterHomeSystemSeed;

        /* 0x01A40 */ public GcResourceElement CurrentFreighter;
        /* 0x01CE8 */ public GcInventoryLayout FreighterLayout;
        /* 0x01D08 */ public GcInventoryContainer FreighterInventory;
        /* 0x01D68 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x01DC8 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x01DE0 */ public Vector3f FreighterMatrixAt;
        /* 0x01DF0 */ public Vector3f FreighterMatrixUp;
        /* 0x01E00 */ public Vector3f FreighterMatrixPos;
        /* 0x01E10 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x01E20 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5)]
        /* 0x20FE0 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x21E40 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x21E50 */ public List<GcTeleportEndpoint> TeleportEndpoints;

        /* 0x21E60 */ public GcInventoryLayout Chest1Layout;
        /* 0x21E80 */ public GcInventoryContainer Chest1Inventory;
        /* 0x21EE0 */ public GcInventoryLayout Chest2Layout;
        /* 0x21F00 */ public GcInventoryContainer Chest2Inventory;
        /* 0x21F60 */ public GcInventoryLayout Chest3Layout;
        /* 0x21F80 */ public GcInventoryContainer Chest3Inventory;
        /* 0x21FE0 */ public GcInventoryLayout Chest4Layout;
        /* 0x22000 */ public GcInventoryContainer Chest4Inventory;
        /* 0x22060 */ public GcInventoryLayout Chest5Layout;
        /* 0x22080 */ public GcInventoryContainer Chest5Inventory;
        /* 0x220E0 */ public GcInventoryLayout Chest6Layout;
        /* 0x22100 */ public GcInventoryContainer Chest6Inventory;
        /* 0x22160 */ public GcInventoryLayout Chest7Layout;
        /* 0x22180 */ public GcInventoryContainer Chest7Inventory;
        /* 0x221E0 */ public GcInventoryLayout Chest8Layout;
        /* 0x22200 */ public GcInventoryContainer Chest8Inventory;
        /* 0x22260 */ public GcInventoryLayout Chest9Layout;
        /* 0x22280 */ public GcInventoryContainer Chest9Inventory;
        /* 0x222E0 */ public GcInventoryLayout Chest10Layout;
        /* 0x22300 */ public GcInventoryContainer Chest10Inventory;
        /* 0x22360 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x22380 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x223E0 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x22400 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x22460 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x22480 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x224E0 */ public GcResourceElement CurrentFreighterNPC;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x22788 */ public byte[] Padding22788;

        [NMS(Size = 0x6, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x22790 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x23E70 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x23E74 */ public byte[] Padding23E74;
        [NMS(Size = 0x6)]
        /* 0x23E80 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x25560 */ public int PrimaryShip;

        /* 0x25564 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x25565 */ public string PlayerWeaponName;
        [NMS(Size = 0x20)]
        /* 0x25585 */ public string PlayerFreighterName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x255A5 */ public byte[] Padding255A5;
        /* 0x255B0 */ public Vector4f StartGameShipPosition;
        /* 0x255C0 */ public int TradingSupplyDataIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x255C4 */ public byte[] Padding255C4;
        /* 0x255C8 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x255D8 */ public List<GcPortalData> LastPortal;
        /* 0x255E8 */ public GcPortalSaveData VisitedPortal;
        /* 0x25600 */ public int KnownPortalRunes;
        /* 0x25604 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x25605 */ public byte[] Padding25605;
        /* 0x25610 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x256A0 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x256B0 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x256C0 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x256C4 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0xE)]
        /* 0x256C8 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x25B98 */ public bool[] ShipUsesLegacyColours;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x25B9E */ public byte[] Padding25B9E;

        /* 0x25BA0 */ public GcSeed FleetSeed;
        /* 0x25BB0 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x25BC0 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x25BD0 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x25BE0 */ public ulong LastKnownDay;
        /* 0x25BE8 */ public ulong SunTimer;
        /* 0x25BF0 */ public ulong MultiplayerLobbyID;
        /* 0x25BF8 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x25C10 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x25C90 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x25CA0 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x25CA8 */ public GcHotActionsSaveData[] HotActions;
        /* 0x26158 */ public ulong LastUABeforePortalWarp;
        /* 0x26160 */ public ulong StoryPortalSeed;
        /* 0x26168 */ public uint ShopNumber;
        /* 0x2616A */ public uint ShopTier;
        /* 0x2616C */ public bool HasAccessToNexus;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x2616D */ public byte[] Padding2616D;
        /* 0x26170 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x26190 */ public Vector3f NexusMatrixAt;
        /* 0x261A0 */ public Vector3f NexusMatrixUp;
        /* 0x261B0 */ public Vector3f NexusMatrixPos;
        /* 0x261C0 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x26200 */ public int BannerIcon;
        /* 0x26204 */ public int BannerMainColour;
        /* 0x26208 */ public int BannerBackgroundColour;
        /* 0x2620C */ public int TelemetryUploadVersion;
        /* 0x26210 */ public bool UsesThirdPersonVehicleCam;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x26211 */ public byte[] EndPadding;
    }
}
