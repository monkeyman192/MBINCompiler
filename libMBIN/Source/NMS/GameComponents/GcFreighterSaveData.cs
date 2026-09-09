using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x660D5EAF4F5675BA, NameHash = 0x164A36BD)]
    public class GcFreighterSaveData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x000 */ public Vector3f MatrixAt;
        [NMS(Index = 12)]
        /* 0x010 */ public Vector3f MatrixPos;
        [NMS(Index = 11)]
        /* 0x020 */ public Vector3f MatrixUp;
        [NMS(Index = 4)]
        /* 0x030 */ public GcInventoryContainer Inventory;
        [NMS(Index = 6)]
        /* 0x190 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 5)]
        /* 0x2F0 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 1)]
        /* 0x450 */ public GcResourceElement Resource;
        [NMS(Index = 3)]
        /* 0x498 */ public GcInventoryLayout CargoLayout;
        [NMS(Index = 2)]
        /* 0x4B0 */ public GcInventoryLayout Layout;
        [NMS(Index = 0)]
        /* 0x4C8 */ public GcSeed HomeSystemSeed;
        [NMS(Index = 7)]
        /* 0x4D8 */ public ulong LastSpawnTime;
        [NMS(Index = 8)]
        /* 0x4E0 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 9)]
        /* 0x4F8 */ public bool Dismissed;
    }
}
