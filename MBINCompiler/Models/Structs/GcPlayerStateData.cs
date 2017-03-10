using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPlayerStateData : NMSTemplate
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;

        /* 0x00018 */ public GcInventoryContainer Inventory;
        /* 0x00038 */ public GcInventoryContainer ShipInventory;
        /* 0x00058 */ public GcInventoryContainer WeaponInventory;
        /* 0x00078 */ public GcInventoryContainer GraveInventory;

        /* 0x00098 */ public bool SpawnGrave;
        /* 0x00099 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x0009A */ public byte[] Padding9A;

        /* 0x0009C */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x000B4 */ public byte[] PaddingB4;

        /* 0x000C0 */ public Vector4f GravePosition;
        /* 0x000D0 */ public Vector4f GraveMatrixLookAt;
        /* 0x000E0 */ public Vector4f GraveMatrixUp;

        /* 0x000F0 */ public GcInventoryLayout ShipLayout;
        /* 0x00110 */ public GcInventoryLayout WeaponLayout;

        /* 0x00130 */ public GcResourceElement CurrentShip;

        /* 0x003D8 */ public GcExactResource CurrentWeapon;

        /* 0x00468 */ public List<NMSString0x10> KnownTech;
        /* 0x00478 */ public List<NMSString0x10> KnownProducts;

        /* 0x00488 */ public List<GcWordKnowledge> KnownWords;

        /* 0x00498 */ public List<GcPlayerMissionProgress> MissionProgress;

        /* 0x004A8 */ public int PostMissionIndex;
        /* 0x004AC */ public int Health;
		/* 0x004B0 */ public int ShipHealth;
        /* 0x004B4 */ public int Shield;
		/* 0x004B8 */ public int ShipShield;
		/* 0x004BC */ public int Energy;
        /* 0x004C0 */ public int Units;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x004C4 */ public byte[] Padding4C4;

        /* 0x004C8 */ public ulong TimeAlive;
        /* 0x004D0 */ public ulong TotalPlayTime;

        /* 0x004D8 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Size = 0x3E8)]
        /* 0x004E8 */ public ulong[] CompletedInteractions;

        /* 0x02428 */ public List<GcPlayerStatsGroup> Stats;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x02438 */ public byte[] Padding2438;

        [NMS(Size = 7)]
        /* 0x02440 */ public GcInteractionBuffer[] StoredInteractions;

        [NMS(Size = 6)]
        /* 0x38FB0 */ public float[] Hazard;

        /* 0x38FC8 */ public int BoltAmmo;
        /* 0x38FCC */ public int LaserAmmo;
        /* 0x38FD0 */ public int GrenadeAmmo;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x38FD4 */ public byte[] Padding38FD4;

        /* 0x38FE0 */ public Vector4f FirstSpawnPosition;

        [NMS(Size = 0x2A)]
        /* 0x38FF0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        [NMS(Size = 0xA)]
        /* 0x39488 */ public GcUniverseAddressData[] AtlasStationAdressData;

        /* 0x39578 */ public bool FirstAtlasStationDiscovered;

        /* 0x3957C */ public int ProgressionLevel;

        /* 0x39580 */ public bool IsNew;

        /* 0x39581 */ public bool UseSmallerBlackholeJumps;

        [NMS(Size = 0x6, Ignore = true)]
        /* 0x39382 */ public byte[] Padding39382;

        /* 0x39588 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x39598 */ public byte[] Padding39598;

        [NMS(Size = 0x10)]
        /* 0x395A0 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x396A0 */ public GcSeed[] PlanetSeeds;

        /* 0x397A0 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x397A4 */ public byte[] Padding397A4;

        /* 0x397A8 */ public ulong TimeLastSpaceBattle;
        /* 0x397B0 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x397B4 */ public byte[] Padding397B4;

        /* 0x397B8 */ public ulong TimeLastMiniStation;
        /* 0x397C0 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x397C4 */ public byte[] Padding397C4;

        /* 0x397C8 */ public ulong MiniStationUA;

        /* 0x397D0 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x397E8 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x39800 */ public bool[] GalacticMapRequests;

        /* 0x39810 */ public Vector4f FirstShipPosition;

        /* 0x39820 */ public float SavedSunAngle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x39824 */ public byte[] Padding39824;

        /* 0x39830 */ public Vector4f SavedSunAxis;

        /* 0x39840 */ public ulong HazardTimeAlive;

        /* 0x39848 */ public bool RevealBlackHoles;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x39849 */ public byte[] Padding39849;

        [NMS(Size = 0xB)]
        /* 0x3984C */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x39954 */ public byte[] Padding39954;

        /* 0x39958 */ public GcResourceElement CurrentFreighter;
        /* 0x39C00 */ public GcInventoryLayout FreighterLayout;
        /* 0x39C20 */ public GcInventoryContainer FreighterInventory;
        /* 0x39C40 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x39C58 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Size = 0x5)]
        /* 0x39C68 */ public GcNPCWorkerData[] NPCWorkers;    // not in the save data?
        [NMS(Size = 0x2)]
        /* 0x3AA00 */ public GcPersistentBase[] PersistentPlayerBases;
        /* 0x3AA80 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Size = 0x2A)]
        /* 0x3AA90 */ public ulong[] SavedInteractionTimes;
        /* 0x3ABE0 */ public GcInventoryLayout BuggyLayout;
        /* 0x3AC00 */ public GcInventoryContainer BuggyInventory;
        /* 0x3AC20 */ public GcInventoryLayout Chest1Layout;
        /* 0x3AC40 */ public GcInventoryContainer Chest1Inventory;
        /* 0x3AC60 */ public GcInventoryLayout Chest2Layout;
        /* 0x3AC80 */ public GcInventoryContainer Chest2Inventory;
        /* 0x3ACA0 */ public GcInventoryLayout Chest3Layout;
        /* 0x3ACC0 */ public GcInventoryContainer Chest3Inventory;
        /* 0x3ACE0 */ public GcInventoryLayout Chest4Layout;
        /* 0x3AD00 */ public GcInventoryContainer Chest4Inventory;
        /* 0x3AD20 */ public GcInventoryLayout Chest5Layout;
        /* 0x3AD40 */ public GcInventoryContainer Chest5Inventory;
        /* 0x3AD60 */ public GcInventoryLayout Chest6Layout;
        /* 0x3AD80 */ public GcInventoryContainer Chest6Inventory;
        /* 0x3ADA0 */ public GcInventoryLayout Chest7Layout;
        /* 0x3ADC0 */ public GcInventoryContainer Chest7Inventory;
        /* 0x3ADE0 */ public GcInventoryLayout Chest8Layout;
        /* 0x3AE00 */ public GcInventoryContainer Chest8Inventory;
        /* 0x3AE20 */ public GcInventoryLayout Chest9Layout;
        /* 0x3AE40 */ public GcInventoryContainer Chest9Inventory;
        /* 0x3AE60 */ public GcInventoryLayout Chest10Layout;
        /* 0x3AE80 */ public GcInventoryContainer Chest10Inventory;
        /* 0x3AEA0 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x3AEC0 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x3AEE0 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x3AF00 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x3AF20 */ public GcResourceElement CurrentFreighterNPC;
    }
}
