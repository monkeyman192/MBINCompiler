using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2167356EBA3C7AF2, NameHash = 0x19CB938A)]
    public class TkAllowedWaterConditions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkWaterCondition> AllowedConditions;
    }
}
