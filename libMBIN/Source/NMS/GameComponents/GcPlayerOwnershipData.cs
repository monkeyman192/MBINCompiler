using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x437FF85234AFE30F, NameHash = 0xF5D7FBFDE561D6FB)]
    public class GcPlayerOwnershipData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public Vector4f Direction;
        [NMS(Index = 8)]
        /* 0x010 */ public Vector4f Position;
        [NMS(Index = 1)]
        /* 0x020 */ public GcResourceElement Resource;
        [NMS(Index = 3)]
        /* 0x2C8 */ public GcInventoryContainer Inventory;
        [NMS(Index = 4)]
        /* 0x420 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 5)]
        /* 0x578 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 6)]
        /* 0x6D0 */ public GcInventoryLayout InventoryLayout;
        [NMS(Index = 2)]
        /* 0x6E8 */ public GcSeed Seed;
        [NMS(Index = 7)]
        /* 0x6F8 */ public ulong Location;
        [NMS(Index = 0)]
        /* 0x700 */ public NMSString0x20 Name;
    }
}
