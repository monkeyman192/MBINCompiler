using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69F9727EEB7351DC, NameHash = 0x41C689DE)]
    public class GcSpawnDensityList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSpawnDensity> DensityList;
    }
}
