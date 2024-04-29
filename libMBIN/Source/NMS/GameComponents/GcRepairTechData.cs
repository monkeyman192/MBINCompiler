using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20E865FBC8D84FEE, NameHash = 0xD610CA25729E63C3)]
    public class GcRepairTechData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcMaintenanceContainer MaintenanceContainer;
        [NMS(Index = 3)]
        /* 0x198 */ public GcInventoryIndex InventoryIndex;
        [NMS(Index = 2)]
        /* 0x1A0 */ public int InventorySubIndex;
        [NMS(Index = 1)]
        /* 0x1A4 */ public int InventoryType;
    }
}
