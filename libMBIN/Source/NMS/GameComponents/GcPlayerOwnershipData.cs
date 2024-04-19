using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7CBC97F2A556B82, NameHash = 0xF5D7FBFDE561D6FB)]
    public class GcPlayerOwnershipData : NMSTemplate
    {
        /* 0x000 */ public Vector4f Direction;
        /* 0x010 */ public Vector4f Position;
        /* 0x020 */ public GcResourceElement Resource;
        /* 0x2C8 */ public GcInventoryContainer Inventory;
        /* 0x420 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x578 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x6D0 */ public GcInventoryLayout InventoryLayout;
        /* 0x6E8 */ public GcSeed Seed;
        /* 0x6F8 */ public ulong Location;
        /* 0x700 */ public NMSString0x20 Name;
    }
}
