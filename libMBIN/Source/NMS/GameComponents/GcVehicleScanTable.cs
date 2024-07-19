using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1DEAE0A67F6DFAFB, NameHash = 0x65A159FE)]
    public class GcVehicleScanTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcVehicleScanTableEntry> VehicleScanTable;
    }
}
