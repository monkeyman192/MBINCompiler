using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x25C50, GUID = 0xAA97AB5C8FE2F135)]
    public class GcPlayerStateData : NMSTemplate
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;

        /* 0x00018 */ public GcInventoryContainer Inventory;
        /* 0x00078 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x000D8 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x00138 */ public GcInventoryContainer ShipInventory;
        /* 0x00198 */ public GcInventoryContainer WeaponInventory;
        /* 0x001F8 */ public GcInventoryContainer GraveInventory;

        /* 0x00258 */ public bool SpawnGrave;
        /* 0x00259 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x0025A */ public byte[] Padding25A;

        /* 0x0025C */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x00274 */ public byte[] Padding274;

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
        /* 0x00678 */ public List<GcPlayerMissionProgress> MissionProgress;

        /* 0x00688 */ public int PostMissionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0068C */ public byte[] Padding68C;
        [NMS(Size = 0x10)]
        /* 0x00690 */ public string CurrentMissionID;
        /* 0x006A0 */ public ulong CurrentMissionSeed;
        [NMS(Size = 0x10)]
        /* 0x006A8 */ public string PreviousMissionID;
        /* 0x006B8 */ public ulong PreviousMissionSeed;
        /* 0x006C0 */ public int MissionVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x006C4 */ public byte[] Padding6C4;
        /* 0x006C8 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x006D8 */ public byte[] Padding6D8;
        /* 0x006E0 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x00700 */ public GcInteractionData HoloScepticInteraction;
        /* 0x006F0 */ public GcInteractionData HoloNooneInteraction;
        /* 0x00740 */ public int Health;
		/* 0x00744 */ public int ShipHealth;
        /* 0x00748 */ public int Shield;
		/* 0x0074C */ public int ShipShield;
		/* 0x00750 */ public int Energy;
        /* 0x00754 */ public int Units;
        /* 0x00758 */ public int Nanites;
        /* 0x0075C */ public int Specials;
        /* 0x00760 */ public bool ThirdPersonShip;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x00761 */ public byte[] Padding761;
        /* 0x00768 */ public ulong TimeAlive;
        /* 0x00770 */ public ulong TotalPlayTime;

        /* 0x00778 */ public List<GcScanEventSave> MarkerStack;
        /* 0x00788 */ public List<GcScanEventData> NewMPMarkerStack;

        /* 0x00798 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x007A8 */ public List<GcTelemetryStat> TelemetryStats;

        [NMS( EnumType = typeof( GcInteractionBufferType.InterationBufferTypeEnum ) )]
        /* 0x007B8 */ public GcInteractionBuffer[] StoredInteractions;

        /* 0x00858 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x00868 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x00878 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...

        [NMS(Size = 6)]
        /* 0x00888 */ public float[] Hazard;

        /* 0x008A0 */ public int BoltAmmo;
        /* 0x008A4 */ public int ScatterAmmo;
        /* 0x008A8 */ public int PulseAmmo;
        /* 0x008AC */ public int LaserAmmo;

        /* 0x008B0 */ public Vector4f FirstSpawnPosition;

        [NMS(Size = 0x4E, EnumType = typeof( GcInteractionType.InteractionTypeEnum ) )]
        /* 0x008C0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        /* 0x01148 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;

        /* 0x01158 */ public List<NMSString0x20> InteractionProgressTable;

        [NMS(Size = 0xA)]
        /* 0x01168 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x01258 */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        /* 0x01360 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;

        /* 0x01370 */ public bool FirstAtlasStationDiscovered;
        /* 0x01371 */ public bool UsesThirdPersonCharacterCam;
        /* 0x01374 */ public int ProgressionLevel;
        /* 0x01378 */ public int ProcTechIndex;
        /* 0x0137C */ public bool IsNew;
        /* 0x0137D */ public bool UseSmallerBlackholeJumps;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x0137E */ public byte[] Padding137E;

        /* 0x01380 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x10)]
        /* 0x01390 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x01490 */ public GcSeed[] PlanetSeeds;

        /* 0x01590 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x01594 */ public byte[] Padding1594;

        /* 0x01598 */ public ulong TimeLastSpaceBattle;
        /* 0x015A0 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x015A4 */ public byte[] Padding15A4;

        /* 0x015A8 */ public ulong ActiveSpaceBattleUA;
        /* 0x015B0 */ public ulong TimeLastMiniStation;
        /* 0x015B8 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x015BC */ public byte[] Padding15BC;

        /* 0x015C0 */ public ulong MiniStationUA;
        [NMS(Size = 8, Ignore = true)]
        /* 0x015C8 */ public byte[] Padding15C8;
        /* 0x015D0 */ public Vector4f AnomalyPositionOverride;

        /* 0x015E0 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x015F8 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x01610 */ public bool[] GalacticMapRequests;

        /* 0x01620 */ public Vector4f FirstShipPosition;

        /* 0x01630 */ public ulong HazardTimeAlive;

        /* 0x01638 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x01639 */ public byte[] Padding1639;
        /* 0x01640 */ public GcSeed CurrentFreighterHomeSystemSeed;

        /* 0x01650 */ public GcResourceElement CurrentFreighter;
        /* 0x018F8 */ public GcInventoryLayout FreighterLayout;
        /* 0x01918 */ public GcInventoryContainer FreighterInventory;
        /* 0x01978 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x019D8 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x019F0 */ public Vector4f FreighterMatrixAt;
        /* 0x01A00 */ public Vector4f FreighterMatrixUp;
        /* 0x01A10 */ public Vector4f FreighterMatrixPos;
        /* 0x01A20 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x01A30 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5)]
        /* 0x20BF0 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x21A50 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x21A60 */ public List<GcTeleportEndpoint> TeleportEndpoints;

        /* 0x21A70 */ public GcInventoryLayout Chest1Layout;
        /* 0x21A90 */ public GcInventoryContainer Chest1Inventory;
        /* 0x21AF0 */ public GcInventoryLayout Chest2Layout;
        /* 0x21B10 */ public GcInventoryContainer Chest2Inventory;
        /* 0x21B70 */ public GcInventoryLayout Chest3Layout;
        /* 0x21B90 */ public GcInventoryContainer Chest3Inventory;
        /* 0x21BF0 */ public GcInventoryLayout Chest4Layout;
        /* 0x21C10 */ public GcInventoryContainer Chest4Inventory;
        /* 0x21C70 */ public GcInventoryLayout Chest5Layout;
        /* 0x21C90 */ public GcInventoryContainer Chest5Inventory;
        /* 0x21CF0 */ public GcInventoryLayout Chest6Layout;
        /* 0x21D10 */ public GcInventoryContainer Chest6Inventory;
        /* 0x21D70 */ public GcInventoryLayout Chest7Layout;
        /* 0x21D90 */ public GcInventoryContainer Chest7Inventory;
        /* 0x21DF0 */ public GcInventoryLayout Chest8Layout;
        /* 0x21E10 */ public GcInventoryContainer Chest8Inventory;
        /* 0x21E70 */ public GcInventoryLayout Chest9Layout;
        /* 0x21E90 */ public GcInventoryContainer Chest9Inventory;
        /* 0x21EF0 */ public GcInventoryLayout Chest10Layout;
        /* 0x21F10 */ public GcInventoryContainer Chest10Inventory;
        /* 0x21F70 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x21F90 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x21FF0 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x22010 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x22070 */ public GcResourceElement CurrentFreighterNPC;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x22318 */ public byte[] Padding22318;

        // enum struct: GcVehicleType
        [NMS(Size = 0x6, EnumValue = new[] { "Buggy", "Bike", "Truck", "WheeledBike", "Hovercraft", "Submarine" })]
        /* 0x22320 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x23A00 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x23A04 */ public byte[] Padding23A04;
        [NMS(Size = 0x6)]
        /* 0x23A10 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x250F0 */ public int PrimaryShip;

        /* 0x250F4 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x250F5 */ public string PlayerWeaponName;
        [NMS(Size = 0x20)]
        /* 0x25115 */ public string PlayerFreighterName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x25135 */ public byte[] Padding25135;
        /* 0x25140 */ public Vector4f StartGameShipPosition;
        /* 0x25150 */ public int TradingSupplyDataIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x25154 */ public byte[] Padding25154;
        /* 0x25158 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x25168 */ public List<GcPortalData> LastPortal;
        /* 0x25178 */ public GcPortalSaveData VisitedPortal;
        /* 0x25190 */ public int KnownPortalRunes;
        /* 0x25194 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x25195 */ public byte[] Padding25195;
        /* 0x251A0 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x251B0 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x251C0 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x251C4 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0xE)]
        /* 0x251C8 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x25698 */ public bool[] ShipUsesLegacyColours;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x2569E */ public byte[] Padding2569E;

        /* 0x256A0 */ public GcSeed FleetSeed;
        /* 0x256B0 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x256C0 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x256D0 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x256E0 */ public ulong LastKnownDay;
        /* 0x256E8 */ public ulong SunTimer;
        /* 0x256F0 */ public ulong MultiplayerLobbyID;
        /* 0x256F8 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x25710 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x25790 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x257A0 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumValue = new[] { "OnFoot", "InShip", "InExocraft" })]
        /* 0x257A8 */ public GcHotActionsSaveData[] HotActions;
        /* 0x25C58 */ public ulong LastUABeforePortalWarp;
        /* 0x25C60 */ public ulong StoryPortalSeed;
        /* 0x25C68 */ public uint ShopNumber;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x25C6C */ public byte[] EndPadding;
    }
}
