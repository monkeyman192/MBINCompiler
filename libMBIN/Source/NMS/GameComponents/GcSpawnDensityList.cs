using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE910CE19E27FCF92, NameHash = 0xED492007250EEE25)]
    public class GcSpawnDensityList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSpawnDensity> DensityList;
    }
}
