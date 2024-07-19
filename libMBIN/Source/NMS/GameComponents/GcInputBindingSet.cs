using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1332B8F40AAB144A, NameHash = 0x8D898CAF)]
    public class GcInputBindingSet : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcInputBinding> InputBindings;
        [NMS(Index = 0)]
        /* 0x10 */ public GcActionSetType Type;
    }
}
