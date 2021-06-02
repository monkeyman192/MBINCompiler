using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5D0, GUID = 0xF96A60B3E3E74A10, NameHash = 0xF5D7FBFDE561D6FB)]
    public class GcPlayerOwnershipData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 Name;
        /* 0x020 */ public GcResourceElement Resource;
        /* 0x2C8 */ public GcInventoryContainer Inventory;
        /* 0x428 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x588 */ public GcInventoryLayout InventoryLayout;
        /* 0x5A8 */ public ulong Location;
        /* 0x5B0 */ public Vector4f Position;
        /* 0x5C0 */ public Vector4f Direction;
    }
}
