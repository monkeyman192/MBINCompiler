using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB17F47EC34A52218, NameHash = 0x9160051E7F0A1295)]
    public class GcDiscoveryRewardLookupTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcDiscoveryRewardLookup> Table;
    }
}
