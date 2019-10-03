using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x522533AC131BE64B, NameHash = 0x78967207D9C549AA)]
    public class GcVehicleScanTable : NMSTemplate
    {
        public List<GcVehicleScanTableEntry> VehicleScanTable;
    }
}
