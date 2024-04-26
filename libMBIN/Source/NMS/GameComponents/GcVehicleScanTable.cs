using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B6DF3FC36759F3B, NameHash = 0x78967207D9C549AA)]
    public class GcVehicleScanTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcVehicleScanTableEntry> VehicleScanTable;
    }
}
