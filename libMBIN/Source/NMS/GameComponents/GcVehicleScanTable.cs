using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x39E37E0E5D0EA9DF, NameHash = 0x78967207D9C549AA)]
    public class GcVehicleScanTable : NMSTemplate
    {
        public List<GcVehicleScanTableEntry> VehicleScanTable;
    }
}