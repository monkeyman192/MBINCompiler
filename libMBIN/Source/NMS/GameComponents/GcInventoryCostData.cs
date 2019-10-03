using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5DC6800722F998DB, NameHash = 0x891585A60DC0D014)]
    public class GcInventoryCostData : NMSTemplate     // size: 0x118
    {
        [NMS(Size = 0x7, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        public GcInventoryCostDataEntry[] InventoryCostData;

    }
}
