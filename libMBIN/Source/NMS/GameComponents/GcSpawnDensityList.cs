using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x420883EE9B1542FA, NameHash = 0xED492007250EEE25)]
    public class GcSpawnDensityList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSpawnDensity> DensityList;
    }
}
