using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2FE52F1A8C4F38A2, NameHash = 0xF5D7FBFDE561D6FB)]
    public class GcPlayerOwnershipData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 Name;
        /* 0x020 */ public GcResourceElement Resource;
        /* 0x2C8 */ public GcInventoryContainer Inventory;
        /* 0x428 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x588 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x6E8 */ public GcInventoryLayout InventoryLayout;
        /* 0x708 */ public ulong Location;
        /* 0x710 */ public Vector4f Position;
        /* 0x720 */ public Vector4f Direction;
    }
}
