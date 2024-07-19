using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD48D08266344CBCB, NameHash = 0x9CF047FE)]
    public class GcFrigateFlybyTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFrigateFlybyLayout> Entries;
    }
}
