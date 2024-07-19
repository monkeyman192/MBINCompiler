using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4D58EB2E5FA59FB, NameHash = 0x60597D1F)]
    public class GcDiscoveryRewardLookupTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcDiscoveryRewardLookup> Table;
    }
}
