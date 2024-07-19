using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA89BEC7E7083393A, NameHash = 0x40268557)]
    public class GcPlayerOwnershipData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public Vector4f Direction;
        [NMS(Index = 8)]
        /* 0x010 */ public Vector4f Position;
        [NMS(Index = 3)]
        /* 0x020 */ public GcInventoryContainer Inventory;
        [NMS(Index = 4)]
        /* 0x178 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 5)]
        /* 0x2D0 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 1)]
        /* 0x428 */ public GcResourceElement Resource;
        [NMS(Index = 6)]
        /* 0x470 */ public GcInventoryLayout InventoryLayout;
        [NMS(Index = 2)]
        /* 0x488 */ public GcSeed Seed;
        [NMS(Index = 7)]
        /* 0x498 */ public ulong Location;
        [NMS(Index = 0)]
        /* 0x4A0 */ public NMSString0x20 Name;
    }
}
