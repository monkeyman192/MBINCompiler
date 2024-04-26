using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAAADFC5860EE007, NameHash = 0x13017671947A0ACE)]
    public class GcFrigateFlybyTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFrigateFlybyLayout> Entries;
    }
}
