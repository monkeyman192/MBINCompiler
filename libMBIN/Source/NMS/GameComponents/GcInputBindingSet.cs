using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3CFA1AA50EA1F349, NameHash = 0x52AAFE72AAC465AE)]
    public class GcInputBindingSet : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcInputBinding> InputBindings;
        [NMS(Index = 0)]
        /* 0x10 */ public GcActionSetType Type;
    }
}
