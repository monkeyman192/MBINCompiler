using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66B0F0011EB0892F, NameHash = 0xD610CA25729E63C3)]
    public class GcRepairTechData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceContainer MaintenanceContainer;
        /* 0x1A0 */ public int InventoryType;
        /* 0x1A4 */ public int InventorySubIndex;
        /* 0x1A8 */ public GcInventoryIndex InventoryIndex;
    }
}
