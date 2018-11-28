using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5DC6800722F998DB)]
    public class GcInventoryCostData : NMSTemplate     // size: 0x118
    {
        [NMS( EnumType = typeof( GcSpaceshipClasses.ShipClassEnum ) )]
        public GcInventoryCostDataEntry[] InventoryCostData;

    }
}
