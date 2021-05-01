using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2C230, GUID = 0x3BB7BC5383734D35, NameHash = 0x6C4510BB243EFA64)]
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
        /* 0x00718 */ public GcMultitoolData[] Multitools;
        /* 0x00C58 */ public int ActiveMultioolIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00C5C */ public byte[] PaddingC5C;
        [NMS(Size = 0x6)]
        /* 0x00C60 */ public GcPetData[] Pets;
        [NMS(Size = 0x6)]
        /* 0x01800 */ public GcPetData[] Eggs;
        [NMS(Size = 0x6)]
        /* 0x023A0 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Size = 0x6)]
        /* 0x029D0 */ public bool[] UnlockedPetSlots;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x029D6 */ public byte[] Padding29D6;
        /* 0x029D8 */ public GcInventoryContainer GraveInventory;
        /* 0x02B38 */ public bool SpawnGrave;
        /* 0x02B39 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x02B3A */ public byte[] Padding2B3A;
        /* 0x02B3C */ public GcUniverseAddressData GraveUniverseAddress;
        /* 0x02B60 */ public Vector4f GravePosition;
        /* 0x02B70 */ public Vector4f GraveMatrixLookAt;
        /* 0x02B80 */ public Vector4f GraveMatrixUp;
        /* 0x02B90 */ public GcInventoryLayout ShipLayout;
        /* 0x02BB0 */ public GcInventoryLayout WeaponLayout;
        /* 0x02BD0 */ public GcResourceElement CurrentShip;
        /* 0x02E78 */ public GcExactResource CurrentWeapon;
        /* 0x02F08 */ public List<NMSString0x10> KnownTech;
        /* 0x02F18 */ public List<NMSString0x10> KnownProducts;
        /* 0x02F28 */ public List<NMSString0x10> KnownSpecials;
        /* 0x02F38 */ public List<NMSString0x20> KnownRefinerRecipes;
        /* 0x02F48 */ public List<GcWordKnowledge> KnownWords;
        /* 0x02F58 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x02F68 */ public List<GcPlayerMissionProgress> MissionProgress;
        /* 0x02F78 */ public int PostMissionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x02F7C */ public byte[] Padding2F7C;
        [NMS(Size = 0x10)]
        /* 0x02F80 */ public string CurrentMissionID;
        /* 0x02F90 */ public ulong CurrentMissionSeed;
        [NMS(Size = 0x10)]
        /* 0x02F98 */ public string PreviousMissionID;
        /* 0x02FA8 */ public ulong PreviousMissionSeed;
        /* 0x02FB0 */ public int MissionVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x02FB4 */ public byte[] Padding2FB4;
        /* 0x02FB8 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x02FC8 */ public byte[] Padding2FC8;
        /* 0x02FD0 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x02FF0 */ public GcInteractionData HoloScepticInteraction;
        /* 0x03010 */ public GcInteractionData HoloNooneInteraction;
        /* 0x03030 */ public int Health;
		/* 0x03034 */ public int ShipHealth;
        /* 0x03038 */ public int Shield;
		/* 0x0303C */ public int ShipShield;
		/* 0x03040 */ public int Energy;
        /* 0x03044 */ public int Units;
        /* 0x03048 */ public int Nanites;
        /* 0x0304C */ public int Specials;
        /* 0x03050 */ public bool ThirdPersonShip;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x03051 */ public byte[] Padding3051;
        /* 0x03058 */ public ulong TimeAlive;
        /* 0x03060 */ public ulong TotalPlayTime;
        /* 0x03068 */ public List<GcScanEventSave> MarkerStack;
        /* 0x03078 */ public List<GcScanEventSave> NewMPMarkerStack;
        /* 0x03088 */ public List<Vector4f> SurveyedEventPositions;
        /* 0x03098 */ public int NextSurveyedEventPositionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0309C */ public byte[] Padding309C;
        /* 0x030A0 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x030B0 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InterationBufferTypeEnum))]
        /* 0x030C0 */ public GcInteractionBuffer[] StoredInteractions;
        /* 0x031C8 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x031D8 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x031E8 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...
        [NMS(Size = 6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x031F8 */ public float[] Hazard;
        /* 0x03210 */ public int BoltAmmo;
        /* 0x03214 */ public int ScatterAmmo;
        /* 0x03218 */ public int PulseAmmo;
        /* 0x0321C */ public int LaserAmmo;
        /* 0x03220 */ public Vector4f FirstSpawnPosition;
        [NMS(Size = 0x72, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x03230 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x04070 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x04080 */ public List<NMSString0x20> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x04090 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x04180 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x04288 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x04298 */ public bool FirstAtlasStationDiscovered;
        /* 0x04299 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0429C */ public int ProgressionLevel;
        /* 0x042A0 */ public int ProcTechIndex;
        /* 0x042A4 */ public bool IsNew;
        /* 0x042A5 */ public bool UseSmallerBlackholeJumps;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x042A6 */ public byte[] Padding42A6;
        /* 0x042A8 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x042C0 */ public Vector4f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x043C0 */ public GcSeed[] PlanetSeeds;
        /* 0x044C0 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x044C4 */ public byte[] Padding44C4;
        /* 0x044C8 */ public ulong TimeLastSpaceBattle;
        /* 0x044D0 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x044D4 */ public byte[] Padding44D4;
        /* 0x044D8 */ public ulong ActiveSpaceBattleUA;
        /* 0x044E0 */ public ulong TimeLastMiniStation;
        /* 0x044E8 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x044EC */ public byte[] Padding44EC;
        /* 0x044F0 */ public ulong MiniStationUA;
        [NMS(Size = 8, Ignore = true)]
        /* 0x044F8 */ public byte[] Padding44F8;
        /* 0x04500 */ public Vector4f AnomalyPositionOverride;
        /* 0x04510 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x04528 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x04540 */ public bool[] GalacticMapRequests;
        /* 0x04550 */ public Vector4f FirstShipPosition;
        /* 0x04560 */ public ulong HazardTimeAlive;
        /* 0x04568 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x04569 */ public byte[] Padding4569;
        /* 0x04570 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x04580 */ public GcResourceElement CurrentFreighter;
        /* 0x04828 */ public GcInventoryLayout FreighterLayout;
        /* 0x04848 */ public GcInventoryContainer FreighterInventory;
        /* 0x049A8 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x04B08 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x04B20 */ public Vector3f FreighterMatrixAt;
        /* 0x04B30 */ public Vector3f FreighterMatrixUp;
        /* 0x04B40 */ public Vector3f FreighterMatrixPos;
        /* 0x04B50 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x04B60 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x23E20 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x24C80 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x24C90 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x24CA0 */ public GcInventoryLayout Chest1Layout;
        /* 0x24CC0 */ public GcInventoryContainer Chest1Inventory;
        /* 0x24E20 */ public GcInventoryLayout Chest2Layout;
        /* 0x24E40 */ public GcInventoryContainer Chest2Inventory;
        /* 0x24FA0 */ public GcInventoryLayout Chest3Layout;
        /* 0x24FC0 */ public GcInventoryContainer Chest3Inventory;
        /* 0x25120 */ public GcInventoryLayout Chest4Layout;
        /* 0x25140 */ public GcInventoryContainer Chest4Inventory;
        /* 0x252A0 */ public GcInventoryLayout Chest5Layout;
        /* 0x252C0 */ public GcInventoryContainer Chest5Inventory;
        /* 0x25420 */ public GcInventoryLayout Chest6Layout;
        /* 0x25440 */ public GcInventoryContainer Chest6Inventory;
        /* 0x255A0 */ public GcInventoryLayout Chest7Layout;
        /* 0x255C0 */ public GcInventoryContainer Chest7Inventory;
        /* 0x25720 */ public GcInventoryLayout Chest8Layout;
        /* 0x25740 */ public GcInventoryContainer Chest8Inventory;
        /* 0x258A0 */ public GcInventoryLayout Chest9Layout;
        /* 0x258C0 */ public GcInventoryContainer Chest9Inventory;
        /* 0x25A20 */ public GcInventoryLayout Chest10Layout;
        /* 0x25A40 */ public GcInventoryContainer Chest10Inventory;
        /* 0x25BA0 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x25BC0 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x25D20 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x25D40 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x25EA0 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x25EC0 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x26020 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x262C8 */ public byte[] Padding262C8;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x262D0 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x28B80 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x28B84 */ public byte[] Padding28B84;
        [NMS(Size = 0x6)]
        /* 0x28B90 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x2AE70 */ public int PrimaryShip;
        /* 0x2AE74 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x2AE75 */ public string PlayerFreighterName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x2AE95 */ public byte[] Padding2AE95;
        /* 0x2AEA0 */ public Vector4f StartGameShipPosition;
        /* 0x2AEB0 */ public bool ShipNeedsTerrainPositioning;
        /* 0x2AEB4 */ public int TradingSupplyDataIndex;
        /* 0x2AEB8 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x2AEC8 */ public List<GcPortalData> LastPortal;
        /* 0x2AED8 */ public GcPortalSaveData VisitedPortal;
        /* 0x2AEF0 */ public int KnownPortalRunes;
        /* 0x2AEF4 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x2AEF5 */ public byte[] Padding2AEF5;
        /* 0x2AF00 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x2AF90 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x2AFA0 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x2AFB0 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x2AFB4 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x11, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x2AFB8 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x2B590 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x2B596 */ public byte[] Padding2B596;
        [NMS(Size = 0x3)]
        /* 0x2B598 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Size = 0x10)]
        /* 0x2B670 */ public string JetpackEffect;
        /* 0x2B680 */ public GcSeed FleetSeed;
        /* 0x2B690 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x2B6A0 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x2B6B0 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x2B6C0 */ public ulong LastKnownDay;
        /* 0x2B6C8 */ public ulong SunTimer;
        /* 0x2B6D0 */ public ulong MultiplayerLobbyID;
        /* 0x2B6D8 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x2B6F0 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x2B7A0 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x2B7B0 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x2B7B8 */ public GcHotActionsSaveData[] HotActions;
        /* 0x2BC68 */ public ulong LastUABeforePortalWarp;
        /* 0x2BC70 */ public ulong StoryPortalSeed;
        /* 0x2BC78 */ public ushort ShopNumber;
        /* 0x2BC7A */ public ushort ShopTier;
        /* 0x2BC7C */ public bool HasAccessToNexus;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x2BC7D */ public byte[] Padding2BC7D;
        /* 0x2BC80 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x2BCA0 */ public Vector3f NexusMatrixAt;
        /* 0x2BCB0 */ public Vector3f NexusMatrixUp;
        /* 0x2BCC0 */ public Vector3f NexusMatrixPos;
        /* 0x2BCD0 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x2BD30 */ public int BannerIcon;
        /* 0x2BD34 */ public int BannerMainColour;
        /* 0x2BD38 */ public int BannerBackgroundColour;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2BD3C */ public byte[] Padding2BD3C;
        [NMS(Size = 0x10)]
        /* 0x2BD40 */ public string BannerTitleId;
        /* 0x2BD50 */ public int TelemetryUploadVersion;
        /* 0x2BD54 */ public bool UsesThirdPersonVehicleCam;
        /* 0x2BD58 */ public float VRCameraOffset;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2BD5C */ public byte[] Padding2BD5C;
        /* 0x2BD60 */ public GcSeasonalGameModeData SeasonData;
        /* 0x2C1B0 */ public GcSeasonStateData SeasonState;
        /* 0x2C200 */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x2C201 */ public byte[] Padding2C201;
        /* 0x2C208 */ public List<NMSString0x10> RedeemedSeasonRewards;
        /* 0x2C218 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x2CC28 */ public byte[] EndPadding;
    }
}
