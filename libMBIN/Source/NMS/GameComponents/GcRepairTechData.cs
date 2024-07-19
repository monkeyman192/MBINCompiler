using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD2ED9CE28BC1B0C3, NameHash = 0xBB983831)]
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
