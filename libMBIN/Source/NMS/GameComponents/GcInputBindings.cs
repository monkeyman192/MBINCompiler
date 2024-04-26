using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE271A4D00CEC319, NameHash = 0xC710DABB91F38817)]
    public class GcInputBindings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcInputBindingSet> InputBindingSets;
    }
}
