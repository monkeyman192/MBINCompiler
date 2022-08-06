using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74D06B2CE7228A08, NameHash = 0x52AAFE72AAC465AE)]
    public class GcInputBindingSet : NMSTemplate
    {
        /* 0x0 */ public GcActionSetType Type;
        /* 0x8 */ public List<GcInputBinding> InputBindings;
    }
}
