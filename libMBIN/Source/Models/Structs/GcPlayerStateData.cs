using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x10340)]
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
        /* 0x00658 */ public List<GcWordKnowledge> KnownWords;
        /* 0x00668 */ public List<GcPlayerMissionProgress> MissionProgress;

        /* 0x00678 */ public int PostMissionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0067C */ public byte[] Padding67C;
        [NMS(Size = 0x10)]
        /* 0x00680 */ public string CurrentMissionID;
        /* 0x00690 */ public ulong CurrentMissionSeed;
        [NMS(Size = 0x10)]
        /* 0x00698 */ public string PreviousMissionID;
        /* 0x006A8 */ public ulong PreviousMissionSeed;
        /* 0x006B0 */ public int MissionVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x006B4 */ public byte[] Padding6B4;
        /* 0x006B8 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x006C8 */ public byte[] Padding6C8;
        /* 0x006D0 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x006F0 */ public GcInteractionData HoloScepticInteraction;
        /* 0x006E0 */ public GcInteractionData HoloNooneInteraction;
        /* 0x00730 */ public int Health;
		/* 0x00734 */ public int ShipHealth;
        /* 0x00738 */ public int Shield;
		/* 0x0073C */ public int ShipShield;
		/* 0x00740 */ public int Energy;
        /* 0x00744 */ public int Units;
        /* 0x00748 */ public int Nanites;
        /* 0x0074C */ public int Specials;
        /* 0x00750 */ public bool ThirdPersonShip;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x00751 */ public byte[] Padding751;
        /* 0x00758 */ public ulong TimeAlive;
        /* 0x00760 */ public ulong TotalPlayTime;

        /* 0x00768 */ public List<GcScanEventSave> MarkerStack;
        /* 0x00778 */ public List<GcScanEventData> NewMPMarkerStack;

        /* 0x00788 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x00798 */ public List<GcTelemetryStat> TelemetryStats;

        [NMS(Size = 0xA, EnumValue = new[] { "Distress_Signal", "Crate", "Destructable", "Terrain", "Cost", "Building", "Creature", "Maintenance", "Personal", "Personal_Maintenance" })]
        /* 0x007A8 */ public GcInteractionBuffer[] StoredInteractions;

        /* 0x00848 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x00858 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x00868 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...

        [NMS(Size = 6)]
        /* 0x00878 */ public float[] Hazard;

        /* 0x00890 */ public int BoltAmmo;
        /* 0x00894 */ public int ScatterAmmo;
        /* 0x00898 */ public int PulseAmmo;
        /* 0x0089C */ public int LaserAmmo;

        /* 0x008A0 */ public Vector4f FirstSpawnPosition;

        [NMS(Size = 0x4C, EnumValue = new[] {
                "None", "Shop", "NPC", "NPC_Secondary", "NPC_Anomaly", "NPC_Anomaly_Secondary", "Ship", "Outpost",
                "SpaceStation", "RadioTower", "Monolith", "Factory", "AbandonedShip", "Harvester", "Observatory", "TradingPost",
                "DistressBeacon", "Portal", "Plaque", "AtlasStation", "AbandonedBuildings", "WeaponTerminal", "SuitTerminal", "SignalScanner",
                "Teleporter_Base", "Teleporter_Station", "ClaimBase", "NPC_Freighter_Captain", "NPC_HIRE_Weapons", "NPC_HIRE_Weapons_Wait",
                "NPC_HIRE_Farmer", "NPC_HIRE_Farmer_Wait", "NPC_HIRE_Builder", "NPC_HIRE_Builder_Wait", "NPC_HIRE_Vehicles", "NPC_HIRE_Vehicles_Wait",
                "MessageBeacon", "NPC_HIRE_Scientist", "NPC_HIRE_Scientist_Wait", "NPC_Recruit", "NPC_Freighter_Captain_Secondary", "NPC_Recruit_Secondary",
                "Vehicle", "MessageModule", "TechShop", "VehicleRaseStart", "BuildingShop", "MissionGiver", "HoloHub", "HoloExplorer", "HoloSceptic", "HoloNoone",
                "PortalRunEntry", "PortalActivate", "CrashedFreighter", "GraveInCave", "GlitchyStroyBox", "NetworkPlayer", "NetworkMonument",
                "AnomalyComputer", "AtlasPlinth", "Epilogue", "GuildEnvoy", "ManageFleet", "ManageExpeditions", "Frigate", "CustomiseCharacter",
                "CustomiseShip", "CustomiseWeapon", "CustomiseVehicle", "ClaimBaseAnywhere", "FleetNavigator", "FleetCommandPost", "StoryUtility",
                "MPMissionGiver", "SpecialsShop" })]
        /* 0x008B0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        /* 0x01100 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;

        /* 0x01110 */ public List<NMSString0x20> InteractionProgressTable;

        [NMS(Size = 0xA)]
        /* 0x01120 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x01210 */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        /* 0x01318 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;

        /* 0x01328 */ public bool FirstAtlasStationDiscovered;
        /* 0x01329 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0132C */ public int ProgressionLevel;
        /* 0x01330 */ public int ProcTechIndex;
        /* 0x01334 */ public bool IsNew;
        /* 0x01335 */ public bool UseSmallerBlackholeJumps;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x01336 */ public byte[] Padding1336;

        /* 0x01338 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x01348 */ public byte[] Padding1348;

        [NMS(Size = 0x10)]
        /* 0x01350 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x01450 */ public GcSeed[] PlanetSeeds;

        /* 0x01550 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x01554 */ public byte[] Padding1554;

        /* 0x01558 */ public ulong TimeLastSpaceBattle;
        /* 0x01560 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x01564 */ public byte[] Padding1564;

        /* 0x01568 */ public ulong ActiveSpaceBattleUA;
        /* 0x01570 */ public ulong TimeLastMiniStation;
        /* 0x01578 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x0157C */ public byte[] Padding157C;

        /* 0x01580 */ public ulong MiniStationUA;
        [NMS(Size = 8, Ignore = true)]
        /* 0x01588 */ public byte[] Padding1588;
        /* 0x01590 */ public Vector4f AnomalyPositionOverride;

        /* 0x015A0 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x015B8 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x015D0 */ public bool[] GalacticMapRequests;

        /* 0x015E0 */ public Vector4f FirstShipPosition;

        /* 0x015F0 */ public ulong HazardTimeAlive;

        /* 0x015F8 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x015F9 */ public byte[] Padding15F9;
        /* 0x01600 */ public GcSeed CurrentFreighterHomeSystemSeed;

        /* 0x01610 */ public GcResourceElement CurrentFreighter;
        /* 0x018B8 */ public GcInventoryLayout FreighterLayout;
        /* 0x018D8 */ public GcInventoryContainer FreighterInventory;
        /* 0x01938 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x01998 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x019B0 */ public Vector4f FreighterMatrixAt;
        /* 0x019C0 */ public Vector4f FreighterMatrixUp;
        /* 0x019D0 */ public Vector4f FreighterMatrixPos;
        /* 0x019E0 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x019F0 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5)]
        /* 0x0C4B0 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x0D310 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x0D320 */ public List<GcTeleportEndpoint> TeleportEndpoints;

        /* 0xD330 */ public GcInventoryLayout Chest1Layout;
        /* 0xD350 */ public GcInventoryContainer Chest1Inventory;
        /* 0xD3B0 */ public GcInventoryLayout Chest2Layout;
        /* 0xD3D0 */ public GcInventoryContainer Chest2Inventory;
        /* 0xD430 */ public GcInventoryLayout Chest3Layout;
        /* 0xD450 */ public GcInventoryContainer Chest3Inventory;
        /* 0xD4B0 */ public GcInventoryLayout Chest4Layout;
        /* 0xD4D0 */ public GcInventoryContainer Chest4Inventory;
        /* 0xD530 */ public GcInventoryLayout Chest5Layout;
        /* 0xD550 */ public GcInventoryContainer Chest5Inventory;
        /* 0xD5B0 */ public GcInventoryLayout Chest6Layout;
        /* 0xD5D0 */ public GcInventoryContainer Chest6Inventory;
        /* 0xD630 */ public GcInventoryLayout Chest7Layout;
        /* 0xD650 */ public GcInventoryContainer Chest7Inventory;
        /* 0xD6B0 */ public GcInventoryLayout Chest8Layout;
        /* 0xD6D0 */ public GcInventoryContainer Chest8Inventory;
        /* 0xD730 */ public GcInventoryLayout Chest9Layout;
        /* 0xD750 */ public GcInventoryContainer Chest9Inventory;
        /* 0xD7B0 */ public GcInventoryLayout Chest10Layout;
        /* 0xD7D0 */ public GcInventoryContainer Chest10Inventory;
        /* 0xD830 */ public GcInventoryLayout ChestMagicLayout;
        /* 0xD850 */ public GcInventoryContainer ChestMagicInventory;
        /* 0xD8B0 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0xD8D0 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0xD930 */ public GcResourceElement CurrentFreighterNPC;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0xDBD8 */ public byte[] PaddingDBD8;

        [NMS(Size = 0x3)]
        /* 0xDBE0 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0xE750 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0xE754 */ public byte[] PaddingE754;
        [NMS(Size = 0x6)]
        /* 0xE760 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0xFE40 */ public int PrimaryShip;

        /* 0xFE44 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0xFE45 */ public string PlayerWeaponName;
        [NMS(Size = 0x20)]
        /* 0xFE65 */ public string PlayerFreighterName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0xFE85 */ public byte[] PaddingFE85;
        /* 0xFE90 */ public Vector4f StartGameShipPosition;
        /* 0xFEA0 */ public int TradingSupplyDataIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xFEA4 */ public byte[] PaddingFEA4;
        /* 0xFEA8 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0xFEB8 */ public List<GcPortalData> LastPortal;     // just a guess...
        /* 0xFEC8 */ public GcPortalSaveData VisitedPortal;
        /* 0xFEE0 */ public int KnownPortalRunes;
        /* 0xFEE4 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0xFEE5 */ public byte[] PaddingFEE5;
        /* 0xFEF0 */ public Vector4f PortalMarkerPosition_Local;
        /* 0xFF00 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0xFF10 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0xFF14 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x9)]
        /* 0xFF18 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x10230 */ public bool[] ShipUsesLegacyColours;
        /* 0x10238 */ public GcSeed FleetSeed;
        /* 0x10248 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x10258 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x10268 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x10278 */ public ulong LastKnownDay;
        /* 0x10280 */ public ulong SunTimer;
        /* 0x10288 */ public ulong MultiplayerLobbyID;
        /* 0x10290 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x102A8 */ public byte[] Padding102A8;
        /* 0x102B0 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x10330 */ public List<GcRepairTechData> RepairTechBuffer;
    }
}
