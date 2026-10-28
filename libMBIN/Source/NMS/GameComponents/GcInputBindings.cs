using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC8B5C93D8E72F06, NameHash = 0xE7C17DC9)]
    public class GcInputBindings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcInputBindingSet> InputBindingSets;
    }
}
