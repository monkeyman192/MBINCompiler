using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlayerStateData : NMSTemplate // 0x396E0 bytes
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

        /* 0x00468 */ public List<string> KnownTech;
        /* 0x00478 */ public List<string> KnownProducts;

        /* 0x00488 */ public List<GcWordKnowledge> KnownWords;

        /* 0x00498 */ public List<GcPlayerMissionProgress> MissionProgress;

        /* 0x004A8 */ public int PostMissionIndex;
        /* 0x004AC */ public int Health;
		/* 0x004B0 */ public int ShipHealth;
        /* 0x004B4 */ public int Shield;
		/* 0x004B8 */ public int ShipShield;
		/* 0x004BC */ public int Energy;
        /* 0x004C0 */ public int Units;

        /* 0x004C8 */ public ulong TimeAlive;
        /* 0x004D0 */ public ulong TotalPlayTime;

        /* 0x004D8 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Size = 0x3E8)]
        /* 0x004E8 */ public ulong[] CompletedInteractions;

        /* 0x02428 */ public List<GcPlayerStatsGroup> Stats;

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

        [NMS(Size = 0x18)]
        /* 0x38FF0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies; // element size = 6, num elements = 0x18, total size = 0x90, end offset = 0x38FE0 + 0x90 = 0x39070, but next field is 0x39220?

        [NMS(Size = 0xA)]
        /* 0x39488 */ public GcUniverseAddressData[] AtlasStationAdressData;

        /* 0x39578 */ public bool FirstAtlasStationDiscovered;

        /* 0x3957C */ public int ProgressionLevel;

        /* 0x39580 */ public bool IsNew;

        /* 0x39581 */ public bool UseSmallerBlackholeJumps;

        /* 0x39588 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x10)]
        /* 0x395A0 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x396A0 */ public GcSeed[] PlanetSeeds;

        /* 0x397A0 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x397A4 */ public byte[] Padding397A4;

        /* 0x397A8 */ public ulong TimeLastSpaceBattle; // unsure what type, seems to be 8 bytes
        /* 0x397B0 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x3957B4 */ public byte[] Padding397B4;

        /* 0x397B8 */ public ulong TimeLastMiniStation; // unsure what type, seems to be 8 bytes
        /* 0x397C0 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x397C4 */ public byte[] Padding397C4;

        /* 0x397C8 */ public ulong MiniStationUA; // unsure what type, seems to be 8 bytes

        /* 0x397D0 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x397E8 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x39800 */ public bool[] GalacticMapRequests;

        /* 0x39820 */ public float SavedSunAngle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x39824 */ public byte[] Padding39824;

        /* 0x39830 */ public Vector4f SavedSunAxis;

        /* 0x39840 */ public ulong HazardTimeAlive; // unsure what type, seems to be 8 bytes

        /* 0x39848 */ public bool RevealBlackHoles;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x39849 */ public byte[] Padding39849;

        [NMS(Size = 0xB)]
        /* 0x3984C */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding396D4;
    }
}
