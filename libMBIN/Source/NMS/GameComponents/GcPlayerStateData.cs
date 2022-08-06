using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x611C569EFD2679BD, NameHash = 0x6C4510BB243EFA64)]
    public class GcPlayerStateData : NMSTemplate
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;
        /* 0x00018 */ public GcUniverseAddressData PreviousUniverseAddress;
        /* 0x00030 */ public int HomeRealityIteration;
        /* 0x00038 */ public GcInventoryContainer Inventory;
        /* 0x00198 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x002F8 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x00458 */ public GcInventoryContainer ShipInventory;
        /* 0x005B8 */ public GcInventoryContainer WeaponInventory;
        [NMS(Size = 0x6)]
        /* 0x00718 */ public GcMultitoolData[] Multitools;
        /* 0x02188 */ public int ActiveMultioolIndex;
        /* 0x02190 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Size = 0x12)]
        /* 0x03B98 */ public GcPetData[] Pets;
        [NMS(Size = 0x12)]
        /* 0x061D8 */ public GcPetData[] Eggs;
        [NMS(Size = 0x12)]
        /* 0x08818 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Size = 0x12)]
        /* 0x09AA8 */ public bool[] UnlockedPetSlots;
        /* 0x09AC0 */ public GcInventoryContainer GraveInventory;
        /* 0x09C20 */ public bool SpawnGrave;
        /* 0x09C21 */ public bool SpaceGrave;
        /* 0x09C24 */ public GcUniverseAddressData GraveUniverseAddress;
        /* 0x09C40 */ public Vector4f GravePosition;
        /* 0x09C50 */ public Vector4f GraveMatrixLookAt;
        /* 0x09C60 */ public Vector4f GraveMatrixUp;
        /* 0x09C70 */ public GcInventoryLayout ShipLayout;
        /* 0x09C90 */ public GcInventoryLayout WeaponLayout;
        /* 0x09CB0 */ public GcResourceElement CurrentShip;
        /* 0x09F58 */ public GcExactResource CurrentWeapon;
        /* 0x09FE8 */ public List<NMSString0x10> KnownTech;
        /* 0x09FF8 */ public List<NMSString0x10> KnownProducts;
        /* 0x0A008 */ public List<NMSString0x10> KnownSpecials;
        /* 0x0A018 */ public List<NMSString0x20A> KnownRefinerRecipes;
        /* 0x0A028 */ public List<GcWordKnowledge> KnownWords;
        /* 0x0A038 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x0A048 */ public List<GcPlayerMissionProgress> MissionProgress;
        /* 0x0A058 */ public int PostMissionIndex;
        /* 0x0A060 */ public NMSString0x10 CurrentMissionID;
        /* 0x0A070 */ public ulong CurrentMissionSeed;
        /* 0x0A078 */ public NMSString0x10 PreviousMissionID;
        /* 0x0A088 */ public ulong PreviousMissionSeed;
        /* 0x0A090 */ public int MissionVersion;
        /* 0x0A098 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        /* 0x0A0B0 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x0A0D0 */ public GcInteractionData HoloScepticInteraction;
        /* 0x0A0F0 */ public GcInteractionData HoloNooneInteraction;
        /* 0x0A110 */ public int Health;
        /* 0x0A114 */ public int ShipHealth;
        /* 0x0A118 */ public int Shield;
        /* 0x0A11C */ public int ShipShield;
        /* 0x0A120 */ public int Energy;
        /* 0x0A124 */ public int Units;
        /* 0x0A128 */ public int Nanites;
        /* 0x0A12C */ public int Specials;
        /* 0x0A130 */ public bool ThirdPersonShip;
        /* 0x0A138 */ public ulong TimeAlive;
        /* 0x0A140 */ public ulong TotalPlayTime;
        /* 0x0A148 */ public List<GcScanEventSave> MarkerStack;
        /* 0x0A158 */ public List<GcScanEventSave> NewMPMarkerStack;
        /* 0x0A168 */ public List<Vector3f> SurveyedEventPositions;
        /* 0x0A178 */ public int NextSurveyedEventPositionIndex;
        /* 0x0A180 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x0A190 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InterationBufferTypeEnum))]
        /* 0x0A1A0 */ public GcInteractionBuffer[] StoredInteractions;
        /* 0x0A2A8 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x0A2B8 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x0A2C8 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0A2D8 */ public float[] Hazard;
        /* 0x0A2F0 */ public int BoltAmmo;
        /* 0x0A2F4 */ public int ScatterAmmo;
        /* 0x0A2F8 */ public int PulseAmmo;
        /* 0x0A2FC */ public int LaserAmmo;
        /* 0x0A300 */ public Vector4f FirstSpawnPosition;
        [NMS(Size = 0x83, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0A310 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x0B370 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x0B380 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x0B390 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x0B480 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x0B588 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x0B598 */ public bool FirstAtlasStationDiscovered;
        /* 0x0B599 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0B59C */ public int ProgressionLevel;
        /* 0x0B5A0 */ public int ProcTechIndex;
        /* 0x0B5A4 */ public bool IsNew;
        /* 0x0B5A5 */ public bool UseSmallerBlackholeJumps;
        /* 0x0B5A8 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x0B5C0 */ public Vector3f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x0B6C0 */ public GcSeed[] PlanetSeeds;
        /* 0x0B7C0 */ public int PrimaryPlanet;
        /* 0x0B7C8 */ public ulong TimeLastSpaceBattle;
        /* 0x0B7D0 */ public int WarpsLastSpaceBattle;
        /* 0x0B7D8 */ public ulong ActiveSpaceBattleUA;
        /* 0x0B7E0 */ public ulong TimeLastMiniStation;
        /* 0x0B7E8 */ public int WarpsLastMiniStation;
        /* 0x0B7F0 */ public ulong MiniStationUA;
        /* 0x0B800 */ public Vector4f AnomalyPositionOverride;
        /* 0x0B810 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x0B828 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x0B840 */ public bool[] GalacticMapRequests;
        /* 0x0B850 */ public Vector4f FirstShipPosition;
        /* 0x0B860 */ public ulong HazardTimeAlive;
        /* 0x0B868 */ public bool RevealBlackHoles;
        /* 0x0B870 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x0B880 */ public GcResourceElement CurrentFreighter;
        /* 0x0BB28 */ public GcInventoryLayout FreighterLayout;
        /* 0x0BB48 */ public GcInventoryLayout FreighterCargoLayout;
        /* 0x0BB68 */ public GcInventoryContainer FreighterInventory;
        /* 0x0BCC8 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x0BE28 */ public GcInventoryContainer FreighterInventory_Cargo;
        /* 0x0BF88 */ public ulong FreighterLastSpawnTime;
        /* 0x0BF90 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x0BFA8 */ public bool FreighterDismissed;
        /* 0x0BFB0 */ public Vector3f FreighterMatrixAt;
        /* 0x0BFC0 */ public Vector3f FreighterMatrixUp;
        /* 0x0BFD0 */ public Vector3f FreighterMatrixPos;
        [NMS(Size = 0x4)]
        /* 0x0BFE0 */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Size = 0x4)]
        /* 0x0BFE8 */ public GcSquadronPilotData[] SquadronPilots;
        /* 0x0D568 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        /* 0x0D578 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x0D590 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x49D10 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x4AB70 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x4AB80 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x4AB90 */ public GcInventoryLayout Chest1Layout;
        /* 0x4ABB0 */ public GcInventoryContainer Chest1Inventory;
        /* 0x4AD10 */ public GcInventoryLayout Chest2Layout;
        /* 0x4AD30 */ public GcInventoryContainer Chest2Inventory;
        /* 0x4AE90 */ public GcInventoryLayout Chest3Layout;
        /* 0x4AEB0 */ public GcInventoryContainer Chest3Inventory;
        /* 0x4B010 */ public GcInventoryLayout Chest4Layout;
        /* 0x4B030 */ public GcInventoryContainer Chest4Inventory;
        /* 0x4B190 */ public GcInventoryLayout Chest5Layout;
        /* 0x4B1B0 */ public GcInventoryContainer Chest5Inventory;
        /* 0x4B310 */ public GcInventoryLayout Chest6Layout;
        /* 0x4B330 */ public GcInventoryContainer Chest6Inventory;
        /* 0x4B490 */ public GcInventoryLayout Chest7Layout;
        /* 0x4B4B0 */ public GcInventoryContainer Chest7Inventory;
        /* 0x4B610 */ public GcInventoryLayout Chest8Layout;
        /* 0x4B630 */ public GcInventoryContainer Chest8Inventory;
        /* 0x4B790 */ public GcInventoryLayout Chest9Layout;
        /* 0x4B7B0 */ public GcInventoryContainer Chest9Inventory;
        /* 0x4B910 */ public GcInventoryLayout Chest10Layout;
        /* 0x4B930 */ public GcInventoryContainer Chest10Inventory;
        /* 0x4BA90 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x4BAB0 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x4BC10 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x4BC30 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x4BD90 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x4BDB0 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x4BF10 */ public GcInventoryLayout RocketLockerLayout;
        /* 0x4BF30 */ public GcInventoryContainer RocketLockerInventory;
        /* 0x4C090 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x4C340 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x4F590 */ public int PrimaryVehicle;
        [NMS(Size = 0x9)]
        /* 0x4F5A0 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x53650 */ public int PrimaryShip;
        /* 0x53654 */ public bool MultiShipEnabled;
        /* 0x53655 */ public bool VehicleAIControlEnabled;
        /* 0x53656 */ public NMSString0x20 PlayerFreighterName;
        /* 0x53680 */ public Vector4f StartGameShipPosition;
        /* 0x53690 */ public bool ShipNeedsTerrainPositioning;
        /* 0x53694 */ public int TradingSupplyDataIndex;
        /* 0x53698 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x536A8 */ public List<GcPortalSaveData> LastPortal;
        /* 0x536B8 */ public GcPortalSaveData VisitedPortal;
                                                
                                                
        /* 0x536D8 */ public int KnownPortalRunes;
        /* 0x536DC */ public bool OnOtherSideOfPortal;
        /* 0x536E0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x53770 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x53780 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x53790 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x53794 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x14, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x53798 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x9)]
        /* 0x53E78 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x3)]
        /* 0x53E88 */ public GcCharacterCustomisationData[] Outfits;
        /* 0x53F60 */ public NMSString0x10 JetpackEffect;
        /* 0x53F70 */ public NMSString0x10 FreighterEngineEffect;
        /* 0x53F80 */ public GcSeed FleetSeed;
        /* 0x53F90 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x53FA0 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x53FB0 */ public List<ulong> ExpeditionSeedsSelectedToday;
        /* 0x53FC0 */ public ulong LastKnownDay;
        /* 0x53FC8 */ public ulong SunTimer;
        /* 0x53FD0 */ public ulong MultiplayerLobbyID;
        /* 0x53FD8 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x53FF0 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x540A0 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x540B0 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x540B8 */ public GcHotActionsSaveData[] HotActions;
        /* 0x54568 */ public ulong LastUABeforePortalWarp;
        /* 0x54570 */ public ulong StoryPortalSeed;
        /* 0x54578 */ public ushort ShopNumber;
        /* 0x5457A */ public ushort ShopTier;
        /* 0x5457C */ public bool HasAccessToNexus;
        /* 0x54580 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x545A0 */ public Vector3f NexusMatrixAt;
        /* 0x545B0 */ public Vector3f NexusMatrixUp;
        /* 0x545C0 */ public Vector3f NexusMatrixPos;
        /* 0x545D0 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x54620 */ public int BannerIcon;
        /* 0x54624 */ public int BannerMainColour;
        /* 0x54628 */ public int BannerBackgroundColour;
        /* 0x54630 */ public NMSString0x10 BannerTitleId;
        /* 0x54640 */ public int TelemetryUploadVersion;
        /* 0x54644 */ public bool UsesThirdPersonVehicleCam;
        /* 0x54648 */ public float VRCameraOffset;
        /* 0x54650 */ public GcSeasonalGameModeData SeasonData;
        /* 0x579C0 */ public GcSeasonStateData SeasonState;
        /* 0x57A18 */ public bool RestartAllInactiveSeasonalMissions;
        /* 0x57A20 */ public List<NMSString0x10> RedeemedSeasonRewards;
        /* 0x57A30 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Size = 0x64)]
        /* 0x57A40 */ public GcSettlementState[] SettlementStatesV2;
        /* 0x76E40 */ public int SettlementStateRingBufferIndexV2;
        /* 0x76E44 */ public bool NextLoadSpawnsWithFreshStart;
    }
}
