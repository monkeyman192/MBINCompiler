using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x8746DCE6579255D5, NameHash = 0x4FBC05C9DB483F20)]
    public class GcMissionConditionHasEntitlement : NMSTemplate
    {
        /* 0x0 */ public NMSString0x10 Entitlement;
    }
}
