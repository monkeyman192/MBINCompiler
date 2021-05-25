using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1A0, GUID = 0xFF031B966938227C, NameHash = 0xD610CA25729E63C3)]
    public class GcRepairTechData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceContainer MaintenanceContainer;
        /* 0x190 */ public int InventoryType;
        /* 0x194 */ public int InventorySubIndex;
        /* 0x198 */ public GcInventoryIndex InventoryIndex;
    }
}
