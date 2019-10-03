using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA0, GUID = 0xD2EBEF87AE10463C, NameHash = 0xD610CA25729E63C3)]
    public class GcRepairTechData : NMSTemplate
    {
        /* 0x00 */ public GcMaintenanceContainer MaintenanceContainer;
        /* 0x90 */ public int InventoryType;
        /* 0x94 */ public GcInventoryIndex InventoryIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x9C */ public byte[] EndPadding;
    }
}
