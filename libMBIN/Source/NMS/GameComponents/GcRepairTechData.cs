using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DF7ADC91340006B, NameHash = 0xD610CA25729E63C3)]
    public class GcRepairTechData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceContainer MaintenanceContainer;
        /* 0x198 */ public GcInventoryIndex InventoryIndex;
        /* 0x1A0 */ public int InventorySubIndex;
        /* 0x1A4 */ public int InventoryType;
    }
}
