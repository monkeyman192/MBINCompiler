using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x21DEF3B27B754C28, NameHash = 0x40268557)]
    public class GcPlayerOwnershipData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public Vector4f Direction;
        [NMS(Index = 7)]
        /* 0x010 */ public Vector4f Position;
        [NMS(Index = 2)]
        /* 0x020 */ public GcInventoryContainer Inventory;
        [NMS(Index = 3)]
        /* 0x180 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 4)]
        /* 0x2E0 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 1)]
        /* 0x440 */ public GcResourceElement Resource;
        [NMS(Index = 5)]
        /* 0x488 */ public GcInventoryLayout InventoryLayout;
        [NMS(Index = 9)]
        /* 0x4A0 */ public List<GcVehicleCargoData> VehicleCargo;
        [NMS(Index = 6)]
        /* 0x4B0 */ public ulong Location;
        [NMS(Index = 0)]
        /* 0x4B8 */ public NMSString0x20 Name;
    }
}
